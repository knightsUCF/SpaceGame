# Need the Small Preview Icon like Celeste

Very artful, like Forager an illustration of the game. DO NOT LAUNCH WITHOUT THIS!

# Celeste Secret

Celeste relies on having a lot of different moves, all in one a smooth and polished motion. This really entertains the player.

Count up the number of functions in the Celeste Player code, and then count up the number of special moves.

Try to go for this density. And polish each move. Does the action need more Lerp? Etc. Check the code of Player in Celeste.


# Animations

We should do a custom animation for space walking, to feature those realistic bounces of astronauts. Don't try to invent this, check reference material. This will make a huge difference.

# Controls

Try to get the controls really right like they did in Celeste, and even published their code in C#! Reference this:

https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs

# Put a Warning in the game for strain in VR

Please use the VR camera mode more than the action mode to ease with strain in VR.

Or is there someway we can let the player naturally make that conclusion?

# Minimalistic Nintendo like Trans Culture Design

Critics will give us more favorable reviews if instead of an UI, everything is intuitive like a toy, and we don't have to go through the phase of picking out UIs. For Early Access, why not.

# Crystal Mining

Okay, so what we want next is crystal mining, along with effects and sounds.

Go through that sci fi sound pack for some nice laser and mining sounds. We can go through all sorts of sound effect packages for sci fi sounds. We should probably in off time go through literally hundreds of packs on sound cloud, before purchasing the one, that is really good sounding. Sound design is huge.


so we will want to have an animation for the astronaut to his lazer. 

We should be able to easily tie an animation to a key, and then blend that animation with the astronaut idling.

If we have problems with this, then simply outline the process here in the journal step by step and we will get going.

So mining, with pleasing audio visual will be a huge step.

so when we transform the rock crystal formations, how do we collect the resources?

well perhaps there is a 3d printer, which makes anything, we just need the right types of resource combinations, recipes

we can have a cool screen which shows the alchemy of 3d printing, so wich resources in combinations, show by pluses, will we need for our 3d modeling, and some of course will need a lot

so we will have things like carbon, silicon, basically all the real elements that a thing in real life is made out of

So we will definitely want to have a rover. take the car design from the city.

If we are going to design our own rover, the thing will look very cool, sleek and modern, and hip, and truly futuristic

Also we will want to have solar powered apparatus, with deep humming 3D stereoscopic sound, and spread, when we power up the generators

So we will want a 3D printer, which can print us a rover, and some base materials


That we can then use to build a small base, and even grow vegetables, and make a space greenhouse, which will be shaped in cool spheres like the Silent Running greenhouse

For now we just want a solo experience to simplify things and release the game


So, after this phase we will have procedural world generation, and the ability to go around and mine minerals

And then after we gather our minerals we can build stuff with the 3D printer

We can label the machine as a 3D printer, and that's what we have in the back of our ship, so we will need to land the ship,
and then bring out the 3D printer, which will have a cool blue screen enclosure, in which we can build our stuff

Also color theme the 3D printer, the hues, the blues, light blues, etc, always use color theming, even in isolation


On the ship we will have a cargo bay, in which we can place and store stuff.

As a sidenote for procedural world generation we will also have plants, and more greener habitats that will look like alien worlds, we will err on the side of alien worlds, so we don't have to do too fancy world and level creation


So in summary so far, we want to get to the point where we will have world generation, which is a module, so we won't affect the state of any other code, or break anything else, although we don't want to end up in a time sink, that is the only risk

This game is summing up to be as a very relaxing idle game, that's something we want

People can just zone out and relax


But we still want to bring a sense of wonder, especially with tall oversized solar panels


So even though this game will not be free to play, we will have some work required in gathering the resources to build the structures, so if you want to build a series of power panels, you need the silicon (electronics), steel (iron?), look up what base materials are made out of to keep the thing realistic, so we might in fact need like 10 elements to build a solar panel, so that will provide a goal in the early game for the player to collect these materials so they can build things

When we build things we can just plop them there for now with a noise, or perhaps the 3D printer will print the part, with the part beginning life as a holographic image in the 3D printing chamber, and then slowly transforming, perhaps by turning up the color to the real thing



Gold will be an actual real resource, so people will love to go around and hoard these things

And some exotic minerals, that we want to create, perhaps undiscovered yet, going along with the alien theme of the worlds in the game


Also once in a while, but only once in a while so doesn't get tedious, we would like to have a shooting star





# Clean Up Scene by Adding a Scene

* perhaps we should add a scene to clean up the scene, where we load late because of the intro screen 

# Black Fog Settings

Simply do exponential squared with density of 0.02, and full black for the color

# Laser Asset

We can use this free volumetric lines asset for a laser: https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160

# Laser Sound FX

https://assetstore.unity.com/packages/audio/sound-fx/weapons/sci-fi-weapon-sfx-by-great-heights-audio-147911

we want to have a really solid experience with a destructable world, so when we mine, the world then throws chunks at us, so we can have a destructible environment

# Reviewing the Game

