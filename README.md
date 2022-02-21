# World-of-Windsor-The-University
## The first metaverse of the University

‘World of Windsor – The University’ is a role-playing game. This will be the first 2D metaverse developed for the University of Windsor. The game will serve as a medium for the players to learn about the university in an entertaining way.
This game will allow the players to select an avatar and roam in the metaverse of the university in a third-person view. There will be quests that the player needs to complete by interacting with the non-player characters (NPCs) in return for some rewards/points, which can be redeemed for real goodies or promo codes. There are different mini games that the player can play and earn points. 


# Code Overview
## 
Game Engine and Development Plateform: Unity

# Scenes
## 1. WelcomeScreen
On this page, the pictorial representation of the university is shown along with a ‘Start Game’ button which will be pressed by the player to begin the game and thereby proceed to the character selection process
  
  Game Objects:
  a. Main Camera
  b. wowWelcome
  The Background
  c. Canvas
    1. Button
    Play Game
  d. Event System
  e. Scene controller

## 2. CharacterSelection
  After login in, the player will be presented with two avatars (male and female) to choose from and then proceed to the Main Game
  
  Game Objects:
  a. Main Camera
  b. Background
  c. Canvas
    1. Text
    2. Male
    3. Female
  d. Event System
  e. Character Selector

## 4. MainGame
After selecting the avatar, the player will be taken to the main arena of the game based on an actual map of the University of Windsor. The arena will also feature buildings same as the actual buildings in the university premises. The Player will roam around and complete given quests on this main screen

  
  Game Objects:
    a. Main Camera
    b. Background
    c. Player
    d. Buildings
    e. Dialogue Manager
    
# Scripts

## 1. CameraController
Controls the camera to follow the player while moving

## 2. SceneController
Loads next screen based on player inputs
  Methods:
    LoadCharacterSelectionScene()
    
 ## 3. CharacterSelector
 Selects the avatar selected by player
 
 ## 4. PlayerController
 Controls player movement and animations
 
 ## 5. DialogueHolder
 Triggers dialogue managaer based on player actions
 
 ## 6. DialogueManager
 Used to show and hide the dialogue box
 
