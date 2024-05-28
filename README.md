# Flappy Bird Clone

This project is a recreation of the popular mobile game Flappy Bird using the Unity game engine. The player controls a bird, navigating it through a series of pipes by making it flap its wings to avoid obstacles. The game features a score system, game over conditions, and a simple user interface.

![1](https://github.com/saahen-sriyan-mishra/Flappy-Bird-Clone-UNITY/assets/139043263/f9fa5826-ccdf-4736-ba57-f5c715013f75)

## Scripts

### GameManager.cs

The `GameManager` script is responsible for managing the overall game state, including starting and ending the game, as well as keeping track of the player's score.

#### Methods:
- `IncreaseScore()`: Increases the player's score by 1 and updates the score text.
- `GameOver()`: Handles the game over state, displays the game over UI, and pauses the game.
- `Play()`: Resets the game state and starts the game.

### Player.cs

The `Player` script controls the bird's movement and collision detection.

#### Methods:
- `Update()`: Handles the bird's flapping and movement.
- `OnCollisionEnter2D(Collision2D collision)`: Detects collisions with pipes and triggers the game over state.

### Pipes.cs

The `Pipes` script controls the movement and destruction of pipe obstacles.

#### Methods:
- `Update()`: Moves the pipes to the left and destroys them when they go off-screen.

### Spawner.cs

The `Spawner` script is responsible for spawning pipes at regular intervals.

#### Methods:
- `Start()`: Initializes the spawning process.
- `SpawnPipe()`: Instantiates a new pipe at a random vertical position.

