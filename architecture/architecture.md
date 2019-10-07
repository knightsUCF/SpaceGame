# 10 / 7 / 19


So now we have the IEnumerator method working, and a good understanding of how the spawn waves work. The code is clean and backed up. FeelsGoodMan.

We also created a "space objects" folder, into which we will place all the space object, probably subdivided by type, so asteroid, and ship. So we will need both of those folders.

Because the ship will be asynchronous, whatever collisions happen will belong to that ship object, other than a global state change, which we want to do. (The global state machine in State is amazing. We can keep the game working asynchronously, give smart behaviour to AI, and simply have a much easier time. Space objects could read and write to a shared data set, not worrying about anything else, and the receipient can also read and write to the shared data set, not caring about anything else, yet the game will work asynchronously together.)

We are assuming that the space objects have some kind of relation.

We will want to reimport the space template project files (first delete), since we are missing some stuff.

We don't have to worry (too much) about restarting the project if some settings are overridden, since we are organized and modular. 

What we really need is to get those lights, and camera easily into the project. Later we could create exported asset packs.

So we will want to get the scene set up. We don't really need the audio, but we can use that one slot as a simple placeholder to get the audio going.

So we want to recreate the audiovisual from the game.

Then import the space objects.

Then take care of the dependencies in Game.cs, and test out spawning the actual prefabs.

We also want to get the other files written into the project, there are only a few more.

First we should get the other files in there.

The spawning part we pulled out, and we have a few more things to do in Game.cs, before reproducing the project.




# 10 / 7 / 19

Okay, so we are at a nice starting point of our codebase. Everything is clean and organized.

Next, we can either start to recreate the gameplay, or keep laying down the foundation.

Let's try to get the IEnumerator method working, since that will be our main wave spawning loop.

# 10 / 7 / 19

We began to clean up the code, starting with Game.cs.

We are using clean architecture, see Diagram1.png.

We also added an "AV" game object for "audiovisual" where we will keep the cameras and lights. (Diagram2)

So now we can proceed to cleanly set up the game.

We decided to have StartGame() in the start method of Game, since that is fitting to have a simple clean method like this. 

This will also serve to initialize any sort of things we need.

Currently after StartGame() we have wave.SpawnWaves(), which will begin spawning waves, while the player and other objects will just "appear" in the hierarchy, no need to spawn them, since they will be separate objects.

So now, we want to get the basics down of Input, Level, Player, and State. At least create the files and attach them in the hierarchy.


# 10 / 7 / 19


The next phase is to get the core working cleanly in the engine, along with prototyping with just the shapes, anything we need to do before the computer arrives. The arrival of the computer won't slow us down if we work toward buildng a stable foundation.

We can use the shapes to prototype ships, even if the ships are made out of simple cube shapes, that is enough for now. We can still use the outline asset pack on the prototyped ships.

So with the different ships we will want to begin the different waves of ships. And we can also build the menu transition to the base hangar, where the ship spins in 3D. This can all be done with the prototyping pack.

By the time the computer arrives, we could have the whole core working. Don't waste time testing out the game in VR, we can guarantee basically that the game will work in VR after the prelimenary testing, so just focus on building out the core gameplay.

We can also do the upgrades, from the asteroids and ships, we already have the core stuff for that.

Also create a basic weapon system, so that we can experiment with transitioning between different weapon effects (Weapon.cs)

Next up is also determining in which order we will be importing the code from here because of dependencies.


# 10 / 7 / 19

Game.cs was a convoluted piece of code, so we parted out all the functions by type, such as Score.cs, WaveSpawner.cs, InputManager.cs, and etc. 

When we get the Player code, we will also want to do that, namely with InputManager.cs, where we will get the RT XBox controller input.

So, what is up next?

* Finishing cleaning the game class

* Clean the rest of the code

* Begin assembling in the compiler

* Arrive at a clean foundation


Feels much clearer now, can go into Game.cs, and expect to only see stuff relevant to Game, instead of chewing through the spawner code, as one large big chunk of procedural code. Now the code is modular.

Excerpt:

"Modularity is at the core of everything. Initially I had approached this very differently, but it turned out after ~ 20 drafts that nothing else is as important as getting modularization right.

Good modularization makes building and packaging for the browser easy, it makes testing easier and it defines how maintainable the code is. It is the linchpin that makes it possible to write testable, packagable and maintainable code.

What is maintainable code?

Easy to understand and troubleshoot

Easy to test

Easy to refactor"

So finish the above steps, and also create repo for the original code base of the space shooter game, so we can easily refer back to in here.

# Intro

Here we will breakdown the game architecture, just the important parts to keep an overview of the codebase, and to prevent from things getting out of hand.

We want the game architecture to be event data driven, with modular parts, creating a robost framework.

We will need of course some state machine, maybe simply we can call this: State.cs, so we will have: Game.cs, Player.cs, and State.cs, which will work well.

The state is really the data class, so we want to keep ALL data in State.cs, unless there is too much data, then we can break up the State.cs file into smaller files.

In this file, architecture.md, we also want to diagram out any configurations. We might have to create a folder for that, "architecture", in which we will upload the png configuration files, and refer to them from here in a numbered order. (Example: See Diagram1.png)

So going back to state, we will have to pull out any state data from Game.cs.

Okay, so we have organized the project into "core" and "utils" folder, and we seem to be caught up with the organization. The organization might seem so easy in the beginning, but if we wait until later then the project will be much more difficult to organize without a solid foundation.

So the question is, what's next? Well we have our ToDo list over in log.md. This is mostly design stuff. In terms of code we could begin to create the empty files, "Weapons.cs" and etc.

Then determine what is the first thing we will code. Well, how about first cleaning up the beginning foundation before moving on to new feature. Just to make sure the core is working first. No prototypes!

# Redoing Game.cs

We want to start here. Rewrite the code, pulling out the state info, which we can simply reference now as State.GAME_OVER, since this is inside a singleton.

# Core

Create a prefab called "Core", and then under this prefab have Game, Player, and State.


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



