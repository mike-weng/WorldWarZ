Game description
This is a 2.5d zombie survival game. The objective of this game is to survive massive zombies attack
for 5 minutes and kill as many zombies as possible. There will be a score count for each
zombie you kill. The terrain is huge enough for you to explore and play around.

Usage
	1. git clone https://github.com/mmmk84512/WorldWarZ
	2. go to Assets/_Scenes
	3. open up MenuScene with unity
	4. go to file->build and run

Gameplay
	1. press play to start the game
	2. press objective to view the instructions
	3. press exit to close the game
	Objective:
		- kill as many zombies as possible to score points
		- stay alive for 5 minutes
		- beat the high score
		- there is a safe zone where zombies cannot enter
	Controls:
		- use the joystick for locomotion
		- 1 basic attack and 3 skills
		- 1 jump button to jump and avoid zombies
		- each skill has a small cooldown to avoid spam
	Ball rolling mode:
		- instead of controlling the character with joystick,
		  you can tilt the device to controll a ball

Objects modelling
	- terrain of the game is constructed using Unity's standard assets
		- textures such as grass, rock and water
	- we also used a plane that is shaded by custom water shader to produce a different kind of water
	- we used unity's skybox to create a dark foggy environment
	- Zombie character is a 3D model downloaded from Maximo.com
	- Player character is a 3D model downloaded from Maximo.com
	- The medieval house is a 3D model downloaded from Unity Assets Store
	- Player and Zombie character both have a controller script and a character script attached to the game object
		- controller script receives the input from user and feed it to the character script
		- character script uses the input parameters to update the position and animation
		- PlayerCharacter and ZombieCharacter inherit from Character which is an abstract class
	- Each skills of the character is a game object
		- the character script pass the input parameters to each skill to update animation and collider
Camera motion
	- camera follows your character's position at an angle
	- it is a 2.5D camera therefore the rotation of the camera does not change
Graphics
	1. custom phong shader applied on rocks
		- shader uses phong shading technique
		- shader allows showdows to be casted by reading unity's shadow map
	2. custom cell shader for the medieval house
		- shader uses cell shading technique
	3. custom shader for water plane
		- transparant shader with water bump mapping

External sources used:
1. Maximo.com (3d models, animations)
2. Unity Standard Assets
	- humanoid animations
	- environmental assets (trees/materials)
3. Shadow casting shader code
	- https://alastaira.wordpress.com/2014/12/30/adding-shadows-to-a-unity-vertexfragment-shader-in-7-easy-steps/
4. Cell shader
	- http://www.gamasutra.com/blogs/DavidLeon/20150702/247602/NextGen_Cel_Shading_in_Unity_5.php
5. Fog shader
	- http://answers.unity3d.com/questions/758950/add-alpha-support-for-fog-shader.html