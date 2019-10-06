# 10 / 7 / 2019

So even though this might seem like a long drawn out campaign game, this is more similar to a roguelike game such as Spelunky, in that after permadeath we have to restart, which is what keeps players playing, and gives the core replayability to the game. So likewise even though we have this involved environment, the gameplay is like a rogue, where we still start at the beginning and have to build our base over. So our base building, engine building, worker placement, those will be very elegant clean elements like toys, where we can replay like a level of Mario, and still get satisfaction in the basic elements.

People will get a lot of satisfaction just from traversing their space labirynths they create. Even a game like Alice, which is very interesting, there is still some tedium, in trying to figure out how to transverse levels, being stuck in a gray box of the spaceship while you're trying to figure out how to progress, those things are not always particulalry fun, while in this game we give the player a nice Big Mac they can eat right away. The gameplay is immediate right there, satisfaction in spades all over. So in that way we can compete in the market. If Spelunky, a 2D game could be such a sensation, we can also create a roguelike in VR with these elements.


# 10 / 7 / 2019

* engine building and worker placement, along with tile laying are the most favorite mechanics of board games, so...

* create engine building, worker placement, and tile laying in the ramifications of building up this space colony, kind of like XCOM style, also create this sort of engine that people get satisfactions out of playing Factorio, so we can still have this satisfaction of building our own interactive engine. This doesn't have to be hard to do if well designed

* so, our bio lab affects our stock piles of food, which affects how many colonists we can have, and in turn how many workers we can do worker placement with. Now these effects can be basic yet still gamify the experience and provide the best of Factorio. The trick is to bring out what really is an engine building game, worker placement game etc... In an engine building game "we build an engine", something affects other parts like cogs in a watch. We are trying to create this precise Swiss watch. So this doesn't necessarily require any extra assets than what we have or crazy long pages of code, instead we simply have a state machine, if we have enough plants (which need the proper nutrients fed, etc, some sort of cool VR read of CO2 levels), and then that increases food production, which opens up the requirements to having more workers, so the code is very simple yet very satisfying gameplay emerges

* likewise do this for the tile laying mechanic, a very satisfying way to build

* we are covering the top mechanics of the board game list: worker placement, engine building, and tile laying. Along with also recreating the first video game sensation, Space Invaders, and also going off X-COM the strategy layer with base building, and the tactical combat, which will be in Space Invaders style. So this is a recipe for success.

* can have a cool intro update, "The year was 1996, I was 9 nine years and completely fascinated by the new wave of 3D video games. One of these games was X-COM. I would watch my cousins play (talk about cousins collecting games) Create these blog post updates."

* to handle the complexity first start with the basic game loop, along with the hangar, and no prototypes! just build the game as you go

* so we would have our basic game loop, which would be flying around and getting loot in a rogue procedurally generated Space Invaders environment. After that is done we have the ability to go into our hangar and spin the plane around, which should be no problem at all. At this point we also want to have the menus designed, and the intro story, plus sound effects.

* so that is the absolute basic core we need to start with.

* once that is done we will need to work on some progression mechanisms, and loot drops, and upgrades

* after that add a little more elements to the base, and also add base building, along some sort of grid, or perhaps no grid

* just building our own hangar area will be cool

* after that we will need the colonists, along with the animations, if they are already rigged then this should not be a problem, and we can already create the AI navmesh

* so perhaps we can get the basic hangar and progression of the game going in 20 days

* then in the next month work on the colony simulation

* and the third month polish, and fill in holes

* if we work smart we can get this done

* we could also introduce the concept of biodomes, where we would grow the food

* the trick of not getting lost in growing scope is to pace the game building so we always have an MVP finished product instead of a prototype, so we would first have the full combat tacticle missions done, where we can fly around asteroids, get upgrades and etc, then we would finish the hanger since that is modular, then we would approach every part as a modular piece that will not impede finishing, and then of course we have Early Access

* going along with this concept of a rolling MVP (Agile) we will want to build out the menus, title screen, and the intro early so this will be the base of our MVP and feel like a complete game 


# 10 / 7 / 2019

* we have the primitive asset pack so we can prototype the whole game out, without relying on art packs

* plant out method of prototyping, although we want to have the game in the current ready state at all times, we can still go far with these primitives

* lots of amazing ships we could use here for the final models, and also asteroids, but the pack is $120, so save this until the end: https://assetstore.unity.com/packages/3d/environments/sci-fi/polygon-sci-fi-space-pack-138857

