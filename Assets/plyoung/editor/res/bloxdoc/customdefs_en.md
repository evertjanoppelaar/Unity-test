Blox Custom Definitions
=======================


Values
------

## Values/Blox ##

Can carry a reference to a Blox object (component) that is attached to a GameObject.

## Values/Boolean ##

Represents a Boolean (true or false) value.

## Values/Integer ##

Int32 (Integer) value type represents 32-bit signed integers with values that range from negative 2,147,483,648 through positive 2,147,483,647.

## Values/Float ##

The Single (Float) value type represents a single-precision 32-bit number with values ranging from negative 3.402823e38 to positive 3.402823e38.

## Values/String ##

A string is a sequential collection of Unicode characters that is used to represent text. A String object is a sequential collection of System.Char objects that represent a string. The value of the String object is the content of the sequential collection.

## Values/More/SystemObject ##

This is the base class of all classes in the .NET Framework; it is the root of the type hierarchy.

## Values/More/Byte ##

The Byte value type represents 8-bit unsigned integers with values that range from 0 to 255.

## Values/More/SByte ##

The SByte value type represents 8-bit signed integers with values ranging from negative 128 to positive 127.

## Values/More/Char ##

Represents a character as a UTF-16 code unit.

## Values/More/Decimal ##

The Decimal value type represents decimal numbers ranging from positive 79,228,162,514,264,337,593,543,950,335 to negative 79,228,162,514,264,337,593,543,950,335. 

## Values/More/Double ##

The Double value type represents a double-precision 64-bit number with values ranging from negative 1.79769313486232e308 to positive 1.79769313486232e308.

## Values/More/UInt32 ##

The UInt32 value type represents 32-bit unsigned integers with values ranging from 0 to 4,294,967,295.

## Values/More/Int64 ##

The Int64 value type represents 64-bit integers with values ranging from negative 9,223,372,036,854,775,808 through positive 9,223,372,036,854,775,807.

## Values/More/UInt64 ##

The UInt64 value type represents 64-bit unsigned integers with values ranging from 0 to 18,446,744,073,709,551,615.

## Values/More/Int16 ##

The Int16 value type represents 16-bit integers with values ranging from negative 32768 through positive 32767.

## Values/More/UInt16 ##

The UInt16 value type represents 16-bit unsigned integers with values ranging from 0 to 65535.

## Values/More/plyVarAsType ##

Used by the "variable as" Blocks to indicate what kind of value type you want from the variable.

## Values/Component/as Blox ##

Helper that will return reference to the Blox component of a GameObject or the GameObject of a Component.

## Values/Self: GameObject ##

Returns a reference to the GameObject that this Block is called in.

## Values/Self: Blox ##

Returns a reference to the Blox that this Block is called in.


Variables
---------

## Variables/Temp Value ##

- name: Name of the variable.
- to: Value to set variable to.

Set or Get the value stored in a Temporary Variable of the Event this Block is used in.

## Variables/Temp Value as ##

- name: Name of the variable.
- as: Type to return the value as.

Get the value, converted to specified type, that is stored in a Temporary Variable of the Event this Block is used in.

## Variables/Local Value ##

- name: Name of the variable.
- to: Value to set variable to.
- in: Blox object to get the local variable value from.

Set or Get the value stored in a Local Variable of the specified Blox object.

## Variables/Local Value as ##

- name: Name of the variable.
- in: Blox object to get the local variable value from.
- as: Type to return the value as.

Get the value, converted to specified type, that is stored in a Local Variable of the specified Blox object.

## Variables/Global Value ##

- name: name of the variable.
- to: Value to set variable to.

Get or Set the value stored in a Global Variable of the Blox system.

## Variables/Global Value as ##

- name: name of the variable.
- as: Type to return the value as.

Get the value, converted to specified type, stored in a Global Variable of the Blox system.

## Variables/Temp Variable ##

- name: Name of the variable.

Returns reference to a temporary variable of the Event this Block is used in. Will create the variable if it does not exist.

## Variables/Local Variable ##

- name: Name of the variable.
- in: Blox object to get the local variable from.

Returns reference to a local variable of the specified Blox object. Will create the variable if it does not exist.

## Variables/Global Variable ##

- name: name of the variable.

Returns reference to a global variable of the Blox system. Will create the variable if it does not exist.


Comparison
----------

## Comparison/a AND b ##

Returns True if both A and B is True, else False if either is False.

## Comparison/a OR b ##

Returns True if either A or B is True, else False if both are False.

## Comparison/NOT a ##

