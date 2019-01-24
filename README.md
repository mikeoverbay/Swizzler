# Swizzler
A tool to help skin World of Tanks.. Tanks

##
Swizzler is written in VB.net managed code.
It uses OpenGL to render and modify the textures.

It supports DDS, PNG, JPG and BMP image files.
I wrote this as a tool for World of Tank modding but it is useful for working with images for other purposes.


<a href="https://youtu.be/1HXSy-03OJA">Youtube Video showing how to use the tool. </a>

In order to shut off a color channel.
Double click on the color name Red, Green, Blue or alpha.

### Version 12
Created diagram of how Swizzler routing works.
Use the help file to see it.

### Version 11
Fixed a bug with disabling and reseting the channels

### Version 10
Added a tool to stack/combine textures.
Note this uses the Red channel for input of the loaded textures.
Most games dont have a single texture for rough and metal. They are stacked or packed or combined in to one texture.
IE... Red = roughness, Green = metalic and so on.

### Version 9
Swizzler was actually saving files upside down!
This is FIXED in this version!!

### Version 8
Fixed a bug in saving 1/4 size and change the way its saved. Its much simpler now.

### Version 7
Remove BC5 type from save options.. This is NEVER used and its a strange format.

### Version 6
Added Button to resize the texture by 1/4. This saves having to save a texture and edit it in an external tool.
Cleaned up the code and removed unused items.