* this prototyping pack would be great if we were working on a mario like VR platformer: https://assetstore.unity.com/packages/3d/props/exterior/polygon-prototype-pack-137126

* another cool thing to do would be able to unlock all sorts of ships, and each of the ships have their own upgrade trees, which if planned could work well, this adds further to the replayability of the game, each ship has different abilities, maneuvors, feel of the ship, and weapons, and also sound effects

* would also be nice if the player can collect a few ships and place them in their space hanger, so they can decide which ships to use on which missions

* the other big advantage of the polygon space pack, is that we could use the hanger for the player to walk around and check out their ships, perhaps also let the player assemble their own ships, with the loot that they gain from the space battles, this would really break up the monotony, but there is a risk the player might enjoy the hangar part too much

* perhaps we could even add a little base building to the game, like XCOM, so we would have a few parts:

 1. the combat area
 2. the base / hangar area
 3. universe overview cool area, where we can investigate the different parts of the star system, although this would have to look really cool

* that asset pack also has very cool locking on missle targets, so we could have some lock on missiles, with which we would lock on to the enemy and then send guided missles like in Star Fox, which would add another element to the game

# 10 / 6 / 2019

Very nice style spaceships, but a little too much poly: https://assetstore.unity.com/packages/3d/vehicles/space/cube-spaceships-pack-01-110342

The spaceship going up and down, while in space might add a nice touch while we are idling. We don't want to do this when we're moving, only idling.

For purchasing items, we could have some sort of inter galactic black market, something out of Neuromancer, with the glowing green 3D objects, some sort of data links, perhaps we purchase plans to print in a 3D printer, etc.

One way of getting free advertising is to send out the game keys to magazines which review games.

Nice pick up items: https://assetstore.unity.com/packages/3d/props/modular-pick-up-items-99720

Check out "Enter the Gungeon", a relatively simple game but a success. Every scene is framed by a neon glowing weapon, we need to do the same: https://store.steampowered.com/app/311690/Enter_the_Gungeon/

Study Enter the Gungeon and recreate the same sort of fun gameplay feel, along with Forager.

Also create a very nice research tree in 3D, which the player can orbit around, some sort of Matrix like cyberpunk feel. This will do wonders, namely three things: 1. break up the monotony of the game (perhaps we can choose this between levels) 2. create a research tree upgrade mechanism, adding to the progression and fun of the game, and 3. create strategy

Next to the research tree we could have the cargo bay, in which we can rotate the ship, perhaps add new weapons, check out how they look, and then pull up our tree of upgrades. Then after the player finalizes their selection, they are taken into the next level.

If we could do a really hip research tree like this but in 3D: https://assetstore.unity.com/packages/2d/gui/icons/sci-fi-upgrades-window-138966

And on top of this, the 3D VR Research Tree would be easy to do, and would really set the game apart.

Put a lot time in making the weapons feel good, like the creators from Dead Cells.

Also have some sort of orbiting glowing balls going around in nice circular patterns for the player to dodge.

Use Lerp and sine wave functions, and smooth damp and others to get a very smooth effect going in lots of things, so the game just feels great.

Also need a professional art cover, like Enter the Gungeon. We could have pilots, and perhaps aliens and ships, something very worth of Space Commander, like a cross between enter the Gungeon, and the Super Mario Land / Warrio box cover.

Make the best possible game in 3 months, ready for Early Access. This will pay off.

Also use a nice lighting effect, with beautify, or the light set up from Space Journey, to really make the glowing lights pops in the darkness, and against the space backgrounds.

Showing just darkness of course will not sell the game, but if we have all sorts of hologrpahic light effects, along with asteroids, and space ships, and lots of fast movement, that will sell the game.

We could do some triangular arrow like weapon, that has a nice coverage area. Very useful for getting ride of a lot of things in one area, so this would be used in harder levels, and have limited ammo.

We want to create a way for the player to use strategy in what weapons they use, so that they don't waste the weapons, and also for the player to triage and manage strategy with the rogue procedurally generating engine. So they will need to get a feel for the drop and spawn rate of objects.

There is anice sound effect for the menu we could use in the below sound effect pack.

* lots of high quality weapon effects, we definitely want to use this: https://assetstore.unity.com/packages/vfx/particles/sci-fi-vfx-91983

* search asset store for "laser sound effects", "laser sounds"

* here is a volumetric laser we could do something with: https://assetstore.unity.com/packages/tools/particles-effects/volumetric-laser-beam-40969

* also search for "laser weapon(s)", "laser beams": https://assetstore.unity.com/packages/tools/particles-effects/laser-beams-weapon-systems-pack-18138

