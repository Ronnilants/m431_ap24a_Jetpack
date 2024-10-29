# Realize

# Design

# Order
1. Define the naming conventions
1. Design the Github directory structure
1. Design the game 

# Naming conventions

**scripts in Unity**

- every word begins uppercase
- no spaces

**sprites in Unity**

- all lowercase
- no spaces

# Github directory structure

- made a simple sketch of how the directory should look like

  ![Github directory structure image](../../01_Documentation/02_Resources/images/realize-sketch-directories.jpg)

# Game-Design

## sketches

- made a sketch of how the character should look like

 ![game sketch](../../01_Documentation/02_Resources/images/realize-sketch-character.jpg)

 - made a sketch of the obstacles

 ![sketch obstacles](../../01_Documentation/02_Resources/images/realize-sketch-obstacles.jpg)

 - made a sketch of how the game should look like when being played

  ![sketch game](../../01_Documentation/02_Resources/images/realize-sketch-game.jpg)

  ## final version

  - final version of the character design

     ![final character](../../01_Documentation/02_Resources/images/realize-final-character.png)

- final version of the obstacles design

     ![final obstacles](../../01_Documentation/02_Resources/images/realize-final-obstacles.png)

- final version of the game-design

    ![final game](../../01_Documentation/02_Resources/images/realize-final-game.png)

  # Setup

  # Order
1. Create Github directory structure
1. Install Github Desktop
1. install Unity
1. install Aseprite
2. Donwloads

# Create Gtihub directory structure

- created the directory structure in the Website itself with the sketch shown in the design part

# Install Github Desktop
- installed Github Desktop so we can commit and push our project from Unity
- cloned the repository from github into my desktop with Github Desktop

## How to clone repository with Github Desktop

- overview of Github Desktop

   ![overview Github Desktop](../../01_Documentation/02_Resources/images/realize-view-github-desktop.png)

- clone the repository

   ![clone repository Github Desktop](../../01_Documentation/02_Resources/images/realize-clone-repository-github-desktop.png)

  # Install Unity
  - installed Unity because its the game engine that we use
  - created the project

  ## How to create a project in Unity

  - overview of Unity, create project

     ![overview of Unity](../../01_Documentation/02_Resources/images/realize-overview-unity.png)

  - make it a 2D project

    ![make 2D project in Unity](../../01_Documentation/02_Resources/images/realize-create-project-window.png)

  - remaining configuration of the project 

  ![overview of Unity](../../01_Documentation/02_Resources/images/realize-project-configuration-unity.png)

  # Install Aseprite
  - installed it from steam
  - used it to design the characters and obstacles
  - costs CHF 19.50 but was bought for private use before the project

  ## How to create and configure a file in aseprite

  - aseprite in the steam library
 
     ![aseprite in the steam library](../../01_Documentation/02_Resources/images/realize-overview-steam-aseprite.png)

  - overview of aseprite
 
     ![aseprite overview ](../../01_Documentation/02_Resources/images/realize-overview-aseprite.png)

  - create the file
    
     ![create file in aseprite](../../01_Documentation/02_Resources/images/realize-create-file-aseprite.png)

- configure the file (size 128x128 pixels, color mode AGEA , background transparent)

     ![configuration of the file](../../01_Documentation/02_Resources/images/realize-configure-file-aseprite.png)

  # Downloads
  - [Unity](https://unity.com/de/download)
  - [Github Desktop](https://desktop.github.com/download/)
  - [Aseprite](https://www.aseprite.org/download/)

  # Implement

  # Order

- Implement the background
- Create scripts
- Implement the character
  - JetpackController
- Implement the obstacles
  - ObstacleController
  - ObstacleSpawner

  # Implement the background
- add the file in Unity so I can use it in the game by draging the file in to the sprites folder
 ![background](../../02_Jetpack/Assets/Sprites/background.jpg)
- add the file in the game by draging the file to the scene
   ![scene in unity](../../01_Documentation/02_Resources/images/realize-scene-unity.png)
  - added the background because it schould give the user a better understanding of the game
# Create scripts
1. created the scripts folder (same way as C# scripts)
2. pressed on the "+" button
  - ![script folder](../../01_Documentation/02_Resources/images/realize-scripts-folder.png)
3. chose C# script
 -  ![create script](../../01_Documentation/02_Resources/images/realize-create-script.png)
4. named it
  - ![name scirpt](../../01_Documentation/02_Resources/images/realize-name-script.png)
    
  # Implement the character
  - add the file like the backround to the unity by draging the file to the sprites folder
  - add the file (JetpackRider) in the game by draging the file to the main camera
  - ![main camera](../../01_Documentation/02_Resources/images/realize-main-camera.png)
  ## JetpackController
- this script is used for the movement of the character and the control of the character
- add the script to the character by draging it to the JetpackRider
  ![script jetpackcontroller](../../01_Documentation/02_Resources/images/realize-script-jetpackcontroller.png)
  # Implement the obstacles
- two files, ObstacleBottom and ObstacleTop
- the obstacles had to be prefabs so that when I spawn and delete them while playing theay still are saved
- made them prefabs by creating a prefabs folder and adding them to the folder, by draging the files in to the folder
  ![script folder](../../01_Documentation/02_Resources/images/realize-prefab.png)
  ## ObstacleController
- this script is used for the movement of the obstacles
- added the script by draging it to the files
  ![script folder](../../01_Documentation/02_Resources/images/realize-script-obstaclecontroller.png)
  ## ObstacleSpawner
  - this script is used to spawn obstacles at random height (x) positions so it doesnt get boring for the player
  - added the file by draging it to the scene and by choosing ObstacleBottom and ObstacleTop as game objects
 ![script folder](../../01_Documentation/02_Resources/images/realize-script-obstaclespawner.png)





