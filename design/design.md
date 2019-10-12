# Let's also have a method for loading let's say 10 planets, or a number of planets, we choose with custom location for aesthetic and testing, though this in not necessary for MVP

Well, actually we could just do this with LoadStarSystem(dictionary of positions)

And just load up our custom dictionary of positions

# What about after generating a star system?

If we can assume that everything GenerateNewStarSystem() does suits our need for creating a singular star system, (with basically the data for the planets to speed up *development), then we can move on to the system that actually chooses the randomized origin positions which are is going to be which is fed to GenerateNewStarSystem(Vector3 origin)

(*We should be concerned with the data for now. Because everything will be doable. So these methods in the first iteration should be pure data methods, where all we want is the positions in Vector3 locations, and also the data behind what sort of vegetation and fauna we will be distributing.

And plus doing everything with just data for now will allow us to finish the design faster, and end up with a more elegant and robust design later.)






# So we are starting on the code here


        // make new star system

        void GenerateNewStarSystem(Vector3 origin)
        {
        }

And using the helper method:

        void FindRandomNumberBetweenMinAndMax(int min, int max)
        {
            int randomNumber;
            return randomNumber;
        }



# Code so far for procedural generation
        


    class ProceduralGeneration()
    {

        // we are just procedurally generating planets in 1 star system for now
        
        
        const int MAX_NUMBER_OF_PLANETS_IN_A_STAR_SYSTEM = 100;
        
        
        
      
        
        
        // make new star system

        void GenerateNewStarSystem(Vector3 origin)
        {
        }

        
        
        // load star system, after we saved them with GenerateNewStarSystem()

        void LoadStarSystem(Vector3 origin)
        {
        }
        
        
        
        void RandomizePlanetPositions()
        {
        }
        
        
        
        
        
        // helper methods:
        
        
        
        void FindRandomNumberBetweenMinAndMax(int min, int max)
        {
            int randomNumber;
            return randomNumber;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // The start method will be for one experiment at a time, since the main method of this will probably be called by a button or some level start up routine
        
        
        // this time we are experimenting with getting one star system to generate
        
        
        void Start()
        {
            Vector3 origin = Vector3.zero; // later we will pass all sorts of origin points for a big galaxy
            GenerateStarSystem();        
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
 
 



# Trees

By the way we will need some trees, even if alien looking, like in that one screenshot from No Man's Sky, (in design folder)

# How to go about this?

    void RandomizePlanetPositions()
    {
    }

So we want to randomize a number for each planets between i and i2 = i + 9 (10), where i is the starting number of planets, and i2 is the end of the range

If we want to have more distance between planets we would increase the value of i2 by a multiplier


At the end of the generation perhaps simply we could have some after the fact multiplier that would just increase the scale of all the distances, so the mdoel of the planet would determine how far away we are really... 

Well, let's keep things absolutely simple for now just so we can get this thing going.

So we are going to a random number multiplier helper function, which takes in a min, and max, and finds a random number

    void FindRandomNumberBetweenMinAndMax(int min, int max)
    {
        int randomNumber;

        return randomNumber;
    }
        
        
# Randomizing planet positions

Randomizing planet positions can be very simple.

All we need is the origin (Vector3)

Then we need some sort of buffer randomized threshold hold, that is the distance vector

We could check with the distance vector between points, and then throw away those randomly generated results which are outside of the bounds, and generate more

Another easy way would be to brute force hard code this:


1 - 10: Generate a number in the middle
10 - 20: Generate a number in the middle
20 - 40: Generate a number in the middle and so on,

all way the up to our max number, which we will need to define as a constant.


MAX_NUMBER_OF_PLANETS_IN_A_STAR_SYSTEM = 100


so then we multiply the MAX_NUMBER_OF_PLANETS_IN_A_STAR_SYSTEM by 10, so each one will be randomized within 1 of 10, of these coordinates.


So, in code:


    class ProceduralGeneration()
    {

        // we are just procedurally generating planets in 1 star system for now
        
        
        int MAX_NUMBER_OF_PLANETS_IN_A_STAR_SYSTEM = 100;
        
        
        // make new star system

        void GenerateNewStarSystem(Vector3 origin)
        {
        }

        // load star system, after we saved them with GenerateNewStarSystem()

        void LoadStarSystem(Vector3 origin)
        {
        }
        
        
        void RandomizePlanetPositions()
        {
        }
        
        
        
        
        
        






    }


# Some sense of a plan now - Generating Star Systems, and Loading Star Systems

// make new star system

void GenerateNewStarSystem(Vector3 origin)

// load star system, after we saved them with GenerateNewStarSystem()

void LoadStarSystem(Vector3 origin)


# Procedurally Generating Star Systems

Procedurally generating star systems might be the easiest thing to start with, because we will always need a reference point that becomes the star, the relative origin point, and then we simply generate planets around this star origin point with +, 0 on the 3D x,y,z coordinate system, just making sure we are within some sort of safe buffer threshold distance, so the planets don't overlap each other. Later we can add moons also.


void GenerateStarSystem(Vector3 originPoint)
{
    // each random generate function will + or - from this origin point for each of the planets
    // so we will need a randomize position, that also check if we have not already put a planet within some distance to that.

}


# Designing the Procedural System

So how can we begin to design the procedural system starting with the most simple way and elements?

Well, first we are going to need unique IDs for the planets, and also unique IDs for the starsystem, and then maybe unique IDs for the quadrants.

So quadrants are like voxel cubes in a voxel game, they stretch out to potentially infinity, so that will have some sort of number, which can cover x, y, and z. So maybe a dictionary which has one integer type to a Vector3.


Quadrants<int, Vector3> // Dictionary for quadrants. The int 0, will start in an arbitrary place of our choosing. probably at 0, 0, 0 of our entire universal cube, well this cube will go on forever, so we might need an abitrary naming conventions.

What if choose 0, 0, 0 to be at the center of our universe, and also at center of the engine 0, 0, 0

From this point we want to draw our data, and not just place everything in this universe, and teleport the player, although we could do that.

Well pretend we take the easiest route possible and just the origina 0, 0, 0 so as both the center of our universe and also the engine. Then the player will always start at 0, 0, 0, which to them will be an arbitrary starting point anyway, since the planet and star system will always look different.

So then... even if the universe is infinite, then the player will still need finite time to transverse this universe, and here is perhaps where we can... well, nevermind, scratch this idea.

We should probably do the redrawing the quadrants thing off some sort data structure, where the infinity takes place, and not the x, y, z coordinate system in the engine.

... still needs work

We can just say procedurally generated universe, we don't have to say infinite although this might be the case.

As for the planets, in each star system the planet will be at 0, 0, 0, or per 9 quadrants, the first start will be in 0, 0, 0 and the the rest will be set apart by some distance, which make sense. Let's just 100 for now, because we can simply just multiply or divide that to get the scale right.

What would be the upmost simplest way of doing this?

Quill has a good video: 

part 1: https://www.youtube.com/watch?v=0vPVu8wLJ3o
part 2: https://www.youtube.com/watch?v=0vPVu8wLJ3o


Let's say for now we just generate 100 star systems.

int numberOfStarSystemsToGenerate = 100; // this is essentialy a non number, because procedurally we will just be generating around the player.

So what if we start there... ? Generate a quadrant of these 10 boxes.

Have a method which determine which quadrant the player is at any time. Perhaps we could even teleport the player back to 0, when they in the deep space, and then fade with some sort of faster than light travel thing.

For now let's just keep things very simple.

So Star System 1:

int ID = 1
Vector3 posStar = new Vector3(0.0, 0.0, 0.0);

// the above is a given in procedural generation.

Then we will want to procedurally generate the planets around this.

So they will get a +, or - to the posStar.x, posStar.y, and posStar.z coordinates, since those will be in one of the quadrants.

Spend some time on this because want something really good.


well what if actually we generated the planets pretty close together.

And then when the player is in the darkspace boundary, right between the clipping points of two adjacent star systems, then we simply do that traveling faster than light speed star dust zooming by you, to give them illusion that distance they are transvering is much greater.

# Choose Color Themes by Looking at Pinterest and other PREMADE Sources

Don't just choose color themes on your own. Check out the DiscordColorTheme.png in the design folder.

We can use something like that to start.

Also check out the color themes from Hollow Knight. They have a lot of good themes. And also Ori and the Tree. So just takes a few colors and build color themes out of them with Adobo Color Wheel.

This will be huge, enjoying these worlds.

We also want to add all sorts of variety. So glowing crystals within some sort of weird plant crystal project structures. Etc. Once we get better at doing low poly art we can do this stuff.

Then like "real" artists look at all sorts of sources of inspiration vintage SF book covers, games, anything.

Each world can have their own color theming so we go with plenty of different color themes.

The player is then free of course to build their base on anyworld. We need some easy way to designate this in code, so we just need the planet's ID.

# Comparing No Man's Sky with Procedural Art Scene for Scene

Comparing the two scenes in the design folder, LowMansSky.png, and LowPolyMountainTutorial.cs (same search keywords in Google), our mountains looks even better in terms of definition. What they have is the desnity of color, and different colors. So somehow the mountain has three 3 different colors. If we can do this in low poly with some sort of color theming we would be in really good shape.



# On Beginning Procedural Generation

We should first and foremost anything we generate can be within a cube of x, y, and z proportions. So whatever we generate we should be able to have the exact coordinates with this rectangle of our game universe.

But what if the universe is truly infinite we just keep going?

So we could this relatively, and wherever the player goes further procedurally generate this space.

We really want our own system to do this, instead of anyone else's online.


So pretend we generate a quandrat, which is a cube. In this cube let's say there are 10 solar systems. So that's all fine and well. Now if the player goes off to the next quadrant, we THEN generate that universe and save the data.

So if they want to just infinitely keep going, yet have a record of previous generation then we will need to at least save that numeric data, and then generate the 10 quadrants around them as they move around.

By the time they get to 1 quadrant, we will always have pregenerated that quadrant out of their visibility.

Like from the discord:




# On Competing with No Man's Sky

Check out the diagram NoMansSky. We don't need to have ultrarealistic models, if we can artistically make them from low poly.

We could do a similar rolling hills landscape, with the mountains strategically placed in shapes of waves on the plateau. Try to squint your eyes (The major less of art school), and think primarly in terms of those shapes, and then place the trees along as an afterthought.

Plus there is only so much you can do with the realistic style. There is definitely room for low poly styles.

Here is are a really good low poly mountain editing tutorial in Blender: https://www.youtube.com/watch?v=HNsgd8GwEBE

Plus we can have even more wackier outlandish futurustic will wonka topsy turvy colors. That is actual something we can do, which none of these other sci games do. And that would feel like a relaxing trip in VR. Kind of like an art painting.

So to summarize use your weaknesses to your advantage like in Kung Fu.



# On Competition

Seems like all of the deep space mining competition is more or less the same game, (except the voxel builders), we can compete by not trying to have realistic models, which take forever to optimize and instead create more of a Mario-y, Nintendo-y, game play. Where we have BS, nothing preventing a player just jumping in and having fun with the universe.

What is paramount are skyboxes. If skyboxes look great, that's half of the battle, so that is not easy to do.

I believe there is room for any of these SF games, and they all garnered enough reviews to make each of the creator's wealthy.

So we don't want to compete with that, here is how our game is fundamentally different from the majority of the marketplace:

1. VR
2. Doesn't aim to be realistic, uses low poly "fun" graphics
3. There is lots of game juice like in a Vlambeer game, or a Nintendo game, everything is layered, and the game just feels good like Celeste, this is the Celeste of space games, Celeste is just a 2D pixel game yet managed to get quite some notoriety
4. We are creating more of a "therapeutic" game, where people can zone out after a long day's work and just marvel at the universe kind of like in Space Engine
5. There will be shooting or combat in this game, making for just a pleasant pacifist experience where there is no violence, which is a welcome break for the player, and eliminates 99% of all these games
6. Our game will be heavily color coated like Celeste, which gives the game that look and feel of "professionalism"
7. We want a lot of sound effects which will give us that look of professionalism in the game
8. We want a loot crafting game more along the lines of Terraria, and Crea, where we are just happily gathering, unlocking weapons, and new abilities, spacecraft, bases, etc

These above things are enough to set the game apart in the marketplace.

All in all our game will feel more like a 90s game, where fun was number one, not just throwing together a bunch of realistic assets and having a walking simulator.



# Study the Gameplay of Each and Take the Best

https://www.youtube.com/watch?v=H_qjvR8bdwM&t=383s

# Plan from here on out 10 / 11 / 2019

So we have a pretty good core that we managed to scramble up in the last few days. 

Now here are the things we can do.

1) Give goals to make a "gamy" situations. Such as: 
    a) fly between planets and mine different resources to collect a combination of resources
2) Polish astronaut movement controls
3) Polish ship flight controls
4) procedurally generate the world



