# F# Mutability Misunderstanding: Immutable Values in Mutable Variables

This example showcases a potential pitfall in understanding mutability in F#.  While F# allows mutable variables, the values themselves are immutable. This code demonstrates how creating a new value from a mutable variable does not create a live link to the variable, but rather a copy of the value at the time of the function call.  Modifying the mutable variable later does not retroactively change previously derived values.

## Bug:
The `addOne` function doesn't modify the original `x` value; it creates a new integer value and returns it.

## Solution:
The solution demonstrates using a mutable variable correctly and explicitly demonstrating the effects of mutability by using ref cells.  This also shows the distinction of assigning a reference, not just a copy of the value.