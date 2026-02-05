# Create With Code Unit - 4 | Unity Version 6000.3.4f1

### _What things did I learn in this unit!?_

- This was an important unit with heavy _scripting_ and _logical thinking_ and a little bit of _maths_ of course!
- I learned how to make _enemies_ move towards the _players_ without using complex algorithms.
- In this unit I learned a different type of player control where the camera rotates and the player _moves in that direction_! Its a little wierd playing with these controls!
- Also learned how to implement simple waves of enemies where they keep increasing according to the _wave number_.
- And lastly implemented a basic _power up system_, which gives player some powerups and also spawn randomly.

## Major Programming Concepts Learned

- Learned how to use _co-routines_ in C#. Implemented in [PlayerController.cs](Assets/Scripts/PlayerController.cs#L-60).
- Learned how to make the enemy move towards the _player_, but slowly! Implemented in [Enemy.cs](Assets/Scripts/Enemy.cs#L-23).
- We have to subtract the _enemy's_ current position with the _player's_ current position and we will get the distance between the enemy and the player. And that's how the enemy travels towards the player!
- For Example:
  Player is at position (10, 0, 8)
  Enemy is at position (4, 0, 2)

```
Direction Vector = (10, 0, 8) - (4, 0, 2)
                 = (10-4, 0-0, 8-2)
                 = (6, 0, 6) <--thats the direction the enemy has to travel!
```

- In [SpawnManager.cs](Assets/Scripts/SpawnManager.cs#L-21) I have learned about a new method which can be used to find objects by type!
- Also in [SpawnManager.cs](Assets/Scripts/SpawnManager.cs#L-39) I have learned how to implement the waves of enemies and powerups

# Completed the challenge!

### Hitting an enemy sends it back towards you

- **Solution:** In [PlayerControllerX.cs](Assets/Challenge%204/Scripts/PlayerControllerX.cs#L-61) we have to change it to this `Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;`

### A new wave spawns when the player gets a powerup

- **Solution:** In [SpawnManagerX.cs](Assets/Challenge%204/Scripts/SpawnManagerX.cs), we have check a few lines, first being line 23 and change it to `enemyCount = FindObjectsByType<EnemyX>(FindObjectsSortMode.None).Length;`

### The powerup never goes away

- **Solution:** We have to add this new line in [PlayerControllerX.cs](Assets/Challenge%204/Scripts/PlayerControllerX.cs#L-42) to start a co-routine!
  `StartCoroutine(PowerupCooldown());`

### 2 enemies are spawned in every wave

- **Solution:** In [SpawnManagerX.cs](Assets/Challenge%204/Scripts/SpawnManagerX.cs#L-53) we have to change the for loop to make use of the `enemiesToSpawn` variable, like this `for (int i = 0; i < enemiesToSpawn; i++)`

### The enemy balls are not moving anywhere

- **Solution:** In [EnemyX.cs](Assets/Challenge%204/Scripts/EnemyX.cs#L-53), we have to add this line `playerGoal = GameObject.Find("Player Goal");` in the `Start()`, this will make sure it will find the `Player Goal` object in the hierarchy!