For the ship flight, we can start with the other asset as our base ground. That would probably be best.


So start a new scene and try out how the ship flight works there.

The Scynty art will go a long way of helping us if we can't model our own stuff, but if we did model our own stuff we would need:

1. Player ship
2. Astronaut
3. Cargo bay
4. Skyboxes, planet rock formations


So those are the basics up until know.

We should focus on:

1. Getting ship movement right
2. Getting player movement right
3. Getting the procedural generation right


If those three things are solid, we are in a good spot.

And also we would like to have autopilot for the ships flying capabilities.

Whatever flying capability we chose, whether that's the flight asset we will try here soon, we can always switch that out later for another asset or try coding our own, that should not affect the other two elemenents, of 2. getting the player movement right, and getting the procedural generation right.


As far as the procedural generation goes, we can start up with a base, and slowly iterate on that, minimizing putting ourself into a corner, by laying the foundation in a simple and modular way.

So if we can just focus on polishing these 3 things, then that can be a huge part of the coregameplay that will be worthy to release on Itch, and start generating some money. Itch will be a type of first early access.

We got a lot done just in the last 2 days. Imagine how much we could get done with 3 months...


The trick is to focus the work on the rolling MVP. So avoiding going down any time sinks, and just working on the essentials.

Because, assume that these three things are polished:

