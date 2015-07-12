Blox Events
===========


Common
------

## Common/Custom ##

A Custom Event is not bound to any system Events and is normally used where you want to trigger the Event yourself when the time is right.

You can use the Block: `Flow > Trigger Event` to trigger this Event by the name you gave it.

If you choose to send values to the Event, when using Trigger Event, those values will be available via Temp Variables named param1, param2, param3, etc, up to the number of values you send and in the same order you send them

## Common/On StateEnter ##

Triggered when the State, that this Event appears in, is activated. Note that this Event will trigger after the `On Awake` Event but before the `On Start` Event if used in the first State of a Blox. (Awake and Start are only ever triggered in the 1st State)

## Common/On StateExit ##

Triggered when the State, that this Event appears in, is exited. This happens when changing from one State to another.