* colors theming does wonders, easy but huge pay off and makes the game look professional, especially in screenshots, and trailers, which will help to sell the game

* taking these rock formations, we could create a pink and purple topsy turvy world, which offers unique minerals to gather there, so we can get a lot gained just from these simple color schemes

* and of course we can use lighter worlds and midtones

* sounds are very important, so keep improving on those also

* what is really cool are destructible terrains, let's try to find a laser on the asset store, and use that to extract rocks



# Recap


So we have come just out of creating the environment, color theming the rocks, and using variety on the rocks.

Those rocks are all we need to generate a few different worlds.

One world will have taller and sharper rocks, etc. 

Find a bunch of low poly rock formation we can throw together for planet types.

If we go through all this trouble, definitely advertise that this is game features a procedurally generated universe.

We need a better skybox, but with similar colors. We should color theme the skybox too, try to find blues, in all the different color arrangments from adobe, including blue.

We probably need to procedurally generate our own skyboxes, and we couls still throw up some stuff, like a milky way, but we really want to have those colors custom, to generate lots of color themed worlds. This will give a lot of organic unity to the game.


So where are we now? 

Well we did:

1) Created mountains and color themed them to make up for the environment, along with black fog
2) Created crystals and highlighting


So from here these two things split up into two large branches:


1) World procedural generation
2) Resource gathering



We will want to stagger work on each, but we should probably start with the resource collection first, and then start on world gathering, and then move back to resource gathering when we get tired.

In the end with these two things we want:

1) a color themed universe with a variety of aesthetically chosen rock formations
2) a resource mining chain, which we can then take that universe, explore, and mine and refine, and process resources, perhaps into a Rokenbok type mechanism, or maybe something simpler for now, like in Subnautica


# Goals Already!

Having the goal of going toward the lighted up cystal was great.

We can do something similar in the game where if you are within the vicinity of a crystal, and you will eventually be, because we will scatter them around evenly, with not a straight probability but a good randomized probability, then when you are vicinity, we want to begin to only show you the outline when the object is a little larger that way we don't have a sloppy looking dot on the horizon.

And that helps the player because they pick up the item.

Feels good walking aorund the map with something to do, to pick up these crystals.

Now have satisfying sounds and lights when we mine, and then collect the crystal.






# Black Fog

Black fog looks great! The only thing is we will need to turn down the fog, when we fly in the ship, because everything is too blackened out. So we will need a dynamic process for this.


# Moonrock Color Theme

Using the Adobe color wheel we have the choice of analogous vs monogchromatic: 

"The analogous color scheme uses colors that are adjacent to each other on the color wheel. ... The analogous scheme is similar to the monochromatic one, but offers more nuances. Pros: The analogous color scheme is as easy to create as the monochromatic, but looks richer."

So the analogous color scheme is richer than the monochromatic one, so let's go with the analogous color scheme.

These color schemes we will want to have saved with sets of RGB values for the procedural generation, so even though the procedural generation is random we have preset color schemes.

And of course pre pick out what's good.

And also we can combine the analogous with the monochromatic scheme for more variety in one package.

Our central color is moonrock:

Nice super light green hue, for a Dean Foster sci fi look and feel: #E8FEFF

Pink: #FFE5DB


These three colors actually look really great together: #958D84 #E8FEFF #FFE5DB, and 80674B


use 80674B for the dark browns!








color of the moon rock: 


# Procedural Rock Formation

Pretty cool to have the large rocks... Now we want to artistically arrangement, so using that golden ratio of 75%, let's use that to randomize things in a golden ratio fashion, maybe use some golden ratio mathematics also, we can talk about that in the article, and that will get a lot of hype, even though the 75% is more practical and we will use that more.

So we can generate a diverse everytime, yet get that special seed number for the player.

The other thing we can do is generate a wide variety of colors, all sorts of color themes in gray.

We can vary up the color themes, yet keep the astronaut in basic colors, which will match any color scheme, white and black, maybe with some flashing lights on the back and shades of black for variety.

So with the procedural generation we can generate an infinite number of designs with some solid procedures in place:

1. create "prepackaged" clumps which work, have enough of variety of these clumps that per planet the player will not notice

2. use color schemes to generate a pleasing assortment of different colors each time, on each of the planets, a color scheme coded in a look table for what type of planet that is based on the randomized distribution of assets and minerals

3. use different sizes and rotations for variety, along with arrangements

4. when the terrain begins to slope, we will need to create some "islands" of where we put things so we make the math is easy

5. We can vary the crystal deposits that go in the different rocks, so that is another level of variation, and store these as prefabs we can use to generate things.

# Crystal Resources

Crystals look nice as resources. Definitely use them.

This asset pack is free and what we're beginning with: https://assetstore.unity.com/packages/3d/props/stylized-crystal-77275

This is a very nice one at $7.50: https://assetstore.unity.com/packages/3d/environments/fantasy/low-poly-crystal-cave-82797

More variety here, $15: https://assetstore.unity.com/packages/3d/environments/low-poly-series-caverns-74148

