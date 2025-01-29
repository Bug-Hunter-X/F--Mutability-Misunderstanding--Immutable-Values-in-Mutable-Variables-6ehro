let mutable x = ref 10

let addOne xRef = 
    let newValue = !xRef + 1
    xRef := newValue
    newValue

let y = addOne x

printf "%d %d" !x y //Output: 11 11

!x <- 12
printf "%d %d" !x y // Output: 12 11