Returns True if A is False, else False if A is True.

## Comparison/a = b ##

Returns True if A is equal to B, else False.

## Comparison/a ≠ b ##

Returns True if A is not equal to B, else False.

## Comparison/a < b ##

Returns True if A is smaller than B, else False.

## Comparison/a ≤ b ##

Returns True if A is smaller than or equal to B, else False.

## Comparison/a > b ##

Returns True if A is greater than B, else False.

## Comparison/a ≥ b ##

Returns True if A is greater than or equal to B, else False.


Flow
----

## Flow/Break ##

Normally used to terminate a <b>loop type block</b> when used inside a loop, like the Loop and While Blocks. Execution will continue with the Block that follows on the loop Block. If used outside of a loop (for example on the Event hierarchy) it will cause the Event to terminate. Will cause event to stop if used in non-Loop container.

## Flow/Stop ##

Will cause the Event to terminate immediate, even if execution is inside a <b>loop type block</b>.

## Flow/Goto First ##

Can be used to restart execution of Blocks at the first Block of the Event. When used in a <b>loop type block</b>, like the Loop or While Blocks, it will cause execution to continue from the first Block of the loop (and not the Event). Will cause execution to continue from first Block of Event if used in a non-loop container.

## Flow/Do After Timeout ##

- varName: Name of a Local Variable that is being used as a counter.

This Block must be used in an Event that gets called every frame, like <b>Update</b> or <b>Late Update</b>, since it needs to update a counter that counts down.

The Block makes use of Local Variables so that you can initialise the Variable in another Event of the Blox or even from a different Blox. See the Block <b>Variables > Local Value</b> on how to set the value of the Variable.

As long as the Variable is not defined or its value is 0.0 or less (it makes use of a Float Value) it will not do anything. The Block will perform the count-down (each time it is called) as long as the value is higher than 0.0 and once it reaches 0.0 or less it will execute the child Blocks and then stop doing anything until the Variable is reset to a value higher than 0.0.

The countdown is in second, so setting the value of the variable to 2.0 will result in a 2 second count-down before the child Blocks will be run. Assuming you use this Block in an Event that gets called on a regular basis so that the count-down can occur reliably.

## Flow/IF ##

The IF Block will only execute its child Blocks (contained Blocks) if the result of the <b>condition</b> test is True.

## Flow/ElseIF ##

The ElseIF Block will only execute its child Blocks (contained Blocks) if the result of the <b>condition</b> test is True or if no condition was specified; AND if the Block it follows on (the previous Block) has a False result.

This Block is normally attached to the bottom of an IF or other ElseIF Block to perform an alternate action when the IF Block's condition test resulted in a False. It is possible to attach this Block to the bottom of a non-IF Block but this will result in errors in Script Mode.

## Flow/While ##

The While Block is a <b>Loop type Block</b> and will continue to execute its child Blocks until the condition result is False. The Break Block can be used to force this loop to stop.

## Flow/Loop ##

- with: An optional Variable that will be used as counter. You only need to specify this Variable if you would like to access use the count value inside the Loop.
- from: The value the loop will start counting from.
- while not: The loop will continue until this value is reached and then terminate immediately. This value must be higher than the start value since the loop can't count down.

The Loop Block is a <b>Loop type Block</b> and is used to execute the child Blocks a certain number of times.

Ex. If you want the loop to call the child Blocks 10 times then <b>from</b> can be set to 0 and <b>while not</b> can be set to 10; because as soon as the counter reaches 10 it will exit the loop and not execute any child blocks. So if <b>from</b> was set to 1 then <b>while not</b> would have to be set to 11 to have the loop perform 10 times.

The <b>with</b> field takes an optional Variable reference. This can either be the <b>Temp Variable</b>, <b>Local Variable</b>, or <b>Global Variable</b> Blocks (note, not the Variable 'Get Value' related Blocks).

## Flow/Set State ##

- name: Name of State as defined in the Blox.
- in: The Blox in which to change the State.

Set the State of a Blox.

## Flow/Trigger Event ##

- name: Name of Event as defined in the Blox.
- in: The Blox in which to trigger the Event.
- after: How many seconds to wait before triggering the Event.

Trigger an Event in a Blox. Only Custom Events should be triggered in this manner. Any other Event could cause errors.

My may also add additional values to send to the Event. These values will be available as Temporary Variables with the names, param1, param2, param3, up to the number of values you chose to send.

## Flow/WaitForEndOfFrame ##