1) astronaut movement
2) player movement
3) procedural generation (will include 3D star map)

That means our universe engine is open to all sorts of play and experimentation.

So we can satisfyingly move through the whole universe.




Also, research any tips on procedurally generating planets to get some advice relating:

1) Scale of planets
2) How LOD works with zooming in on a planet, landing on a planet
3) How to disperse them through 3D space
4) How data probably comes first, and how to use data to gradually reveal the terrain as the player transverses a quadrant

We can use our old quadrant math from the Discord, where we have 9 boxes, and we redwraw the terrain or repopulate the terrain anytime we move in the list. So there is that procedural generation not just for planets.


So we will have two "infinite" terrain procedural generation.

1) Star Systems, which we will use the 9 quadrant method on
2) The actual surface of the planet, which we will also use the 9 quadrant method on


So then after we procedurally generate the universe and planets, the trick is on how to arrange the landscape so the player doesn't get bored.

For now just stick with alien like landscapes. We might not even do regular lush earth like planets in the pre Itch prototype. Much easier for us. Ensures we finish the game. And this goes along with the whole "Alien type planet" vibe of the world, which will cause the user to be much less likely to raise an eyebrow.


So assuming we can do some fine procedural generation, some fine character movement optimization, and some fine ship movement optimization, then that is a huge chunk of the game. 

