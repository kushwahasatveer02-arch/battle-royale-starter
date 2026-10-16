// Simple Photon NetworkManager (requires Photon PUN 2)
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    [Header("Photon")]
    public string gameVersion = "1";

    [Header("Admin (dev only)")]
    public string AdminSecret = "dev‑admin‑placeholder"; // change or set via Assets/Resources/AdminKey.txt

    void Start()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.GameVersion = gameVersion;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby — creating/joining room");
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 16;
        PhotonNetwork.JoinOrCreateRoom("BR_Room", options, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room: " + PhotonNetwork.CurrentRoom.Name);
        // Spawn player prefab (prefab must be in Resources folder and named "PlayerPrefab")
        PhotonNetwork.Instantiate("PlayerPrefab", Vector3.up * 2f, Quaternion.identity);
    }

    // Developer helper: check admin key loaded from Resources (dev only)
    public bool IsLocalAdmin()
    {
        TextAsset admin = Resources.Load<TextAsset>("AdminKey");
        if (admin != null)
        {
            return admin.text.Trim() == AdminSecret.Trim();
        }
        return false;
    }
}
