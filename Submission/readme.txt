World War Z

1.What the application does

We implemented a zombie survival game in which a knight lost on the country has to survive against an infinite amount of zombies that try to kill him. The user will control the knight and has 4 attacks to choose from to defend himself. We keep track on the amount of zombies the player has killed and add save the score. Also we are going to keep track of the highest score achieved by a player. This high score will be displayed in the main menu. We implemented a timer which runs for 5 minutes, which is the time the player is given to beat the high score. The player wins when he is still alive after the 5 minutes and beat the previous high score. He loses in case he dies or his score is less than the high score. We also added a mini feature that allows you to control a ball instead of the knight which is controlled by the accelerometer. 

2. How to use it

We implemented virtual buttons and a joystick to the interface. On the left side is the joystick that can be rotated around and the character moves accordingly. The attack and jump buttons are on the right side of the screen, making it easy to control the knight with both thumbs. Each button corresponds to a different attack. We implemented a timer on the top of the screen as well as a score count and a quit button that allows the player to leave the game at any time.

3. How we modelled objects and entities

We downloaded the knight (our main player) from mixamo.com as well as its animations. The zombies and their animations were downloaded from the same page. This allowed us to save some time for modelling objects with Maya or Blender. The terrain has been implemented by using the built-in 3d terrain object. Also the grass and trees on the terrain come from the environment asset package within unity. 

4. How we handled graphics and camera motion

We created a couple of shaders, a phong shader, which we used on the rock, which is the starting point of the game. A fog shader which is rendered on the surface of our safe zone. The house at the end of the map has a cel shader attached. The shadow volumes are visible once the player is on the rock. The water around the rock is also made from a shader using the bump mapping technique. For the camera motion we have attached a script to the camera object, which follows the player’s position.

Appendix:

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