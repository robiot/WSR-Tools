# WSR-Tools
Wanna make your desktop look better - or hide windows activation? With this tool you can do that with just a click of a button
It can hide the shortcut arrows, make your taskbar fully transparent and hide windows activation

# How do download?
Just go to Releases and download or compile the source code yourself

# How does it work?
The only thing it does is to change registry keys and values!
If you wonder why you need to run the program as administrator for some things to work, thats because to change registry keys in local machine requires the program to run as admin

## If you want to compile the source code do like this.
1. open the .sln file in visual studio 2019
2. right click references to the right and click add reference
3. A window should pop up, there click browse in the bottom
4. Select the FlatUI.dll in the WSR-Tool directory and click "add"
5. Then check that the FlatUi is checked, if not click the empty checkbox to the left of the name
6. Then just click ok

 ## When your finished adding the reference, we need to build this as a x64 application
 7. Click project in the top bar
 8. Click WSR-Tool Properties
 9. Click "Build" in the right listbox
 10. Click "Any CPU" and change that to x64
 
 **!!! now you can finaly build the application**


*[bug] when removing shortcut arrows it says that you need to run as admin even if you run it as admin, but it still works*
This is now archived since its very bugged.