Will pause execution of the Event at the Block and wait until the end of the frame after all cameras and GUI is rendered, just before displaying the frame on screen, before continuing to execute the Blocks to follow

<b>Note:</b> This Blocks can only be used as a direct child Block of the Event or as a child Block (or in child Blocks) of the IF and ElseIF Blocks and no other Blocks. 

If you intend on using Script mode then this Blocks should only be used in `Common > Custom` Events and no other Events. You can trigger a Custom Event with the Flow > Trigger` Block from any other Event.

## Flow/WaitForOperation ##

Will pause execution of the Event at the Block and wait for the specified operation to complete before continuing to execute the Blocks to follow.

<b>Note:</b> This Blocks can only be used as a direct child Block of the Event or as a child Block (or in child Blocks) of the IF and ElseIF Blocks and no other Blocks. 

If you intend on using Script mode then this Blocks should only be used in `Common > Custom` Events. You can trigger a Custom Event with the Flow > Trigger` Block from any other Event.

## Flow/WaitForSeconds ##

Will pause execution of the Event at the Block and wait for the specified number of seconds before continuing to execute the Blocks to follow.

<b>Note:</b> This Blocks can only be used as a direct child Block of the Event or as a child Block (or in child Blocks) of the IF and ElseIF Blocks and no other Blocks. 

If you intend on using Script mode then this Blocks should only be used in `Common > Custom` Events. You can trigger a Custom Event with the Flow > Trigger` Block from any other Event.

## Flow/WaitForFixedUpdate ##

Will pause execution of the Event at the Block and wait until the next FixedUpdate Event would be triggered before continuing to execute the Blocks to follow.

<b>Note:</b> This Blocks can only be used as a direct child Block of the Event or as a child Block (or in child Blocks) of the IF and ElseIF Blocks and no other Blocks. 

If you intend on using Script mode then this Blocks should only be used in `Common > Custom` Events. You can trigger a Custom Event with the Flow > Trigger` Block from any other Event.

Blox
----

## Flow.Blox.RunEvent (name) ##

Cause the named Event to run and execute its contained Blocks immediately.

## Flow.Blox.SetActivateState (name) ##

Set the Blox' State to the named State. Changing the State will cause the active Event to stop immediately.

## Flow.Blox.SetActivateState (idx) ##

Set the Blox' State to the State appearing at idx in the list of defined States. Note that indices always starts at 0 so the first State would 0 and the second would be 1. Changing the State will cause the active Event to stop immediately.

Common
------

## Common/Debug Message ##

This will show a message in the Unity Console.

You may choose a type, which will determine the colour of the message. Log = White, Warning = Yellow, and Error = Red.

You may also add additional fields to the Block (up to 5) and then drop other Blocks into those fields. The values from those Blocks will be shown in the console together with the message you have entered.

## Common/Comment ##

A container type comment Block that will execute its child Blocks. A Comment Block that does not perform any other special action and is simply used for notes to yourself.

## Common/Comment Line ##

A Comment Block does not perform any special action and is simply used for notes to yourself.

Array
-----

## Common/Array/Add ##

Add a value to the array.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Clear ##

Clear and return an empty array.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Clone ##

Clone the array into another array. You normally want to provide a variable as target.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Contains ##

Will return True if the array contains the specified value.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Count ##

Returns a count of the number of values in the array. This is the size of the array. 

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Get Value ##

Return the value at the specified index in the array.

Array indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the array (Count).

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Index Of ##

Returns the index of the first value that is the same as the specified value, or -1 if it was not found in the array. 

Array indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the array (Count).

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Insert ##

Insert a value into the array at the specified index.

Array indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the array (Count).

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Remove ##

Remove the first value that matches the specified value in the array.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Remove At ##

Removes the value that is at the given index in the array.

Array indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the array (Count).

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Reverse ##

Reverse the order in which the values appears in the array.

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Set ##

Set (replaces) the value at the specified index in the array.

Array indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the array (Count).

While an array can contain any kind of value you should not mix value types in the same array.

## Common/Array/Sort ##

Sort the values in the array. Sorting depends on the type of the element and you can normally only sort values that are of number or string types.

While an array can contain any kind of value you should not mix value types in the same array.

List
-----

## Common/List/Add ##

Add a value to the list.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Clear ##

Clear and return an empty list.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Clone ##

Clone the list into another list. You normally want to provide a variable as target.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Contains ##

Will return True if the list contains the specified value.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Count ##

Returns a count of the number of values in the list. This is the size of the list. 

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Get Value ##

Return the value at the specified index in the list.

List indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the list (Count).

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Index Of ##

