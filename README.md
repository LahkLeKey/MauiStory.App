# MauiStory

# Current plans

Pii* 2d platformer rpg (Maplestory, DFO, Elsword, etc...)

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

## FAQ

Q: Why is your workflow so chaotic?

> Thats how you get shit done fast. 
The only result that matters is the end. I frequently scrap work when testing different angles of approach to a problem. 
In the end its going to all be abstracted away anyways. This codebase is going to have very few raw assets (hopefully)

Q: Its an MMO, normally made by a team that is probably large. WTF can you do?

> Brooks's law is very... very real. I have no red tape, I want change? I make change. There are situations in AAA companies where a developer finishes his work in 15 minutes. Then does nothing for 4 days because thier manager is a dickhead so they stopped caring. As proof of this at one point in my career I was referred to as "The Department" and did the work of a ~12mil/year companies Development, R&D, IT by myself. (fuck that job it paid me 25$/hr lol)

This is why people get frusterated when it takes companies so long to do a simple fix that a modder can do.

Q: bUtItZLikAmerrionLinesOCod3

> I bet I can (hi future me dont kill me) do it under 80k lines and probably like 50mb of source code. DotNet abstraction can do some pretty nutty things. The difference between a 1x and a 10x developer is not that the 10x developer is 10x better / faster. They just solve problems in a way that causes 10x less work. I have seen codebases over a million lines that I could rewrite in a weekend. People will willingly use a bad workflow as a case of sunken cost fallacy. If you show them they can do the exact same thing in 3 days with like 1/50th of the lines of code many people will be personally offended thinking they wasted  20 years.

Q: What about low player count? MMOs are is boring when dead.
> This is where Pii comes in. Bots(AI).... Lots and lots of Bots... And they are probably more interesting then you! :D

Q: Economy Stability?
> Pii 
e.g.) Player farms 100 materials then is provided with 3 options.

   >Consume Material for temporary gain. (Food, Potions, etc...)
   
   >Use Material for crafting. (Equipment, Also Food, Potions, etc...) [Cooked Meat vs Raw Meat]
   
   >(secret sauce) Player can sell material to an npc. The catch is the npc only has these EXACT same options. (And can sell to other npcs). 
  
  Not a single economy item will be "generated". (the source entity is the only "generation" part of this aspect but thats a different rabbit hole)
  e.g.) Blacksmith npc that normally just takes some gold and spits out an item from thin air)
>Depending how this is set up you could cause entire populations to die out due to a player overfarming resources and causing a drought in the area.

Q: Anticheat?
>Standard deviation should be enough in theory. I have found that many anti-cheats shoot themselves in the foot with an over engineered solution. If the vast majority of your playerbase does not cheat you can use this data to identify outliers. You can just gracefully reject those with the only caviate being that anyone lucky enough beyond the threshold of consideration will have the node rolled back in time and lose a bit of progression (without a disconnect).
On the flip side If the vast majority of your playerbase is cheaters... are they really cheating?

>There will be a service called RNG Gods that will need to remain proprietary in order to get this working a bit faster. If I can stabilize it then secure it ill open source it. The private service will do 2 things. 1 audit nodes for suspicious activity. 2 gracefully inform the node that they are under investigation when they are approaching the danger zone. This will communicate to the player that they are in the grey zone and they should stop. 

Q: Mods?
>Heavily moddable. To the point where you could make your own embedded game from it if you really wanted. The toolkit will be more like a very high level game engine with 99% of what is needed to do basic actions abstracted away from the designer.

Q: Funding?
> Eh this one doesnt need any and its probably better if it has none. Getting funding means giving up creative control to another entity. Ill probably just do a 1$ patreon for people who want to tip and leave it at that. If 5000 people subscribe to patreon at 1$ that is more then enough to justify doing it full time. Right now it is capped at 7 slots per month until I have an MVP ready. Don't want to change my mind and piss people off. If its "not profitable" I dont care. If you wont play it I will. WeLovEFoRTniTE 👍👍🏻👍🏼👍🏽👍🏾👍🏿👎👎🏻👎🏼👎🏽👎🏾👎🏿👊👊🏻👊🏼👊🏽👊🏾👊🏿✊✊🏻✊🏼✊🏽✊🏾✊🏿🤛🤛🏻🤛🏼🤛🏽🤛🏾🤛🏿🤜🤜🏻🤜🏼🤜🏽🤜🏾🤜🏿🤞🤞🏻🤞🏼🤞🏽🤞🏾🤞🏿✌️✌🏻✌🏼✌🏽✌🏾✌🏿🤟🤟🏻🤟🏼🤟🏽🤟🏾🤟🏿🤘🤘🏻🤘🏼🤘🏽🤘🏾🤘🏿👌👌🏻👌🏼👌🏽👌🏾👌🏿👈👈🏻👈🏼👈🏽👈🏾👈🏿👉👉🏻👉🏼👉🏽👉🏾👉🏿👆👆🏻👆🏼👆🏽👆🏾👆🏿👇👇🏻👇🏼👇🏽👇🏾👇🏿☝️☝🏻☝🏼☝🏽☝🏾☝🏿✋✋🏻✋🏼✋🏽✋🏾✋🏿🤚🤚🏻🤚🏼🤚🏽🤚🏾🤚🏿🖐🖐🏻🖐🏼🖐🏽🖐🏾🖐🏿🖖🖖🏻🖖🏼🖖🏽🖖🏾🖖🏿👋👋🏻👋🏼👋🏽👋🏾👋🏿🤙🤙🏻🤙🏼🤙🏽🤙🏾🤙🏿💪💪🏻💪🏼💪🏽💪🏾💪🏿🖕🖕🏻🖕🏼🖕🏽🖕🏾🖕🏿

Q: Hosting?
> It will be so cheap to host this that its not even worth consideration. I will need to have some kind of blockchain type of verification going on and to scatter those nodes on random 1$ vps instances from the various providers. AWS, Azure, Vultr, Any of the little guys too. The bulk of the work happens on the replication nodes embedded into the player client.

Q: Cost?
> Its open source my dude. Its free

Q: Microtransactions?
> Fuck all that noise

I bet I could host 1 million players on a 10$/month budget.


A: Its open source. Can I contribute?
> Sure after the MVP is ready I can start making abstraction layers for other people to use.

# WHY?
> Its a prototype for a game I have been planning over half my life. Even if it flops its still a learning experience.

# P.G...
for now the git history is going to make absolutely no sense. still doing experiments. and ill probably end up squashing the entire commit history... multiple times... into master/main(i just use CI)... with --force...
> or just resetting the entire repo when I have the MVP done


trying to do the MVP without using any search generic search engine that does not point to microsofts official docs. 

I find this helps with new unique (often stupid) solutions.
> Anyone want a tire? Its triangle and made from glass! ... Anyone...? ...no?...

I generally just decompile the third party package and yoink the stuff I want, yay resharper, .net IL Layer and Ctrl + Space Intellisense 
> DotNet is stupid easy to reverse. you can even get old comments back without symbols / pdb | https://github.com/icsharpcode/ILSpy

still undecided if its going to be a maui package or if im going to fork maui and refactor the entire thing. 

> Hopefully it will be a smooth to transition between the two regardless
