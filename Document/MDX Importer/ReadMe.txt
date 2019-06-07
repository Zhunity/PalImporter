*************************************************************************
******                                                             ******
******      Warcraft III MDX Importer/Exporter by Fadi Mounir      ******
******                                                             ******
******   e l e c t r i c h e a d _ _ s s @ h o t m a i l . c o m   ******
******                                                             ******
*************************************************************************

Requirements:
	3D Studio Max 5. I have never tested the script on older versions of 3DSMAX,
	so I don't know whether it'll work or not.


Importer Functionality:
	This script can read and load Warcraft III MDX models with their
	animations. The importer can read all the vertices information, including
	their normals, texture coordinates... A full skinning information can be 
	created by the importer and a list of all the animation sequences will be 
	loaded. The script will create the complete bone hierarchy of the model.

Exporter Functionality:
	The script can only export animations. It will export all your keyframes in
	a text file format very similar to the MDL file format (text version of the MDX
	file). In this way, you can easily replace the original animations with the ones
	you make by textual replacements. Any modifications made to the model meshes are
	ignored.

How To Use:
	Open the utility panel in 3D Studio max and click on the "MAXScript" button.
	Click on the "Run Script" button and choose "MDX Importer.mse". After loading
	the script, you can import any model by clicking on the "Import MDX File" button.
	If you want the importer to create skinning information for you, just check the
	"Create Skinning" checkbox. When the model loads, it will not be animated yet. You
	have to apply the animation of your choice. When you load the model, the Animation
	Sequences listbox will be filled with all the animation sequences in the model. To
	apply one, just select it from the list and click on the "Apply Selected" button.
	The reason for which I did not load all the animation sequences together is that
	some sort of interferance will happen between various animations in 3DSMAX.

Notes:
	-The geoset visibility animations are not loaded. The reason behind this is that you
	 can do whatever you want with your model once you import it. You can control
	 the visibility of the objects yourself. No need to import them. 
	
	-The animation timings in warcraft are in milliseconds. Instead of having a framerate
	 of 1000 frames per second, I reduced it to a more reasonable 300 fps. This does not
	 affect the animations speed of course.

Advantages:
	-Flawless geometries
	-Flawless texturing coordinates
	-Flawless bone hierarchy!!!
	-Flawless animations for the models!!!
	-Exporting animations is now possible. (You can even modify the main menu's animations!)

Problems:
	-NONE (so far, after testing up to 50 models!!! Cool isn't it??)

	If you have any trouble running the script, have any comments or even discover a bug, 
	please feel free to send me an e-mail (electrichead__ss@hotmail.com) with "Warcraft III"
	in the subject. I have made a tutorial that should be available at infoceptor.com on how
	to modify the game's animations.

Enjoy... :)


*******************************************************************