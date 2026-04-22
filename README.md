# Computer Vision Simulation Environment (Unity (C#) and Blender)

## Overview
This project explores how simulation environments can be used to design and test computer vision systems.

It focuses on building a realistic 3D operating theatre environment using Unity and Blender assets, with the goal of experimenting with camera systems and multi-view setups.

---

## Simulation Approach

The Unity environment is used to model a real-world scene using imported FBX assets from Blender.

C# scripting is used to simulate structured data such as:
- Object positions
- Scene layout
- Camera viewpoints  

This allows simulation of annotations (e.g., object position and viewpoint) for potential training or evaluation of computer vision models.

---

## Key Concepts Explored

- Multi-view camera systems  
- Camera placement and visibility  
- Occlusion handling in complex environments  
- Foundations of object pose estimation and marker-less tracking  

---

## Example Simulation Script

Basic Unity (C#) scripting is used to simulate structured data from the environment.

Example:
- extracting object position and orientation
- supporting future annotation and CV pipeline integration

---

## Visuals

### Simulation Environment Objects
![Unity Simulation](OperatingRoomObject1.jpeg)

### Real-World Context
![Real World 1](SimulationData1.png)
![Real World 2](SimulationData2.png)

---

## Tech Stack
- Unity (C#)
- Blender (FBX pipeline)
- Python (for future CV integration)

---

## Future Work
- Integrating real-time object detection (YOLO)
- Multi-camera simulation
- Object tracking and pose estimation experiments