So when the character exits the ship in space to float around, they can then proceed to build some sort of structure.

Perhaps we can simply this for them by just creating a block, and then letting them tack on to that block, and perhaps in the meantime combining the mesh for performance.

But of course we don't want just simply voxel like building, so we will give them plenty of other low poly objects which they can use. 

Perhaps they can even gather enough resources to build their own ship.

There will be two type of building simulations:

1. In space
2) On the surface of a planet


Now, going back to the significance how good the terrain has to look, if you look at games like No Man's Sky, and also Astroneer, they both had fabulous graphics on the terrain. We are probably leaning more toward the Astroneer type graphics, since they are more alien like.

Find more low poly plants, and also jot down the pricey asset packs, also search Googly Poly, and take some basic blades of grass and enlargen them, and make them purple, and strange colors to give us this alien vibe. But make terrain that really looks nice. Since this is key and what the players want to explore.

So perhaps we will need some hill generating functions to generate some terrain on the world. Perhaps there is a good tutorial we can use for this.

Even if we use a tutorial, make sure that the code written is our own, so that way we don't have to deal with someone else's messy code base.

So we really do want first class level terrain generation, since this will be huge. Perhaps we could have some even slime species type of elements which should some kind of unsuspecting toxic green slime, but perhaps not now for the Itch prototopye.

But something I noticed with the VR experience, people just want to be able to experience 3D surroundings that look cool around them. So going along with this we want to position the VR camera close to the astronaut on the ground, so we can look up and around on this alien world all around.

And then when the whole procedural generation is up to nar, we want to give the astronaut some basic mining tasks like in astroneer.

We want these tasks to be varied enough to fill out the other part of the game play.

We want to use these things that maximize the ratio of time to gameplay with easy wins.

