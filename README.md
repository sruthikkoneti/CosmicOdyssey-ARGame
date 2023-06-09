# CosmicOdyssey-ARGame

A simple Augmented Reality Game in which a player has to shoot the AR components like celestial bodies to be specific Space-Ships.

The player wins a point for shooting down the virtual objects like Space-Ships but loses a point everytime when shot an object like Satellite.



## License

[MIT](https://choosealicense.com/licenses/mit/)


## Tech Stack

**Language:** C# (C-Sharp)

**IDE:** Microsoft Visual Studio

**Game Engine:** Unity Hub

**Other Tools and Frameworks:** Google AR Core, Apple ARKit XR Plug-in


## AR Components Used

- AR Session: It represents a period of time during which an AR app or experience is running and actively tracking the real-world environment. AR Sessions enable the seamless integration of virtual content with the user's surroundings, allowing for interactive and immersive AR interactions

- AR Session Origin:  It represents the anchor point within the AR environment from which virtual objects are positioned and rendered. The AR Session Origin acts as a reference point for aligning virtual content with the real-world surroundings, ensuring accurate placement and interaction within the AR experience.

- AR Raycast Manager: It facilitates the detection and interaction of virtual objects with the real world by casting rays from a specific origin point into the environment. By analyzing the intersections of these rays with real-world objects, the AR Raycast Manager enables features such as object placement, occlusion, and interaction in the AR experience.
## Features

This is an augmented reality game and players must use their smartphone to shoot down the virtual objects that appear on their screen. Key features of the game are:

- Score count
- Sound effects when player destroys objects.
- Background music while playing the game.
- Two levels:
   - Level-1 : An endless shooting game.( No negative points)
   - Level-2 : Score deducts by one point when the player shoots an object which is not supposed. The game ends when the score reaches -5.

- Button to pause the game.
- Buttons in Pause Menu to resume the game and to Quit the Game 
- Game built for Android API level 24 and above.

## Demo

https://github.com/sruthikkoneti/CosmicOdyssey-ARGame/assets/97946223/3895d92a-05ae-42a9-864d-f081c442bab2
https://github.com/sruthikkoneti/CosmicOdyssey-ARGame/assets/97946223/7dd7601d-b5b3-488c-bf83-b792fba2fe3b


## Assets Used



[3D Model Sputnik 1](https://assetstore.unity.com/packages/3d/vehicles/space/3d-model-sputnik-1-192475) by Ludashov Anton

[Magellan](https://assetstore.unity.com/packages/3d/vehicles/space/magellan-98970) by Evgeny Pritula

[Space Cruiser](https://assetstore.unity.com/packages/3d/vehicles/air/space-cruiser-1-124172) by Gamer Squid

[Sci-Fi Gun Light](https://assetstore.unity.com/packages/3d/props/guns/sci-fi-gun-light-87916) by Factory Of Models

[Cinematic Trailer Music - Collection](https://assetstore.unity.com/packages/audio/music/cinematic-trailer-music-collection-240943) by Gregor Quendel


## Project Setup on Local Machine and Deployment
Software prerequisites : Unity Hub, Microsoft Visual Studio 2022, AR Foundation, Android SDK

Clone the project

```bash
  git clone https://github.com/sruthikkoneti/CosmicOdyssey-ARGame.git
```
- Open the project directory as a new project in the Unity Hub Game Engine.
- In order to Build, Configure the `Build Settings` according to the requirements and build the APK file to install and run on Android or iOS.


## Link to Download the APK file of the game

[Cosmic Odyssey - AR Game](https://drive.google.com/drive/folders/1vIaKGfnJJde_mUyuyqHQ-Ksu2T3n9_m8?usp=sharing)
