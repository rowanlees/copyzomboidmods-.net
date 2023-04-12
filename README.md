# copyzomboidmods
Provides a quick way for you to copy Project Zomboid mods from your steam workshop folder to your user Zomboid mods folder e.g. C:\Users\user\Zomboid\mods.

This is useful if you run Zomboid with the -nosteam launch option, which in itself is useful for hosting zomboid servers directly from the game with lower load times. When launched this way, mods are picked up from the C:\Users\user\Zomboid\mods folder rather than the Steam workshop folder.

Downloading the program:

Download the latest zip files from the releases page https://github.com/rowanlees/copyzomboidmods/releases. Extract and run the .exe

Using the program:

You will have to tell the program where both the workshop folder and the user mods folder is. Usually you can find the workshop folder in 'C:\Program Files (x86)\Steam\steamapps\workshop\content\108600' and the user mods folder in 'C:\Users\user\Zomboid\mods' (replace user with your username).

If a mod gets updated and you want to use said update, you will have to run this process again. It is worth clearing out your C:\Users\user\Zomboid\mods folder before doing this to ensure any mods that remove features/files do this, as this program does not check for these changes, it would simply skip/overwrite existing files and add new ones
