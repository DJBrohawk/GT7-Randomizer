READ ME
Version 2.0

Hello! Welcome to DJ Brohawk's GT7 randomizer app, Version 2!. Firstly, since this readme is quite long, if there are any comments, questions, or concerns, I can be found on Twitter @DJBrohawk! :)

This app is still very much in progress, so if you stumble upon it on GitHub, avert your eyes! Just kidding.

---TABLE OF CONTENTS---(toc)

1) About (toc)
2) Generating a Random Track (trk)
3) Config Forms (cfg)

With this app, you'll be able to do a number of things:

1) Pick a random GT3 car, GT4 car, OR a car from a list of your own creation (more on that below)

2) Pick a random track, complete with a multitude of bonus randomization options

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

6) Weather - Randomizes which of the starting weather options you choose. This doesn't take into account the custom weather feature.

7) Fuel/Tire Wear - Randomizes the fuel and tire wear together. If you don't want one or the other randomized, set the "Max # of" counter for that particular one to 0. Note that it is possible for fuel and tire wear to randomly be set to "Off" in addition to a random value within the bounds of what you set.

8) Laps/Mins - Randomizes the amount of laps/minutes from 1 to the number on the "Max # of Laps/Mins" value counter, default is 10.

9) Force Rain - This forces the randomizer to choose one of the rain weather options if the track has rain available on it. If no rain is available, it just chooses one of the other weather options.

10) Force Night - This forces the randomizer to choose the latest available time on a track. Not every track supports night, so this may be something like "Evening". Best I could do, sorry ;(

11) Start Time - Randomizes the start time from the available choices on a track. This will not pick something that a track does not offer (unless my code is broken, then who knows what could happen!)

12) Tire Type - Randomizes the tire type, from Comfort Hard to Racing Softs to Heavy Wets

---CONFIG FORMS--- (cfg)

You'll notice there are buttons for various configs: Track, Gr3, Gr4, Category, and Custom - that allows you to edit the list pertaining to the random choices of tracks, cars, categories, whatever module you're in.

There are a number of buttons on the bottom of each module for mass selection or deselection of items. The buttons should be self explanatory by the text on them.

Currently, I don't have a way of filtering or sorting the items. That may come in a future update, or it may not. When I did some preliminary searching, it looked pretty annoying/difficult with WinForms, so it may not come to fruition, sorry!

You shouldn't be able to save the list with nothing checked, it should yell at you and prevent you from continuing. I'm sure the more creative among you might find a way around it, but try not to do that! :P

Each time you reload the config form, the list will be "remembered" by the app. If you close out the app entirely, the list won't be remembered and you'll have to redo it the next time you launch it.

---GENERATING A RANDOM CAR FOR EVERYONE---

To generate a random car for everyone in your race, you'll have to add drivers individually using the "Add Driver" button. Once you've added everyone in your race, click one of the Generate Race buttons to assign a random car to everyone in the list.

---ADDING CARS/TRACKS/ETC---

To add a car to the pool of cars or tracks to be chosen, open any of "Gr3List.txt", "Gr4List.txt", "CustomList.txt", "CategoryList.txt", or "TrackList.txt" in the root directory of the application, and then modify the file as you wish. Be sure to only put one name per line. For example:

Audi R8
Lamborghini Aventador
Ferrari 458

Feel free to add or delete whatever you'd like from the files. I have included separately named base text files for Group 3, Group 4, and the tracks that you can copy/paste from if you want to start fresh.

---DELETING DRIVERS FROM THE DRIVER LIST---

The list on the right has the ability to delete multiple drivers or clear the whole list. To delete a single or multiple drivers, simply left click (or hold down shift or control while left clicking to select multiple) and then click the "Delete Driver" button. This will delete the drivers and adjust the remaining drivers in the list automatically. You can delete the whole list by clicking the "Delete All" button.

---OTHER THOUGHTS---

I did not include any of the dirt tracks in my Track List due to that potentially being a mess, although you can always add them to the track list yourself and add dirt-worthy cars to a custom list ;)

This app was inspired by ideas tossed around between myself and some the friends I've made through several GT content creators' communities, most notably EERIEISSS and Tidgney. If you haven't checked them out, please do so. Both great fellows!

Have fun! :)

---FUTURE IMPROVEMENTS IN VERSION 2---

I have some improvement ideas in mind

1) Making this app not reliant on text files but rather use forms with lists and checkboxes to allow the user to include or exclude cars/tracks without manipulating text files. This method will allow for more accurate randomizing of weather and time of day related to the tracks themselves, since not all tracks support rain/night time racing.

2) Adding the ability to let the user determine how many cars/track choices there are before a repeat can occur.



