READ ME
Version 2.0

Hello! Welcome to DJ Brohawk's GT7 randomizer app, Version 2! (Version 1 was unceremoniously dumped during an internet outage - F's in the chat for version 1). Firstly, since this readme is quite long (TL;DR section included), if there are any comments, questions, or concerns, I can be found on Twitter @DJBrohawk! :)

This app is still very much in progress, so if you stumble upon it on GitHub, avert your eyes! Just kidding.

---TABLE OF CONTENTS---(toc)

1) About (toc)
2) Generating a Random Track (trk)
3) Config Forms (cfg)
4) Generating a Random Car For Your Whole Race (gen)
5) Adding New Cars/Tracks/ETC (new)
6) Deleting Drivers From The List (del)
7) Other Thoughts (oth)
8) TL;DR (tldr)
9) Future Improvement Ideas (fut)

With this app, you'll be able to do a number of things:

1) Pick a random GT3 car, GT4 car, OR a random car out of *every car in the game*, with the ability to limit the pool of cars the app can choose from

2) Pick a random track, complete with a multitude of bonus randomization options, also with the ability to limit the pool of tracks

3) Generate a random car for everyone in your race!

I have it currently set to where the most recent 5 cars and tracks chosen will not be repeated. I did not apply this restriction to the categories.

In the future, I might add a checkbox or variable to change this! :)

---GENERATING A RANDOM TRACK---(trk)

This covers all of the options as it relates to generating a random track. If you'd just like to generate only a random track with no options selected, hit the "Generate Random Track" button and a random track with no other options will be generated.

To generate a random track with extra options, fill out the settings and checkboxes on the right hand side to modify the random generation to your liking, and then click the "Generate Random Track" button. If the checkboxes on the right are not checked, those settings will not be taken into account in the random generation.

Below are explanations of all the options you can use in the main module:

1) Time Multiplier - Between 0 and 30, this randomizes the amount of the time multiplier you'd set for time passing in the game

2) Start Type - Either "Rolling Start" or "Grid", if the rolling start is chosen, a random distance is chosen from the game's allowed distances, 50-164 feet

3) Category - Chooses a random category from either the entire list, or the selected list chosen from the Category config form

4) BoP - Randomizes whether BoP is on or off

5) Race Type - Randomizes whether it will be a standard lap race or an endurance race

6) Weather - Randomizes which of the starting weather options you choose. This doesn't take into account the custom weather feature that lets you pick weather for various parts of the race. Too much of a headache, sorry

7) Fuel/Tire Wear - Randomizes the fuel and tire wear together. If you don't want one or the other randomized, set the "Max # of" counter for that particular one to 0. Note that it is possible for fuel and tire wear to randomly be set to "Off" in addition to a random value within the bounds of what you set.

8) Laps/Mins - Randomizes the amount of laps/minutes from 1 to the number on the "Max # of Laps/Mins" value counter, default is 10.

9) Force Rain - This forces the randomizer to choose one of the rain weather options if the track has rain available on it. If no rain is available, it just chooses one of the other weather options. I coupled this with the "Rain Only" button in the track config so that you could force a random rain race through the track config list if you wanted.

10) Force Night - This forces the randomizer to choose the latest available time on a track if that is "Night" or "Midnight". If the track doesn't have either of those, it will just pick a random time. I coupled this with the track config button "Night Only" so you could essentially guarantee a night race in your track config list as opposed to forcing the randomizer to work harder to find a track with night in it. Best I could do, sorry ;(

11) Start Time - Randomizes the start time from the available choices on a track. This will not pick something that a track does not offer (unless my code is broken, then who knows what could happen!)

12) Tire Type - Randomizes the tire type, from Comfort Hard to Racing Softs to Heavy Wets

---CONFIG FORMS--- (cfg)

You'll notice there are buttons for various configs: Track, Gr3, Gr4, Category, and Custom - that allows you to edit the list pertaining to the random choices of tracks, cars, categories, whatever module you're in.

There are a number of buttons on the bottom of each module for mass selection or deselection of items. The buttons should be self explanatory by the text on them.

Currently, I don't have a way of filtering or sorting the items. That may come in a future update, or it may not. When I did some preliminary searching, it looked pretty annoying/difficult with WinForms, so it may not come to fruition, sorry!

