In this project, I have completed the requirements for the 3D Essentials and Audio Essentials tutorials. To make the review process easier(for you), I create a specific folder that contains my scene: Assets/TaskScene.
Implemented Features:
* Camera Movement (Player Controller):
* Implemented a script that allows for first-person exploration of the scene.
* The user can move using the WASD keys and look around using the Mouse. This setup allows for testing the spatial audio from different positions and perspectives.
* Ball Bounce SFX (Collision Trigger):
* Created the TriggerSoundOnBallFall script.
This script detects when the ball hits the ground and triggers the SFX_Ball_Bounce sound effect using AudioSource.PlayOneShot. I also added a Volume slider in the Inspector to easily fine-tune the sound level.

Environmental Audio & Atmosphere:
* Integrated wind ambient sounds.
* Thunder SFX: Sourced from the Free Sound Effects Pack.
* Ambient Wind: Sourced from the Nature Essentials pack.
* 
Both sounds use 3D spatial settings to ensure they react correctly to the player's position.

I used the provided .gitignore template as instructed in classroom. 
Open the project and navigate to Assets/TaskScene.
Open the TaskScene (or FinalTaskScene) file to see the completed environment with lighting, scripts, and audio components properly configured.