* this has an AMAZING laser beam weapon we can use, and the cool idea of using rotating mines: https://assetstore.unity.com/packages/vfx/particles/space-weapons-vfx-152817

* mines could also be deployed by enemies


* amazing free pack of SF sound effects: https://assetstore.unity.com/packages/audio/sound-fx/weapons/sci-fi-weapon-sfx-by-great-heights-audio-147911


* some very high quality shader particle effects / weapons: https://assetstore.unity.com/packages/vfx/particles/sci-fi-vfx-91983

* these SF sound effects for weapons are not bad: https://assetstore.unity.com/packages/audio/sound-fx/weapons/sci-fi-weapon-sound-effects-pack-1-106514

* search more for "sci fi" sounds, and also "sci fi weapons" sounds

* a very nice asset pack with a space base we can use in the terraforming game, even though we might use Unreal and port the art over: https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913

* even simple building and cultivation of life in deep space, (mining planet for resources with large overhead machines, etc), could be very nice to start off the VR terraforming game

* just experiencing stuff like this in VR would be awe inspiring: https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-heavy-station-kit-hangars-augmented-147104

* this asset is very nice at procedurally generating tons of space environments: https://assetstore.unity.com/packages/tools/level-design/space-for-unity-space-scene-construction-kit-7095

* a few things to take away from the above asset, we can use space rings like saturn in the near distance to show off the VR effect in one of the levels, also space fog

* SF sound effects, should be easy to find tons of stuff: https://assetstore.unity.com/packages/audio/sound-fx/sci-fi-sound-effects-pack-4-106530

* hologram particles: https://assetstore.unity.com/packages/tools/particles-effects/hologram-particles-45196

* search the asset store for "hologram"

* hologram pyramid: https://assetstore.unity.com/packages/tools/hologram-pyramid-61735

* another nice hologram

* this hologram is very nice, we could use this for mapping the entire territory or something: https://assetstore.unity.com/packages/vfx/shaders/hologram-shader-25876

* we could also use that for hologram for the ship in scan mode or something

* another nice hologram: https://assetstore.unity.com/packages/vfx/shaders/sci-fi-hologram-shader-77666

* we have nice power ups to try out for free: https://assetstore.unity.com/packages/vfx/particles/powerup-particles-16458

* these will be revealed when some asteroids and or ships are destroyed

* an easy power up to do is triple lasers, perhaps this power up is time based like in Mario, so we don't just give you something forever, which would lower the perceived value of the gift

* there are some nice particle effects that we can try out, go through these and jot down what is useable for each

* the ship model is really nice looking, and we can replace our current ship with that model

* from the same asset creator, there is a nice ship pack we can use to start out with for the enemies

* we will definitely need different skyboxes for each level

* we need lots of progression, and a sense of wonder to make the game fun

* create the intro story mode with a skip button for fast gameplay

* we need a nice overlay GUI, which tells us our score, and how much ammo we have

* here is a nice power ups set: https://assetstore.unity.com/packages/vfx/particles/power-up-fx-152740 and https://assetstore.unity.com/packages/3d/props/sci-fi-powerup-item-crate-18990 and https://assetstore.unity.com/packages/vfx/particles/spells/loot-drop-fx-147479

* we just need to keep iterating on the powerups to make them look badass

* although we are not directly going for retro, we could have all sorts of updated sounds, when things rev up, exponential stuff like the logic trick, where you can add the exponential decay to create some cool sounds, the effects are important, spend a lot of time on the sound effects, even if we have to create them ourselves

* these are some very cool radar shaders we can use: https://assetstore.unity.com/packages/vfx/shaders/silhouette-radar-shaders-97229

* definitely use the radar shaders, adds a lot of oomph to the game, use for: when an enemy takes damage they flash like this, perhaps when our shields, or the inner core of the ship takes damage we flash this, we can use different color for variety and situations, even some heavier asteroids might flash this color if we are trying to penetrate to the goodies, this effect definitely looks amazing in VR so use this

* we need lots of audiovisual candy like the above shader, this is paramount for a game like this, use all the sugar tricks they say to use, so make the lasers bigger, more powerful, delay the enemy slightly if they take damage, fine tune and polish in order of priorites

* we could even move the player to a different angle or spot of the galaxy that we are fighting for some more adrenalin rushing moments, although we need to keep constant velocity without acceleration (or teleportation), and ask the player before we do this, not sure if we will even use this

* so go through this list and organize tasks in order of importance

* universal sound effects library: https://assetstore.unity.com/packages/audio/sound-fx/universal-sound-fx-17256