You shouldn't be able to save any list with nothing checked, it should yell at you and prevent you from continuing. I'm sure the more creative among you might find a way around it, but try not to do that! :P

Each time you reload the config form, the list will be "remembered" by the app. If you close out the app entirely, the list won't be remembered and you'll have to redo it the next time you launch it.

---GENERATING A RANDOM CAR FOR YOUR WHOLE RACE---(gen)

To generate a random car for everyone in your race, you'll have to add drivers individually using the "Add Driver" button, or pressing the Enter key in the driver name field. Once you've added everyone in your race, click one of the Generate Race buttons to assign a random car to everyone in the list.

You can generate as many rolls of the random cars as you want, but you have to do it for everyone at the same time. If you, or someone else, wants a different car, either re-roll the race and give them the one chosen for them, or pick an individual car using the individual car randomizer. It pulls from the same config list as the race generator!

Note that some car names may be too long to fit in the window. I didn't want to make the main screen any larger so as to accommodate smaller laptop screens. The tops of the columns are draggable, so if you get a car name that is long and you can't quite tell what it is, click and drag the outside of the column to expand it and you should be able to see what the car name is.

---ADDING NEW CARS/TRACKS/ETC---(new)

I will do my best to add new tracks/layouts and cars as they get added to the game and put them in a new release. (This mostly comes down to whether or not I remember to do it).

There is a way for users to update the list manually, however I can't guarantee what'll happen if something is put in there incorrectly, so I would advise against it. If I do it, I know it's put in there correctly and there won't be any problems, if that makes sense.

That said, you CAN add new categories to choose from, if there's a particular custom game you like playing (think Cops and Robbers, Just Cruising, etc.) and wish to add it into the rotation. To do so, go into the "Data" folder and open "CustomCategoryList.txt" and add your categories there. You'll notice I've included a few categories for reference, but in the event they're not there, you can add one category and a description of that category per line, separated by a comma. For example:

Cops and Robbers, Description here
Willys Jeeps Only, Description here
Just Cruising, Description here

Just be sure to not put any commas in your name or description because that'll screw things up (guess how genius DJ the programmer figured that out).

---DELETING DRIVERS FROM THE DRIVER LIST---(del)

The list on the right has the ability to delete multiple drivers or clear the whole list. To delete a single or multiple drivers, simply left click (or hold down shift or control while left clicking to select multiple) and then click the "Delete Driver" button. This will delete the drivers and adjust the remaining drivers in the list automatically. You can delete the whole list by clicking the "Delete All" button.

---OTHER THOUGHTS---(oth)

I did not include any of the dirt tracks in my Track List due to that potentially being a mess. It wouldn't be a huge pain to add them, but you start running the risk of creating impossible races since a lot of race cars don't support dirt tires and dirt races are nearly impossible without them (remember that one tire glitch?)

This app was inspired by ideas tossed around between myself and some of the friends I've made through several GT content creators' communities, most notably EERIEISSSS and Tidgney. If you haven't checked them out, please do so. Both are great fellows!

Have fun! :)

---TL;DR---

1) Generate a track - click the randomization options you want on the right, click "Generate Track".

2) Generate a car - click which category of car you want to pick from, Gr.3, Gr.4, or Custom

3) Config which cars/tracks/categories are picked from - click the related Config button, check the boxes of the ones you want the app to pick from, click "Save".

4) Pick a random car for everyone - add drivers to the list on the right, click the category of car you want to give to everyone. Drivers can be deleted individually or in bulk by selecting them from the list.

---FUTURE IMPROVEMENTS IN VERSION 3---(fut)

1) Adding the ability to let the user determine how many cars/track choices there are before a repeat can occur. This would be super easy to do, I just don't know if I want to add it or not. It'll require some changes in logic that, while plenty feasible, would be a moderate pain.

2) When a random category is chosen, a list containing all the cars that fit into that category (stock, tuned is a whole other problem) appear somewhere

3) Maybe add dirt tracks in some capacity if enough people want it

4) Adding a way to do math based on a car's PP to where everyone can use a different car on a track and a "winner" can be determined based on lap times proportionate to their car's PP versus an "expected" lap time  - this assumes no foul play in a tuned car's setup for PP manipulation, and nobody likes PP manipulation. 



