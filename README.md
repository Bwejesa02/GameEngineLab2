AJ Bwejesa

100792221



Powerup Punch





The player moves around the scene using arrow keys or WASD.

Every few seconds, a random powerup appears somewhere in the scene.

The player picks up the powerup by touching it.

The powerup gives the player a special effect like speed boost, health restore, or shield.

The loop continues as more powerups spawn over time.



**Psudocode**



class PowerupFactory

method CreatePowerup(type, position)

if type is Speed

return new SpeedBoost

else if type is Health

return new HealthRestore

else if type is Shield

return new Shield



**Game starts**

PowerupSpawner randomly picks a type

Calls PowerupFactory.CreatePowerup

Factory returns a prefab

Player touches powerup

Powerup gives effect and destroys itself



Reflection



The factory can make three kinds of powerups

SpeedBoost

HealthRestore

Shield



The factory pattern is a good choice for this kind of project because 

it helps me spawn different powerups using just one function

I don’t need to write the same spawn code over and over

I can add more powerup types later without changing the whole spawner



I knew I had to use the factory pattern for this assignment

So I thought about what in a game is good to spawn using different types

I chose powerups because they are easy to see, collect, and test

I made an abstract Powerup script so all types follow the same rule

Then I used an enum to make it easier to choose which one to create

I used a spawner to call the factory and place the powerups in the scene



I learned how to improve planning and design for a new task quickly

When I got the assignment I first thought about simple ideas

Then I made a fast plan to use the factory to create game objects

It helped me finish the task faster without making it too complicated



External Assets Used

None

