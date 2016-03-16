# Andromeda
A working Cosmos OS GUI

This was a bit tricky. If you follow the Cosmos guide on creating GUI basics, https://github.com/CosmosOS/Cosmos/wiki/Creating-a-GUI---The-basics you'll get here but the way you create the projects in VS has to be very specific. You need to create the hardware project first, then create the main project and add it to the hardware solution, this way when you build the project it will build the main one correctly. This is hard/impossible to fix if you do it out of order.

Nontheless, this one works so you can use it as a base.

I made a mouse which originally ran very slowly, this was because Cosmos updates each pixel on the frame one at a time. So I added a graphics buffer to store the pixels and now it only updates when a change occurs. This greatly improved the speed but it still ran fairly slow, the culprit was the GetPixel() function which is not fast. I replaced it with a second buffer which represents the current state of the screen, reading from the buffer is much faster than reading from the screen and now the mouse moves very fast.

I added a rectangle drawing function that is not fast, but good for demonstrations:
![Screenshot](/Screenshot.png)

In a big update I added an 8x8 font, windows, and a window manager as well as clickable icons. The windows can be dragged around the screen and deleted by clicking the little red box in the upper right corner.
![Screenshot](/Screenshot2.png)