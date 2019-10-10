# Low Poly Astronaut with Animations!

https://assetstore.unity.com/packages/3d/characters/humanoids/stylized-astronaut-114298


# Low Poly Ships

Collection of low poly ships off Google Poly (need to give credit):

https://poly.google.com/view/1GMsmYGqJad

https://poly.google.com/view/6eRDOiTxvOo

https://poly.google.com/view/647DTebhyBD (like this one the best)

https://poly.google.com/view/dKFQSZCHQWf

https://poly.google.com/view/5nWeu4IQXVX




# On Using the Low Poly Style to the Advantage of Game Mechanics

* we could use the low poly asset to our advantage in for example converting something through an engine to some types of crystals we need for space travel


# Pivoting the Design

We are pivoting the design to something which solves all of our problems:

1. Not enough models or "game juice" type things to make the Space Invader genre viable
2. Discord between the two game modes
3. The shiny low poly asset pack might extra work
4. A solo adventure will require less 
5. An even lower low poly style, with solo adventure will help us keep the scope down
6. An exploration, fun, building game instead, which is perfect for iterating into Early Access
7. We can do basic stuff like in Astroneer, but with another indie flavor which is designed for VR
8. Easier to work, there is nothing wrong we can do, like mess up the combat progression in the Space Invader
9. The Space Invader genre does not really line up with our game aesthetic
10. Instead we want to make something like Spore, that the world feels large, but not necessarily complicated
11. We can easily procedurally generated a whole infinite world for the player to explore
12. This is more of a simulation game, which is our specialty
13. No combat in space, this saves scope, because no one will ask, and who cares, and much much much much much less work
14. We want a fun "bouncy" type of game. We are not going to get dizzy from moving the camera, but watch the astronaut have fun in zero space gravity
15. We want to build cool stuff, like establish a space station, the equivalent of that game Factory Town
16. We would like to do some engine building, perhaps water extraction from the surface
17. This game is both simpler than the City Building and also this Arcade Space Invaders game
18. This is something which guarantees us higher chances of success
19. This type of game lends to the iterating no prototypes way of working, which ensures finishing near the deadline
20. This is a type of game that anyone who has respect for VR can enjoy
21. This game has a relatively pretty wide engine, which Space Engine proved to have 
22. There are lots of possible situations here with planet generation, procedural galaxy generation, etc, so that the people might take lots of screenshots and share them to reddit like they did with the Space Engine game
23. We can really make this game look beautiful for low cost, flashing lights, neon glowing lights, beautiful planets, etc
24. Not sure yet how big or small the planets will be, but go for a low polygon style which is easy to finish 
25. And overall this just feels exciting to make, so the quality of work will be higher
26. Everytime the player plays the game can be totally different, especially with procedural generation
27. Space Exploration games have lots of dead empty space, which is easy for design
28. Like John Romero's game Space Rogue, just going between objects is exciting
29. People are divided on aliens, so having an empty universe gives us less work and is more scientifically accepted
30. We have a chance of organically designing the game with our own art style

For example check out this low poly recreation of No Man's Sky:

https://poly.google.com/view/466Hz6c-IjZ

We could also procedurally set up our own generation of the universe, and have a mini game like No Man's Sky where we can explore.

Since we are doing the whole no prototypes build the game as you go, we could do traveling around the universe, controlling a ship, and also landing on the planet. Make sure the camera rotation is locked, so not sure how we are going to do space travel just yet.


So going along with building a rolling MVP, let's do:

1. Universe generation
 A) Planets around a sun, a star system
 B) Random asteroids (perhaps take that rotation code from that one game, or use the current rotation code)
 C) Strange abstract vegetation, almost like from old school science fiction novels, take poly plant models and enlargen them, change to weird purple and other colors, and create a custom procedural system, which we build from scratch, will be much easier than a dungeon generation system, since we don't especially have to connect passageways, this is much easier
 D) 
2. Traveling between planets, and solar systems
3. Landing


# Make the Game To Feel Exciting from the Beginning, taking Advantage of VR

Even the outlines of the models could feel exciting if we arrange them right.



# 4X Game Design

Taking note of John Romero's Space Rogue: https://www.youtube.com/watch?v=vetUbjRB_0k

Quite surprising to notice how much depth there is in a simple game just because of the scrollable map and objects.

