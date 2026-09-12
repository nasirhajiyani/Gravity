🌌 Gravity: Puzzle Platformer
<img width="800" height="595" alt="Gravity-ezgif com-gif-to-webp-converter" src="https://github.com/user-attachments/assets/9e05db76-80de-4b62-b7d0-4c62aa29f09d" />

**Gravity** — это хардкорный 2D-платформер, построенный на пространственных головоломках и управлении физикой. Главная особенность игры — манипуляция вектором гравитации, позволяющая перемещаться по стенам, потолкам и использовать инерцию для преодоления препятствий.

---

### 🎮 Key mechanics

**1. Gravity inversion**

The ability to instantly change the fall vector. Opens up space for non-standard platforming, bypassing deadly traps and moving along the ceiling.

<img width="800" height="595" alt="Gravity1" src="https://github.com/user-attachments/assets/ad472564-a501-463f-8831-bddc3175d3be" />

**2. Gravity Wells**

Local zones with altered attraction. The player can use these fields to change the plane of movement on the fly or use physical inertia to eject over long distances.

<img width="800" height="595" alt="Gravity2" src="https://github.com/user-attachments/assets/00bd80c9-f4f5-4837-9b3d-08b033b91d60" />

**3. Hardcore level design**

Locations require high accuracy, microcontrol, fast timing reading and understanding of motion physics. The price of a mistake is high, but the mechanics work predictably and responsively.

<video src="https://github.com/user-attachments/assets/ad45ce8f-551f-4c45-a8f3-3eb254a1b63f" autoplay loop muted playsinline width="100%"></video>

<details>

<summary><b>🎬 Expand gameplay gallery (4 more gifs)</b></summary>

<br>

<video src="https://github.com/user-attachments/assets/672eac26-d26a-43f4-a248-b50dc4c48481" autoplay loop muted playsinline width="100%"></video>

<video src="https://github.com/user-attachments/assets/5acc636c-5044-4ccd-89d8-6d6c83b01779" autoplay loop muted playsinline width="100%"></video>

<video src="https://github.com/user-attachments/assets/22350cec-1200-4ec9-ac9d-55bfdf7ce96a" autoplay loop muted playsinline width="100%"></video>

<video src="https://github.com/user-attachments/assets/08d34b1e-d363-4ab0-8752-16d787dcd8bb" autoplay loop muted playsinline width="100%"></video>

</details>

---

### 🛠 Technical implementation (Unity / C#)

The architecture of the project is built with a look at modularity and ease of scaling, based on the principles of **SOLID** and the Unity component approach:

* **Isolated physics:** All the logic of gravity manipulation is broken down into independent components. Classes `GravityWellInteraction` and `GravityInverter` encapsulate the logic of local fields and inversions without overloading the main controller of the player.

* **Separation of responsibility:** Input reading systems, movement processing and reaction to the environment (spikes, platforms) are isolated from each other. This makes it easy to construct new types of gravitational anomalies and expand the functionality without changing the core of physics.

---

### 🕹️ Management / Controls

The game fully supports both the classic mouse + keyboard layout and control from the gamepad:

| Action | ⌨️ Keyboard and mouse | 🎮 Gamepad |

| :--- | :--- | :--- |

| **Move** | `A` / `D` | Left Stick (Left / Right) |

| **Jump** | `Space` | Button `A` |

| **Gravity inversion** | `Shift` | Right trigger (`RT`) |

| **Well installation mode** | Hold `E` | Left trigger (`LT`) |

| **Confirm installation** | `LCM` (Left mouse button) | Right bumper (`RB`) |