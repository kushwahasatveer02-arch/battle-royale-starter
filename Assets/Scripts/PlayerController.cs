using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviourPun
{
    public float speed = 5f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (!photonView.IsMine)
        {
            // disable control for remote players
            enabled = false;
        }
    }

    void Update()
    {
        if (!photonView.IsMine) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v);
        if (move.sqrMagnitude > 0.01f)
        {
            controller.SimpleMove(move * speed);
        }

        // Simple shoot example (left mouse / tap)
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // placeholder: in real game use raycast/hit registration with server authority
        Debug.Log("Shoot!");
    }
}
