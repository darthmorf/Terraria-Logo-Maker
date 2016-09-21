# Terraria-Logo-Maker
A custom Terraria styled logo generator

For the program to work, simply extract the contents of the downloaded zip file to a folder of your choice, and run the executable.
This program is written in C# - you may have trouble getting it to run on non-windows PCs.


Terraria Logo Maker Currently Ships with one theme:
- Overworld (Thanks to @MinieK and @Eli10293 )
(More to come in the future)

There will also be a list of optional additional themes, once some are released.
To install a new theme, follow these steps:
  1. Navigate to the folder you extracted the zip to.
  2. Drop the folder into the 'Textures' folder. (It should exist, but if it doesn't, create it.)
  3. ????
  4. Profit.

To create a theme is a lot of work, but it's not complicated. It'd be awesome if you guys would make some to support the program!
I recommend before you start out making a few normal logos to get the hang of it, using Devilbro's guide: http://forums.terraria.org/index.php?threads/devilbros-terraria-logo-tutorial.47526/

Before any info on how to actually make them, it's important to know how they must be structured.
TLM will support any ascii character. Each character image should be in png format, with the name of the file being it's ascii value. For example '&' has an ascii value of 38, so the '&' file would be called 38.png (you can look up the values here: http://www.ascii-code.com/ - look at the value marked 'Dec' for decimal). All images must be in a folder with the name of the folder being the name of the theme. As well as the ascii characters, the theme could include a tree equivalent (titled tree.png). For the logo to end properly, the theme must also include a starter image (starter.png) and an ender image (ender.png). These wrap off the ends, so the logo doesn't stop without closing. Don't forget to add a space as well - (ascii value 38) you can do this easily by using the starter and ender images together.
There is a template set that you're welcome to look at and modify to make your own that can be downloaded here:
https://github.com/darthmorf/Terraria-Logo-Maker/releases/download/v1.0/TLM_Template_Theme.zip

For more information visit the TCF thread: http://forums.terraria.org/index.php?threads/program-darthmorfs-terraria-logo-maker.48889/

You can also fill in the contact form on my website (http://madmog.co.uk/) or submit an issue here pn github