* have the game oozing with sound, keep feeding the player with new stimulus so they don't get bored

* here is a very nice shield effect, which even shows taking damage: https://assetstore.unity.com/packages/vfx/shaders/energy-shield-effect-with-transition-and-hit-response-100109

* here are lots of visual effects: https://assetstore.unity.com/packages/vfx/particles/ultimate-vfx-26701

* go for things that make the most impact, these will be: 
  * intro
  * SF menu
  * powerups
  * shields
  * progression / variety (weapons, skyboxes, enemies, asteroids, worlds, powerups, anything, list out how we can use progression for all of the noteworthy stuff)
  
  * nice forcefield: https://assetstore.unity.com/packages/vfx/particles/spells/forcefield-effects-123431
  
  * some cool things we could do with the hexagons: https://assetstore.unity.com/packages/vfx/particles/spells/living-particles-105817
  
  * this would feel like "Geometry Walls" where with progression difficulty we want to overwhelm the players sense, but we also want to have holographic light effects right from the start to ground them
  
  * light effects are especially good for trailers
  
  * nice warehouse environment for future games: https://assetstore.unity.com/packages/3d/environments/industrial/warehouse-environment-110654
  
 <br>
 
 So we will want to have enemy formations, like in classic space shooter games, this will be cool because we can line up formations, we might need to rewrite or amend the code from the ground up so the forces don't collider with asteroids, or maybe they also take damage from asteroids, or their shields take damage, that would be an easy solution instead of having to write AI to dodge asteroids.
 
 We will want to create variety, and overwhelm the player with progression right away, so they do not get bored easily!!!

Again the goal is to make a game that is like the Big Mac meal of games. So something quick, very easily accessible by people of all ages and creeds, something that shows off VR immediately. We would also like a short type of arcade gameplay, which people can use to introduce their friends to VR, because they don't want to just sit by ackwardly while their friends are in VR. So if they get a quick mega rush taste of VR, that will be enough to get them excited, and this will be a good proper party game people can use for a quick VR session. VR also wears on the user, so quick sessions are not a bad thing.

The other big thing is that we want to use Rogue elements for fun and replayability:
 * randomly spawned terrain (asteroids and etc) and enemiews
 * random items, sometimes you might get the item that saves you and sometimes you might not
 * permadeath, have to start over, helps with increasing playability of a small game, so players don't just easily beat and experience everything on the first try
 
 We could also use the roguelike genre description as a selling point of a game.
 
 "Space Game" is an homage to the space shooter genre along with roguelike elements. This game is perfect as a "party" game where you would like to show off your VR system to a friend.
 

This almost a futuristic game reimagined from the 80s on modern technology.
 
 
 * define the game's architecture as an early TODO
 
Interesting things:

1. physics propulsion system: https://assetstore.unity.com/packages/tools/physics/b-propulsion-system-96220
2. physics lab: https://assetstore.unity.com/packages/tools/physics/forces-physics-lab-135734
3. simple physics toolkit: https://assetstore.unity.com/packages/tools/physics/simple-physics-toolkit-magnet-water-wind-vr-ready-53912
4. flight simulator: https://assetstore.unity.com/packages/tools/physics/silantro-flight-simulator-toolkit-128025


* very nice cube city we could use to make a Fez type game in VR. Very simple building:
https://assetstore.unity.com/packages/3d/environments/kubikos-3d-cube-city-147691


* another very nice city asset pack: https://assetstore.unity.com/packages/3d/environments/urban/backstreet-cube-pack-137610

* could totally make a mini game with these, the streets would have to be built one by one, and with simple sims perhaps

* and yet another great simple town asset, and free, which is begining to give a sense of aesthetic, of what a "small" city building game could be like, along with worker placement: https://assetstore.unity.com/packages/3d/environments/urban/cartown-136585

* kind of like if we took Kingdoms and Castles, and made that in a modern city building environment, along with VR, and players being able to play both versions

* along with that is "Simple Sky": https://assetstore.unity.com/packages/3d/simple-sky-cartoon-assets-42373

* simple assets like Kingdoms and Castles are great, because we can still make a game, which doesn't seem small, and yet have the ability to easily create more of these low poly primitive assets

* great asset for prototyping: https://assetstore.unity.com/packages/3d/props/primitive-150-108758

# 10 / 5 / 2019

* begin on order of tasks in the design document

* get to MVP ASAP

# 10 / 4 / 2019

* creating the design document

* trying to keep the design document more lean this time, since this is a different type of game, and this method of working is easier