One of these easy wins, is getting seeds from different plants in the universe, perhaps taking these with us on our interstellar voyage, and then growing them elsewhere on a different planet.

By the way, some planets will be blue themed, and very cold, but perhaps they will contain cool orange glowing crystals, or whatever the opposite color is on the color scheme.

Take the one deep ice blue color, that will be the set piece for the world, perhaps take this from the lego ice world color, and then generate all the color schemes, including analogous, and monochromatic, and then also the complimentary, and the others, since this is where we will find an opposite orange color on the spectrum, which could be used nicely to show the crytals.

So for now simply every world will have crystals, though different formations as these mining deposits.

So once we finish these 3:

1. Procedural world generation
2. Astronaut controls
3. Ship controls

We can focus on mining, building, and doing those activites in the world which can be helpful to expanding gameplay.

One of these big things would be erecting the tall solar panels, along with the joy of activating them in space, with deep hum power on sound effects.

These can then power our operation, perhaps we could even do a ring of scope, an area transparent bubble of where the power can reach instead of having to do lines. Or even a simple message that we have to be near the power source, or color code the building requirements meshes from purple to pink.

One thing is certain though, we have to work efficiently from here on out, so we are maximizing our time to only work on the rolling prototype, so when January comes along, we will at least have enough gameplay to put on Itch, and start earning some money while we could keep further polishing to get on Steam, although Janauary is a prime time to release on steam.

Bug again, if we have these incredibly lush landscapes like in No Man's Sky, and Astroneer, we can really compete.

So we need to study a lot of art, a lot of fantasy and science fiction art, especially of alien worlds, and do our best to figure out how the large basic flowing shapes of the the artists uses to create these spaces.

What was that one article, that had all those art rules of proportion?

Google search: proportion / variety in art

In that book, Design for Hackers, there is a section on all the different elements in art design, such as variety, flow, rhythm, reiterate these things again here. Especially with the 75% prototype rule.

So in the procedural generation algorithm we will want to do stuff like:

1. Generate different looking worlds, not just more of the same, so the player can truly explore what is out there, give them a lot of variety
2. Use the 75% to generate things in all sorts of ways, so the aesthetic is pleasing
3. Make a ton of different color schemes, since they are free, easy, and quick, and then have a look up table which uses these to begin generating stuff
4. Use cliffs, and rolling hills if possible, look up tutorials
5. Speed up the sun a little in game, so the player will see the sun come up from behind the horizon, and change the volumetric lighting, and make the whole scene very nice to apprehend

But a big main thing right now is how to generate planets and get them looking at scale while we are flying

One way perhaps would be to only allow a safe distance for the ship to come close to the the planet, while the planet is not that large, and then give them a button of option of land on the planet, or do a smooth transition of landing, and also watch how No Man's Sky, and Astroneer does these things.

Perhaps we can use fog as a transition into the planet surface.

Either eway the whole planet will be covered with stuff, but we will not make that visible, until the LOD reveals, so we will be holding all of that data in a map, and then as a player moves from quadrant to quadrant we will be procedurally generating stuff.




Check out that one space game where the guy is working independently, that might be in some "upcoming best sci fi / space games", an older video from 1 or 2 years ago




# VR Camera Solution

we divide up the whole area into quadrants when a player steps into a new crowdant, we fade in and out to give the viewer the best position, and then we also offer a few other modes they can choose from the camera settings buttons, each one locked, the first unlocked one will be take off from the planet which feels like real take off


# Planet Names

* perhaps use some real lexicon to generate the planet names even if they are accurate to locatiaon, and another thing we could is to have a very pretty moon, or a series of moons, even of different size, around the planets

# Autopilot

So to speed up the auto pilot you have to was some of your mineral resource, so that opens up the possibility space for a challenge


# Jet Pack Super Juicy Controls

We want super juicy controls like for Celesta, so there is no confusion, just easy of use, doing cool stuff, no obstructions, just flow


# Further Notes

* definitely provide autopilot, so we can just sit back and relax, for those that are technologically challenged, we will provide a smooth ride, and for more advanced users we will give them plenty of chances, to unlock stuff, and interract with the game, to reward for their curiosity, never let them down


* what would be really nice would be to pull up a 3D star map of the galaxy, fade in and out to this, so that we have some sense of orientation where we are in the nearby galaxy, this will also be determined by procedural generation