Returns the index of the first value that is the same as the specified value, or -1 if it was not found in the list. 

List indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the list (Count).

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Insert ##

Insert a value into the list at the specified index.

List indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the list (Count).

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Remove ##

Remove the first value that matches the specified value in the list.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Remove At ##

Removes the value that is at the given index in the list.

List indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the list (Count).

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Reverse ##

Reverse the order in which the values appears in the list.

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Set ##

Set (replaces) the value at the specified index in the list.

List indices always start at 0. The first element is at index 0, the second at index 1, up to the max index which is one less than the size of the list (Count).

While an list can contain any kind of value you should not mix value types in the same list.

## Common/List/Sort ##

Sort the values in the list. Sorting depends on the type of the element and you can normally only sort values that are of number or string types.

While an list can contain any kind of value you should not mix value types in the same list.

Maths
-----

## Maths/a - b (subtraction) ##

Subtract B from A and return the result. The type of the result will depend on the type of the values passed.

The Block will attempt to convert B to the same type as A if unable to at first perform the operation with types as they are. It fail with an error message if the operation could not be completed even after conversion.

## Maths/a + b (addition) ##

Add A and B together and return the result. The type of the result will depend on the type of the values passed.

The Block will attempt to convert B to the same type as A if unable to at first perform the operation with types as they are. It fail with an error message if the operation could not be completed even after conversion.

## Maths/a × b (multiplication) ##

Multiply A with B and return the result. The type of the result will depend on the type of the values passed.

The Block will attempt to convert B to the same type as A if unable to at first perform the operation with types as they are. It fail with an error message if the operation could not be completed even after conversion.

## Maths/a ÷ b (division) ##

Divide A by B and return the result. The type of the result will depend on the type of the values passed.

The Block will attempt to convert B to the same type as A if unable to at first perform the operation with types as they are. It fail with an error message if the operation could not be completed even after conversion.


## Maths/a MOD b (remainder) ##

Divide A by B and return the <b>remainder</b> of the result. The type of the result will depend on the type of the values passed.

The Block will attempt to convert B to the same type as A if unable to at first perform the operation with types as they are. It fail with an error message if the operation could not be completed even after conversion.


## Maths/Bitwise/a & b (and) ##

The bitwise AND operator (&) compares each bit of the first operand to the corresponding bit of the second operand. If both bits are 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.

Both operands to the bitwise AND operator must be of integral types (like Integer, Int16, UInt32, Byte, and other whole numbers).

## Maths/Bitwise/a | b (or) ##

The bitwise inclusive OR operator (|) compares each bit of its first operand to the corresponding bit of its second operand. If either bit is 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.

Both operands to the bitwise AND operator must be of integral types (like Integer, Int16, UInt32, Byte, and other whole numbers).

## Maths/Bitwise/a ^ b (xor) ##

The bitwise exclusive OR operator (^) compares each bit of its first operand to the corresponding bit of its second operand. If one bit is 0 and the other bit is 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.

Both operands to the bitwise AND operator must be of integral types (like Integer, Int16, UInt32, Byte, and other whole numbers).

## Maths/Bitwise/a << b (left shift) ##

The left-shift operator (<<) shifts its first operand left by the number of bits specified by its second operand. The type of the second operand must be an Integer (Int32) or a type that has a predefined implicit numeric conversion to Integer.

If the first operand is an Int32 (Integer) or UInt32 (32-bit quantity), the shift count is given by the low-order five bits of the second operand. That is, the actual shift count is 0 to 31 bits.

If the first operand is a Int64 or UInt64 (64-bit quantity), the shift count is given by the low-order six bits of the second operand. That is, the actual shift count is 0 to 63 bits.

Any high-order bits that are not within the range of the type of the first operand after the shift are discarded, and the low-order empty bits are zero-filled. Shift operations never cause overflows.

## Maths/Bitwise/a >> b (right shift) ##

The right-shift operator (>>) shifts its first operand right by the number of bits specified by its second operand.

If the first operand is an Int32 (Integer) or UInt32 (32-bit quantity), the shift count is given by the low-order five bits of the second operand (second operand & 0x1f).

If the first operand is a Int64 or UInt64 (64-bit quantity), the shift count is given by the low-order six bits of the second operand (second operand & 0x3f).

If the first operand is an Int32 (Integer) or Int64, the right-shift is an arithmetic shift (high-order empty bits are set to the sign bit). If the first operand is of type UInt32 or UInt64, the right-shift is a logical shift (high-order bits are zero-filled).

