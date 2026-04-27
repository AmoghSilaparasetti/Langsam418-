# CS 5136 Project 2: Langsam 418 VR Simulator 

Amogh Silaparasetti, Jonah Carter, Anne Ning, Soham Vakani 

## Motivation

The primary objective of this application is to provide an immersive, interactive VR experience of Langsam 418. By recreating this specific environment in a virtual space, stakeholders can test and iterate upon various room arrangements without the physical labor, cost, or time constraints associated with moving heavy furniture. This tool serves as both a spatial preview and a functional utility for interior planning and classroom optimization.

## Design 

The virtual environment is a high-fidelity recreation of the Langsam 418 space, focused on realistic scale and visual clarity.

### Environmental Assets

- **Custom Furniture**: The tables and chairs were custom-modeled in Blender by team member Jonah to ensure they accurately reflect the specific dimensions and aesthetics of the actual room.

- **Human Scale Models**: To provide a sense of occupancy and scale, human models were generated using the MPFB (MakeHuman Plugin for Blender) asset library.
<img width="501" height="256" alt="VR_HumanModel" src="https://github.com/user-attachments/assets/bee34867-d580-46bd-9049-a097476ed9e8"/>

- **Prop & Detail Assets**: To enhance immersion, everyday items such as backpacks and peripheral props were sourced from community repositories including SketchFab and Thingiverse.

<img width="501" height="256" alt="amogh_Vr" src="https://github.com/user-attachments/assets/c0ee8e23-03cd-45b6-8f82-e19235e0a5cb" />

- **Interface Elements**: The information boards and screens that display layout data utilize SVG assets designed in Figma for crisp, scalable visual fidelity within the Unity engine.
<img width="501" height="256" alt="VR_documentation_Photo" src="https://github.com/user-attachments/assets/1900192a-d608-4dcc-b2d2-b981b6bbdf4c" />

<img width="501" height="256" alt="vr_documentation_image4" src="https://github.com/user-attachments/assets/4d83629b-2bfd-4607-9371-52350a122d62" />


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

## Challenges and Future Work 

### Technical Obstacles

One of our primary hurdles was the discrepancy between documentation and implementation. Several features advertised as "plug-and-play" within the Meta SDK did not function as intended when following official tutorials. This required significant troubleshooting and manual overrides. This experience highlighted the importance of deep platform knowledge when working with rapidly evolving XR toolkits.

### Future Development

- **Raycast Interaction:** We plan to implement an in-room menu system that allows users to swap layouts on the fly using a raycast pointer.

- **Physics & Tangibility**: We aim to add physics interactions to the props (backpacks, laptops), making the space feel more tangible and "lived-in."

- **Expanded Interactivity**: Moving from static previews to allowing the user to pick up and move furniture in real-time within the VR environment.

## AI Usage and Collaboration 
- **AI Integration**: Large Language Models were used as a research tool to understand the underlying architecture of the Meta SDK and to debug specific API calls. No AI-generated code was used in the final production of the application scripts; all logic was manually authored by the team.

## Demo Video 

- Watch a demonstration of the Langsam 418 VR Simulator below. This video includes a voiceover walkthrough of the room, a preview of the different layout designs, and a look at the locomotion system in action along with the props we have designed. 

[Click here to watch the Langsam 418 VR Demo Video](https://mailuc-my.sharepoint.com/:v:/g/personal/vakanisa_mail_uc_edu/IQDSGPXi99OnQ5QgrkSeJmhpAbRnNDU2L2C7_u2qjcq_3XM?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=Sghh6K)




