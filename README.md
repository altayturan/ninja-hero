# Project-Staj

There will be a character standing in the middle of the screen in the game.
He will fire at the nearest enemy automatically every 2 seconds. 
(First fire will be only towards the front of the character, when an enemy reached a certain distance, shooter will target it)
Enemies spawn on the outside of the screen and move towards our character.
We try to survive for a certain time in the game.
Each enemy that reaches us does a certain amount of damage to us.
As the time progresses, health of the enemies increases and more enemies begin to spawn.
If you survive until the end of the time, you win the game.
If we run out of health before the time runs out, we lose the game.
Every time we kill an enemy, we earn gold.
We should see information such as skills, character features and game time on the hud screen.

#There are 2 types of enemies:
1) High speed and low health
2) High health and low speed

#There are 6 Skills:
*All abilities are leveled by spending gold (for passive abilities) or used (for active abilities).
*Passive abilities start at level 0, they take effect with the first purchase.
*Active abilities do not have a level, they can be used with gold.
1) Decreases frequency of all the character's shots by 0.1 seconds. (max level 11, passive)
2) Increases x1.1 damage of all the character's shots. (max level 42, passive)
3) Increases number of all shots. (Max level 3, can be fired with a maximum of 4 shots next to each other,
	if there are diagonal shots they will be reproduced in their own direction, passive)
4) Adds new diagonal shots (-30 and +30 degrees) to the right and left of the character. (can be purchased once, passive)
5) Deals damage to all enemies at once. (an active ability with cooldown)
6) For 5 seconds, all shots will be start firing every 0.1 seconds. When the time is up, they go back to their original state. 
	(an active ability with cooldown)

Note: Desired assets can be used in the game.
Note: Hud screen and gameplay screen will be in separate scenes.

Optional: The character can be moved with the help of a controller.
Optional: There may be obstacles on the map that allow enemies to change their path and block the character's shots.

**The game is completely up to your imagination. :)
**Whether it fires bullets or spells, whether it applies half damage when damaging all enemies or kills them all.
**It's all up to you, we just want to see the overall structure.
**Good luck.
