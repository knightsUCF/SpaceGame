# Intro

Here we will breakdown the game architecture, just the important parts to keep an overview of the codebase, and to prevent from things getting out of hand.

We will need of course some state machine, maybe simply we can call this: State.cs, so we will have: Game.cs, Player.cs, and State.cs, which will work well.

The state is really the data class, so we want to keep ALL data in State.cs, unless there is too much data, then we can break up the State.cs file into smaller files.

In this file, architecture.md, we also want to diagram out any configurations. We might have to create a folder for that, "architecture", in which we will upload the png configuration files, and refer to them from here in a numbered order. (Example: See Diagram1.png)

So going back to state, we will have to pull out any state data from Game.cs.

# Core

Create a prefab called "Core", and then under this prefab have Game, Player, and State


# Game.cs

Main Update():

     void Update()
        {
            if (restart)
            {
                if (Input.GetKeyDown(KeyCode.R) || Input.GetButton("Fire1"))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }

            CheckIfToAdvanceToNextLevel();
        }

    
Wave spawning:


    IEnumerator SpawnWaves()
        {
            yield return new WaitForSeconds(startWait);
            while (true)
            {
                for (int i = 0; i < hazardCount; i++)
                {
                    GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    Instantiate(hazard, spawnPosition, spawnRotation);
                    yield return new WaitForSeconds(spawnWait);
                }
                yield return new WaitForSeconds(waveWait);

                if (gameOver)
                {
                    restartText.text = "Press 'R' for Restart";
                    restart = true;
                    break;
                }
            }
        }
        
 # State.cs

# Player.cs