Nice one for gold rocks, free: https://assetstore.unity.com/packages/3d/props/exterior/low-poly-resource-rocks-76150

Nice one for moon rocks, free: https://assetstore.unity.com/packages/3d/environments/fantasy/stones-and-buried-treasure-95557

Search for "low poly crystals"


# Menu Soundclick

This was a little tricky. We have to place the audio source outside of the menu, because we are going to inactivate that, getting rid of our audio. 

So create a Sound game object component right under "AV" (Audiovisual)

Attach an audiosource here.

Then in menu use this code:



    public class Menu : MonoBehaviour
    {

        public GameObject menu;
        public GameObject audioSource;




        // when a player clicks the menu, turn off the text, and start up the game

        public void OnMenuClick()
        {
            Debug.Log("Clicked on the menu");
            audioSource.GetComponent<AudioSource>().Play();
            // menu.SetActive(false);
        }

    }


# Free Skyboxes

https://assetstore.unity.com/packages/2d/textures-materials/sky/galaxybox-1-0-18289

# Sound Design

Would be nice to fade in and out music based on what the player is doing, so if they're building, more exciting, if they are in deep space then the music is more ambient, etc.


Free space sounds: https://assetstore.unity.com/packages/audio/sound-fx/space-sfx-102218-131463

Space stuff including menu clicks: https://assetstore.unity.com/packages/audio/ambient/sci-fi/universe-sounds-free-pack-118865


# Main Track

https://www.youtube.com/watch?v=qCB9qAkza4o

Use: onlineconverter.com works great also

Get the first few minutes, sounds nice atmospheric and generic enough to work.




# On Beginning to Design the Gameplay

Okay, great, we got all of the prelimenaires out of the way. 

We would like to begin designing the gameplay.

Here is a rough order of elements:

1) Procedural world
  A) Generate 4 star systems to test, each star system is one yellow ball object, with a randomized number of planets, and colors
  B) Generate procedural terrain on the planet. This will be an iterative process, but start with: (see diagram 1)
2)Sound
  A) Immediately grounds the player in the world, use those creepy atomospheric Cthulhu vibes of deep space
  B) Use lots of sound effects immediately, because that is huge for putting meat on the bones of the game design
3) Color theming!
  A) Goes a long way, and should be set in immediately, because there is not that much effort for the huge difference
4) Allow some sort of basic ship movement, and camera rotation movement, so we can visit our procedural creation
5) Make the planets rigid bodies, and give movement to the player, we can use the Unity Third Person Controller, and refer back to our notes of setting up the thing, with the planet being a nav mesh, with baking in the objects on the terrain


So at this point we would like to have a procedurally generated world, on which we can walk around and explore.

That should be the whole goal, and nothing else, of this phase of the rolling MVP, since all that we build will work to being the final gameplay.

There is a quesiton then how much we want to polish. We should polish a lot here, so we get the basic astronaut and ship flying movement right, since this will be so huge to the gameplay. Of course this element is so huge, we will polish a lot later, but definitely polish beforehand also.
  
  
Diagram 1 - Generating fauna

This will have to go through phases

1) First generate one model type on the surface
 - create surfaces for each of the surfaces, triangle primitives, on which we can instantiate stuff by things we can preassign in advance, for the area location to make life easy
2) Then generate different colors
3) Then generate different arrangements
4) From then on just iterate


# Color Theming!

Since this is a specific type of low poly game, we should heavily use color theming to our advantage. If we do, the audience will get the impression the game was stylized by a professional designer, which is what we want. Especially in VR, a styling game would look amazing.

The Color theming we would want to start to try with dark blues, and blacks?

Will need to experiment. Spend serious time experimenting with color theming since this will be one of the easiest and most paramount ways to affect the look of the game.


# Rokenbok

We can now go back to our true passion of designing Rokenbok inspired toys.

So the crystals that we mine, those are like in rokenbok our resources. Since this is a game, we can have lots of different resource "balls / crystals", that have their separate properties, and simply the player can distinguish them based on color.

And also we want to appeal to people's natural sense of hoarding, which is huge in selling games.

So like Rokenbok, they can aggregate, segregate, and assimilate the materials.


AGGREGATE

SEGREGATE

ASSIMILATE 

This also creates a lot of depth to the game loop. A reason players could get bored is because of shallow shooting nature of the depth of a Space Invaders game.

Here we can perhaps use the trigger, to have the astronaut shoot stuff from his space gun, which perhaps radiates the crystals, the beam of light works really great, and would work in previews.


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
31. Lots more of screenshots we can take to make the trailer interesting, fill out the trailer
32. The music can be more minimal, even beautiful, much more suited to our style, and also less work of writing a busy action score
33. Space stuff is much easier to design than fantasy stuff, doesn't have to be positioned in the world as precisely, instead can just float on space or grow on a rock, plus with the planets just simply being there, spheres, geometrical objects, basic stuff
34. Facililates better build process, easier to have a rolling MVP with this kind of original indie game

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



