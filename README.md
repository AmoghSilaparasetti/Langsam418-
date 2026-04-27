# CS 5136 Project 2: Langsam 418 VR Simulator 

## Motivation

The primary objective of this application is to provide an immersive, interactive VR experience of Langsam 418. By recreating this specific environment in a virtual space, stakeholders can test and iterate upon various room arrangements without the physical labor, cost, or time constraints associated with moving heavy furniture. This tool serves as both a spatial preview and a functional utility for interior planning and classroom optimization.

## Design 

The virtual environment is a high-fidelity recreation of the Langsam 418 space, focused on realistic scale and visual clarity.

### Environmental Assets

- **Custom Furniture**: The tables and chairs were custom-modeled in Blender by team member Jonah to ensure they accurately reflect the specific dimensions and aesthetics of the actual room.

- **Human Scale Models**: To provide a sense of occupancy and scale, human models were generated using the MPFB (MakeHuman Plugin for Blender) asset library.

- **Prop & Detail Assets**: To enhance immersion, everyday items such as backpacks and peripheral props were sourced from community repositories including SketchFab and Thingiverse.

- **Interface Elements**: The information boards and screens that display layout data utilize SVG assets designed in Figma for crisp, scalable visual fidelity within the Unity engine.

### Visual Elements

The application prioritizes a clean, functional aesthetic. Every visual element—from the texture of the desks to the placement of the whiteboard—is designed to help the user evaluate how different configurations affect sightlines and movement flow within the room.

## Technical Process

The application was built using the Unity engine, leveraging modern VR frameworks to ensure a smooth user experience.

### Architecture & Tools

- **Frameworks**: We utilized the Meta (OVR) SDK, specifically taking advantage of the "Building Blocks" components to accelerate development.

- **Locomotion**: Smooth locomotion is handled via OVR’s built-in functionality, allowing users to traverse the room naturally.

- **Custom Scripting**: While SDK components handled the basics, we developed custom C# scripts to manage the Layout logic and the Layout Display systems, which synchronize the physical placement of objects with the UI data.

### Access & Execution

Due to the significant size of high-resolution VR assets and specific Meta Quest compatibility requirements, the project is not currently hosted as a web-build.

- **To Run**: Download the full project repository.

- **Requirements**: Unity 2022.3 LTS (or later) and the Meta XR All-in-One SDK.
