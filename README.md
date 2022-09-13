# MauiStory

Progress is normally streamed at Twitch.TV/LahkLeKey

# Current plans

Experimental Genetic Isometric MMORPG Game + Engine Toolkit. Written ontop of .NET MAUI Blazor Hybrid. 
Heavily utilizing cutting edge AI and Quantum mechanic theories. 

Demo Game Storyboard

You are a Ka-Lua. A second born. Your kind is believed the be the seed of chaos. Depending who you ask they are a blessing or a curse.

Ka-Lua are a phenomenom to prevent strange order from going to the absolute zero state. Which causes a "Big Bang" effect.

## Acronyms

### CITS
Client is The Server
> Each client is also a horizontal scaling database replication node. More on this later.

### Pii 

Player Is Irrelevant. 
> You participate in an active world. You are not special here. In fact you are the minority.

### WFC 

  Wave Function Collapse. Average Person / Designer friendly way to generate random tilemaps. 
> https://github.com/mxgmn/WaveFunctionCollapse

### SD

  Stable Diffusion
> Text to image via AI.

### SS

  Sentient Set
> A modified neural network that represents a "living" organism.

### NEAT

  Neuroevolution of augmenting topologies (TBD)
> https://en.wikipedia.org/wiki/Neuroevolution_of_augmenting_topologies


## FAQ

Q: Player count
> The point of this is to be somewhat of a "simulation" and to allow average players to easily create or generate content that interestes them. The majority of the system is stabilized by player-like "NPCS". A group of 1-5 players will be ideal for most people. I am hoping to smoothly support up to 264 players per "node / node group" to allow this to scale "infinitely in the horizontal direction"

Q: Economy Stability?
> Pii 
e.g.) Player farms 100 materials then is provided with 3 options.

   >Consume Material for temporary gain. (Food, Potions, etc...)
   
   >Use Material for crafting. (Equipment, Also Food, Potions, etc...) [Cooked Meat vs Raw Meat]
   
   >(secret sauce) Player can sell material to an npc. The catch is the npc only has these EXACT same options. (And can sell to other npcs). 
  
  Not a single economy item will be "generated". (the source entity is the only "generation" part of this aspect but thats a different rabbit hole)
  e.g.) Blacksmith npc that normally just takes some gold and spits out an item from thin air)
>Depending how this is set up you could cause entire populations to die out due to a player overfarming resources and causing a drought in the area. NPC's will also harvest the same resources when needed. For all intents and purposes they are bots not npcs. They cant do anything a player cant.

Q: Anticheat?
>Layers of standard deviation on various game elements should be enough in theory. I have found that many anti-cheats shoot themselves in the foot with an over engineered solution. If the vast majority of your playerbase does not cheat you can use this data to identify outliers. You can just gracefully reject those with the only caviate being that anyone lucky enough beyond the threshold of consideration will have the node rolled back in time and lose a bit of progression (without a disconnect). On the flip side If the vast majority of your playerbase is cheaters... are they really cheating?

e.g.) Player has been on for 72h straight. Is it a rmt bot? a player? or a player who sometimes bots? who gives a shit its an anti cheat not an anticheatrmtblockplayervalidator just blacklist them from connecting for a bit. problem solved o.o


>There will be a service called RNG Gods that will need to remain proprietary in order to get this working a bit faster. If I can stabilize it then secure it ill open source it. The private service will do 2 things. 1 audit nodes for suspicious activity. 2 gracefully inform the node that they are under investigation when they are approaching the danger zone. This will communicate to the player that they are in the grey zone and they should stop. 

Q: DLC/Expansions?
>Free

Q: Mods?
>Heavily moddable. To the point where you could make your own embedded game from it if you really wanted. The toolkit will be more like a very high level game engine with 99% of what is needed to do basic actions abstracted away from the designer.

Q: Timegating?
>Id rather eat a fork

Q: Dailies?
>I hope its fun enough to play everday.

Q: Funding?
> Patreon for people who want to tip

Q: Hosting?
> Bulk of the work happens on the client via CITS. As population grows auditing nodes will be added.

Q: Cost?
> Its open source my dude. Its free

Q: Microtransactions?
> No

A: Its open source. Can I contribute?
> Sure after the MVP is ready I can start making abstraction layers for other people to use.

# WHY?
> Its a prototype for a game I have been planning over half my life. Even if it flops its still a learning experience.