* procedural generation planning should take place on paper with reading astronomy, to get a sense for things like how many planets are there in star system on average, and what is the range, also what colors to pick for the minerals, but any color can be picked really by color scheme, and then we can arrange the minerals later to the best of the arrangmenet

* one of the things we can keep giving on freely in this type of game is a sense of scale, just a number to increase

* we want to eventually get to a very large cargo bay, so that we can see that in 3D

* the ship should wobble every now and then to give life to the thing, and also have some underside flashing nice patterns we can observe from below

* also have the sun come up, and spread rays all over the valley and the horizon, this will be huge

* on the game controller we could have a toggle that goes through all the selectable objects in the area, selecting each one of with an outline, this would work great to just press one button and go through all the possible selections, very fast and convenient, even on the desktop gameplay, and of course players can select with the mouse on desktop, and some other way perhaps of selecting, maybe where they are looking? well we don't want to do that, so not syet

* when we drop off the astronaut we want him to float in space with his jet pack for a smooth transition, and then the plkayer can use the jet pack functionality to send the player down to the surface


# Goals are very important for games, that's where the fun comes from 

# Custom Cosmetic Stuff

Later post MVP, we can upgrade the equipment and suit on the asternaut for the things we get to build and process, this will give the game progression, and goals


# On Symbolizing to the Player that our VR locked, no movement position is the best thing

by taking them on a few slow take off flights, where we have constant velocity, until perhaps we get far enough to the stars, where we can use sand dust to indicate speed, so they will get a feel for speed and immediately understand that sharp turns are not a good idea, perhaps we put them on one sharp turn only time for them just to get a sense, so they will appreciate the smooth motion

# solar panels

solar panels will help to add a lot to the terrain, especially if they are tall and large, and awe inspiring

# bigger ships, will also look amazing up front if we are floating the astronaut by there

# we can also make a space station floating in orbing, where we could open doors and come inside with the asternaut, although we probably wouldn't take off hsi  helm


# Further Notes

make the loot crystals a lot more appealing, procewdurally generated in some areas in large clumps, that you feel you were lucky


need to get movement right, sudden stops should be easier none of this sliding, unless with a jet pack in space


write the procedural generation simple but modular, so we can just add freely, like the rule of 75% aesthetics


having really small clumps of crystals helps ground the player in one place for much longer, which is harder for the player to know how much time to spend where, so here we can get them in a specific area with the crystals point of interest, and not just dispersed freely throughout



for the controls we need really smooth baby motion, and lock the rotation at all times the player in VR should be parallel with the floor of the game, though there might be options for them to get a director's chair, etc


this game is a therapeutic game, just like they were saying that traumatised victims were being treated with calm VR experiences, here we can have the same sort, a sauna of relaxtion, no shooting, just free space roaming, exploring, and hoarding crystals to build stuff



the height we are at is nice, for controlling the astronaut on activities below, but we don't to move the camera at this directorial chair point, just have the astronaut move, since VR is more comfortable when the camera is not moving
and if we are parallel with the ground


continue to focus on the rolling MVP, where we can provide an experience where no player is confused, and take them on a smooth ride of the capabilities of the game, that is the goal, then to make the controller feel smoother with more modes like in Celeste



then a begin thing will be learning how to do low poly art in blender, so we can design our own astronaut model


don't despair, this will only be one model, which we will use throughout the game

let's have an option to send the ship off as a drone to transport something, while we stay behind as the astronaut

would be cool because we could watch the ship take off in the horizon, and this also adds more interactivity to the gameplay






# Easy Way to get Advertising is Post Threads with short GIFs

# Everyone wants to talk about the cool games they made

So don't be afraid to advertise

# Gamers Love Game Programmers who are One Step Ahead

One step ahead with VR, and pioneering and innovative technologies

# Make Super Fast Games

Make the game complex, a construction set

# Make Super Fast Games

So even though this is in space, let's have lots of speed available for the players, whether this is in the rover, flying, or processing resources


# Raise the Bar

* for gamers to think the company and game is amazing


# The Occurrence of the Word "Time" in Celeste

There are 400 occurrences of the word "time" in the Player code of Celeste.

# Study Celeste Playthroughs for this "Super Juicy Movement"

* how does Celeste accomplish this?

* how do the characters break? should we use a jet pack to break in a much more precise way, and let's lerp into this with the right amount of testable force

# Celeste Review

"Did not spend one hour and yet felt the super juicy movement." - Reviewer

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



