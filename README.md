# Battle Royale Starter

Ye repo Unity + Photon PUN2 ka starter template hai jo ek simple multiplayer battle‑royale prototype banane mein madad karega. Aap is project ko clone karke apne machine par Unity mein open karein, Photon AppId daalein aur Android ke liye build karke APK bana sakte hain.

Important: Ye ek original inspired prototype hai — Free Fire jaisa exact clone nahi.

Quick steps (short):
1. Clone repo:
   git clone https://github.com/kushwahasatveer02-arch/battle-royale-starter.git
2. Install Unity 2021.3 LTS ya 2022.3 LTS + Android Build Support.
3. Open project in Unity.
4. Import Photon PUN2 (Window → Asset Store / Package Manager → search Photon PUN 2 - Free) and follow setup.
5. Set your Photon AppId: Assets/Resources/PhotonAppId.txt (ya Photon → PUN Wizard).
6. Open scene "Assets/Scenes/Starter.unity" (agar scene missing, README mein diye gaye steps follow karein).
7. For testing, run multiple Editor instances or build APK and install on devices.

How to get an APK quickly (local):
- In Unity: File → Build Settings → Android → Build (make sure Player settings are configured and keystore if signing required).

Admin / "Modi ji" access (development mode):
- By default the project includes a simple AdminKey check file: Assets/Resources/AdminKey.txt
- To become admin in prototype, put a secret string in AdminKey.txt locally (same on any device) and update NetworkManager.AdminSecret in the inspector OR edit the file. This is only for development/testing and must be replaced with a secure server‑side auth for real prod.

Photon AppId placeholder: open Assets/Resources/PhotonAppId.txt and paste your Photon AppId (get one free at https://www.photonengine.com).

Notes & next steps:
- I will push a small Unity scene and scripts next. Large binary assets and built APKs are not included in this commit — follow README to build locally. Agar chahie to main CI build pipeline banaakar release APK provide kar sakta hoon (iske liye aapko Unity license ci token dena hoga).

Contact/Help:
- Agar aap chahte hoon main aapke liye APK bana kar upload kar dun, mujhe bataiye — main ek CI flow ya manual build karunga aur release upload kar dunga.
