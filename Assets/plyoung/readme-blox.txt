Blox 2
Copyright (c) 2015 Leslie Young

documentation: http://www.plyoung.com/blox/
support: http://forum.plyoung.com/c/blox-2/
-----------------------------------------------------------------------------------------------------------------------

Blox 2 is a Visual Scripting solution for the Unity game engine.

It allows you to add behaviour to objects via a drag-and-drop interface with interconnecting Blocks (actions) that responds on Events while the object is in a specific State.

- Unity 4.6 and Unity 5 supported
- Runtime API to execute Blocks
- or generate C# Scripts
- Build-in State machine
- Event based system
- Blocks for most of Unity's runtime
- Ability to automatically create Block definitions for 3rd party APIs
- Even the functions from your own scripts can automatically turn into Blocks
- There is also an API for programming new Events and Blocks for more control over them
- Blocks for the Basic System and common Unity types
- Blocks for Flow control via conditions and loops
- Blocks for Maths operations, and String manipulation
- Blocks for Arrays and Lists manipulation
- Support yield instructions like WaitForSeconds
- Easily add data variable to your Project or Object via Variables in the Inspector
- Variables Global to Project, Local to Object, and Temporary to Event are supported

Tested build targets

Blox run-time:
- Stand-alone and web-player builds for Windows, Linux and OSX
- iOS and Android
- IL2CPP

Blox generated scripts:
- Stand-alone and web-player builds for Windows, Linux and OSX
- iOS and Android
- IL2CPP

-----------------------------------------------------------------------------------------------------------------------

# Getting Started #

To use a Blox you'll need to add the Blox Component onto an Object. This is similar to how you would place a script on an Object.

Select the target object and then from the menu, choose: `Component > Miscellaneous > Blox Visual Script` to add a Blox onto the object.

In the Inspector you will now see the Blox component and a button to open the editor. The editor can also be opened from the menu: `Window > Blox > Blox Editor`.

With the Blox Editor open you can start to edit the Blox. You need to add at least one State and can then add the Events to respond to under that State. After adding an Event you will see the Blocks Canvas becomes available and you will be able to grab Blocks from the right-hand panel and drag them onto the Canvas. Only Blocks that are snapped into place inside the Event Block will execute at run-time.

You will note that each Event and Blocks has build-in help/ description shown on the panel inside the Canvas.

More detailed guide can be found at, http://www.plyoung.com/blox/start/

-----------------------------------------------------------------------------------------------------------------------


