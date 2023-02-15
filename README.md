## Powerup System with Strategy Design Pattern

This is a simple example of the Strategy Design Pattern in Unity

## What is the Strategy Design Pattern?

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## How to use it?

1. Create a new class that implements the PowerupEffect Abstract Class.
2. Define the behaviour of the Powerup in the new class. Do not forget to add the CreateAssetMenu option to the class.
3. Add the Powerup script to the object that will be the powerup activator in the game.
4. Assign the PowerupEffect field in the Powerup script.
5. Test it!

In this example scene, there are 3 cubes(powerups), each changing the color of the player when the player collides with it.

