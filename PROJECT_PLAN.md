# Project plan - Battle Royale Starter

Goal: Ek chhota playable multiplayer prototype (Android) jo room‑based multiplayer, basic movement, shooting, loot spawn, aur shrinking safe zone dikhata hai.

MVP scope (Phase 1):
- Unity scene with small map
- Photon PUN2 based matchmaking (room up to 16 players)
- Player movement (WASD / virtual joystick), aim & shoot
- Health, damage, respawn as spectator
- Loot spawner (weapons, medkits)
- Shrinking safe zone (simple timer-driven)

Deliverables:
- Starter repo (scripts + instructions)
- Unity project skeleton + one example scene
- Instructions to build APK

Estimated time (single dev):
- Starter repo + scripts & docs: 1 day
- Basic Unity scene & player: 3–7 days
- Playable multiplayer prototype: 2–4 weeks

Security & notes:
- For any real multiplayer launch, implement server‑authoritative checks and anti‑cheat.
- Replace local AdminKey dev approach with server‑side authentication.