A scrollable map and attached objects is a powerful thing for gameplay!

So instead of just having one base, have a small map of the universe (which would look cool in 3D), and then allow the players to make camp on any of these planets. So we get a 4X type feel except the only direct encounters with others the combat fights. Oh well... If we can't do anything about this, we should necessarily take combat out.

Or make life easy, and only feature the space combat... 


Well, this is a difficult question, but we could focus on polish the space combat this month, if that becomes a contingency, but still not sure about the whole thing...


The feeling of flying through space is really cool, and also establishing a base.

Because if this game is just flying, that might get boring, we would like to move between stuff like in XCOM, where each part adds to the overall feel. The sum is greater than the parts... 

Seems like also one of the issues is that the space combat does not look that good in 2D in preview, and looks way better in person in VR. So perhaps we can add also asteroids flying overhead. And also focus on having lots of the enemy ships in formation. Like the classic shoot 'em up genre.


# Time Pressure

* time pressure can add intensity and fun

* time pressure like blitz chess, but perhaps we don't show them a clock, and instead use visual effects along with game mechanisms



# Main Point

* don't let the player catch on to repetition, vary the gameplay


# Order of Tasks

* keep outlining here important stuff

* determine tasks which can be done without VR

* get the intro and menus in early

<p>

1. Menu

2. Main Game Loop



# Game Progression

* different levels, different ship models

* increased formations and resilience of AI

* increased loot power ups, weapons, bonuses

* faster asteroids

* different colored asteroids, and also different shapes and arrangements

* different skyboxes (worlds), planet arrangements

* bosses?

* ...


# Menus (GUI)

* use the SF blue pack for windows and menu buttons

* create complete menu from these elements

* create score closer to home, in upper right hand corner, slightly rotate





# How to Find the Fun

Use the iteration model from Faster Than Light, where they hardly had a game design document, and found the fun through iteration


# Main Game Loop

* make sure we can experience the game in a continhuous comfortable game loop

* a continous game loop will create flow and a proper game experience for the players

* this includes:
  * game start transitions
  * game end transitions
  * game restart transitions
  * level transitions
  * sufficient explanation for the doable stuff
  * making sure the player is doing the right thing to progress along
  
* offer a pause button from early on

* can also do some voice guided computer tutorial stuff, but as long as we know what buttons are the rest should work first in a continous way before addressing button configurations

* later for button configurations we can let the player assign their own buttons

* perhaps for now we can have a diagram of an xbox controller, on which we can flash what to press, and then during gameplay also do that, so an average gamer will have every clue to figure out the gameplay without experiencing any sort of pain points




# Start Ship Place

* start the ship in the middle forward

* perhaps have a 3 2 1 countdown, arcade style

* what are some other arcade starter games?

* allow the player to rotate the ship but not move



# Game Over

* on game over screen, give some sort of audiovisual feedback in the moment that we wait to restart game

* make the restart period long enough to prevent the player from losing

* on game over perhaps we can watch our action of our death in a randomized angle each time, for that loadout screen, before we are allowed to restart the game, upon which perhaps something comes up "R to Restart" so whe know we can restart then, especially at the end of some sort of musical queue



# Loot Boxes

* the asteroids are loot boxes

* ships are also loot boxes

* like in mario, randomize the power up we get

* there will be also cross randomization strategies from the rogue genre


# Loot Model

* perhaps some sort of circlular half outline, with some goodie in the middle of the sphere

* two glowing arches, rotating, like in Mer de Noms, those spin towards you taking place of the asteroid


# Roguelike

* make the game roguelike in the sense of fun and progression, using procedural / random stuff

* rogue elements will make the game replayable, each time a unique experience

# Asteroid Speed

* increase the speed of the base asteroids on further levels, with random once in a while asteroids going super fast past you

# Log Screen

* create log screen on the left, which later can be used as an info display for the player

* in the position of where we would place a large TV to our side


# Art

* main models will be:
  * ships
  * planets
  * skyboxes
  * particle effects


# Story Intro

* have this early in the game, even if this is just a panel

* perhaps in VR we could be flying through the asteroids, next to a planet, while this intro plays out

* create a skip button for the intro to keep the game loop continous and always accessible


# Code

* use the existing code base but build on a clean and simple foundation



