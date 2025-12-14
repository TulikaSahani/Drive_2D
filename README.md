# Basic 2D Player Movement & Interaction
This project demonstrates core 2D gameplay mechanics built in Unity, focusing on smooth movement, physics-based interactions, and environment awareness.

<img width="1155" height="689" alt="Image" src="https://github.com/user-attachments/assets/2da7d8c0-fcd9-437e-b7bc-5dc31396c143" />



🕹️ Features Implemented

2D Player Movement

* Smooth directional movement using keyboard input
* Frame-rate independent motion using Rigidbody2D
* Controlled speed and responsive player handling
* Physics & Rigidbody2D
* Utilizes Rigidbody2D for realistic movement and collision response
* Prevents manual transform-based movement for better physics accuracy

Collision Detection

* Uses Collider2D components for solid object interaction
* Prevents the player from passing through buildings, trees, and boundaries
* Handles physical interactions with the environment seamlessly

Trigger-Based Interactions

* Implements IsTrigger colliders for non-physical interactions
* Detects player entry and exit using OnTriggerEnter2D / OnTriggerExit2D
* Ready for use cases like checkpoints, collectibles, NPC zones, or events

🧠 What This Demonstrates

* Understanding of Unity’s 2D physics system
* Clean separation between movement logic and interaction logic
* Scalable foundation for adding:
* Pickups & collectibles

🛠️ Built With

Unity (2D)

* C#
* Rigidbody2D & Collider2D
* Event-driven trigger logic
