## Project Title: Winter Wonderland
Name: Lena Kibler

Student Number: C18499016

Class Group: DT211C / Year 4

## Description of the project
The project within this GitHub Repository consits of a procedurally generated terrain as well as various different 3D Models. The theme of this project is winter and Christmas inspired with the main asset being a Santa Claus sleigh that is programmed using C# to fly accross the terrain using user keyboard input. The addition of christmas audio is used in this project to further support the Christmas theme and to tie the project together into one cohesive scene. Originally the project was meant to only focus on the winter terrain and not Christmas, making it more of a nature scence with spawning animals and snow falling out of the sky. I feel like I have maintained some aspects of my original plan by still creating a winter feel in the project. Among the winter-mountain-like terrain there are randomly spawned giant candy canes that you can fly around to see up close but don't attempt to lick them !!. In addition to the candycanes there are also randomly spawned gift boxes falling out of the sky and tumbling amongst the moutains. When you look up and ahead into the star filled sky, you can notice the northern lights on display (also known as Aurora Borealis) creating an awe inspiring animation. 

## Instructions for use
1. Assuming that the whole project has been downloaded onto a machine, and that Unity is installed, open up the SampleScene.unity file in 
	* WinterWonderland > Assets > Scenes
2. Once the screen has loaded, navigate the mouse cursor to the play button at the top-middle of the screen and left click the mouse to start the project.
3. Allow time for the project to kick start.
4. Once the scene has loaded and you hear the audio, that means that the project has successfully started
5. Use keyboard keys to navigate the Santa Sleigh across the terrain.
6. The approriate keys are:
	* Up        --> fly up
	* Down      --> fly down
	* Left      --> move left
	* Right     --> move right
	* Space Bar --> move forwards
	* Left Ctrl --> move backwards
7. Fly around the terrain and have fun !!

## How it works
When the project has been activated (i.e the play button has been pressed), the main terrain begins to procedurally generate using the TerrainGenerator script. This script allows the terrain to change every 0.2f, resulting in a never-ending generation of random mountains with different float points. Simultaneously the Candycane Prefab that's attached to an empty game object called SpawnCandycane, gets placed all along the terrain in random postions. This is possible thanks to the ItemAreaSpawner script thats attached to the SpawnCandycane object. There are two other prefabs that spawn while the project is playing, they are called Present1 and Present2. Present1 is attached to an empty game object called SpawnPresents and Present2 is attached to SpawnGifts. Both of these game objects use the ItemAreaSpawner to drop presents out of the sky onto random points within the terrain. The Sleigh object has a Santa Claus object within it. The Sleigh object itself has programmed controllers so that users are able to fly around the terrain. The main camera is also attached to this object. The srcipt attached to the Sleigh is called SleighController and it allows for it to have forward, backward, up and down movements by making use of the Input Manager within Unity. There are two seperate audio sources that use two seperate audio clips. One of them is called Background Music and its populated with a Christmas jingle. The second audio source is called Santa Claus Audio and its populated with Santa Clauses voice. Both are played immediatelly after the project has been played. 

## List of classes/ assets in the project 
| Class/Asset | Source         
|-------------|----------------
| Terrain     | Modifed From [Reference6](https://www.youtube.com/watch?v=vFvwyu_ZKfU)
| Sleigh      | Self Made
| Candycane   | Self Made
| Present1    | Self Made
| Present2    | Self Made
| Santa Claus Rigged | From [Reference1](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/santa-claus-rigged-167437)
| Night Sky   | From [Reference2](https://assetstore.unity.com/packages/2d/textures-materials/space-star-field-backgrounds-109689)
| Santa Noise | From [Reference3](http://soundfxcenter.com/holiday-and-festive/christmas/8d82b5_Santa_Claus_Says_Merry_Christmas_Sound_Effect.mp3)
| Xmas Music  | From [Reference4](https://freemusicarchive.org/genre/Christmas)
| Northern Lights Pack | From [Reference5](https://assetstore.unity.com/packages/vfx/particles/environment/northern-lights-pack-86980)
| TerrainGenerator.cs | Modified From [Reference6](https://www.youtube.com/watch?v=vFvwyu_ZKfU)
| SleighController.cs | Self Made
| ItemAreaSpawner.cs | Self Made

## References
Reference1: Downloaded from the Unity Asset Store, Created by ergin3d.

Reference2: Downloaded from the Unity Asset Store, Created by Dilapidated Meow.

Reference3: Downloaded from soundfxcenter.com, Created by Sound FX Center.

Reference4: Downloaded from freemusicarchive.org, Artist: Scott Holmes Music.

Reference5: Downloaded from the Unity Asset Store, Created by Ian Scilipoti.

Reference6: Code viewd in a Youtube video, Created by Brackeys