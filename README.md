# Unity Assignment 3:
This assignment furtherly enhances the previous project.

[Itch.io link](https://shutafimpro.itch.io/space-panic)

## Main Changes:

- **Score Counter UI and Technical Changes**:
  - Now displayed in the UI layer, rather than below the player.
  - Now counted by modifying the [ScoreAdder.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/3-collisions/ScoreAdder.cs) to work with a new script [ScoreHolder.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/3-collisions/ScoreHolder.cs) script to each and every enemy spawned,
    adding easily customizable reward points for defeating different enemy types - done via the enemy prefabs within the inspector.
    This is demonstrated by adding a new "Big Enemy" tag and corresponding prefab, whose defeat adds more points.

- **Added Healthpoints**
  - The player now has 3 Health-Points shown by the UI in the form of an emptying heart icon.
    This mechanic was implemented by adding the [HealthPoints.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/3-collisions/HealthPoints.cs) script.
    
  - Using this script, the [GameOverOnCollision.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/4-levels/GameOverOnCollision2D.cs) script was modified from the original GameOverOnTrigger.cs script to handle collisions instead of triggers, and only kill the player after reaching 0 HP.
    [GameOverOnCollision.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/4-levels/GameOverOnCollision2D.cs) also handles hits done by enemy units to reduce the player's HP.
    
  - A health pack prefab was added in order to let the player heal every customizable period of time. Triggring with the pack executes the healing function accordingly.
    In addition, the [SpawnerAroundPlayer.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/2-spawners/SpawnerAroundPlayer.cs) was added, inheriting from [TimedSpawnerRandom.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/2-spawners/TimedSpawnerRandom.cs.meta) in order to create a capsular spawning zone around the player for the said health packs.

 - **Map Resizing and Bounding**
   - The map was scaled to be bigger horizontally in order for further movement of the player.
     This change requires also adding a Cinemachine camera for following the player.

   - After rescaling, map bounds were added to prevent moving out of the game map and various enemy spawners were placed according to the new map scale.
  
- **Enemy and Projectile Lifetime** -
  For optimization purposes, both lazers and enemies were assigned with the new [LifeTime.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/2-spawners/LifeTime.cs) script in order to destroy objects in a customizable time period from creation, thus preventing further usage of irrelevant data.
 
- **Original Change - Points Multiplier** -
  The x2 Multiplier was added to enhance the points obtainment for a limited period of time from activation.

  - The x2 Pack is dropped in the same manner as of the Health Pack, utilizing the [SpawnerAroundPlayer.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/2-spawners/SpawnerAroundPlayer.cs) script.
  - The [DoublePoints.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/3-collisions/DoublePoints.cs) script handles activation of the package by triggerment and lighting of a flag, indicated by a UI text shown in the top side of the screen.
    It is then invoking a function to disable the said flag in a customizable time interval.
  - The flag is then checked by the projectiles shot by the player for determining the amount of added points via their [ScoreAdder.cs](https://github.com/BarakFinkel/VGD-Assignment-3/blob/master/Assets/Scripts/3-collisions/ScoreAdder.cs).

## New Version Credits

Programming:
* Barak Finkel

Graphics:
* [New Assets](https://www.gamedevmarket.net/asset/2d-space-shooter-pack-2-0)

## Original Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
