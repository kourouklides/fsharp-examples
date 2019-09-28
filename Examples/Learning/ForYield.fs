// Numbers
[ for a in 1 .. 2 do
    for b in 3 .. 5 do
        yield (a, b) ]
        
// Letters
let x = [ 'a' .. 'f' ]
[for y in x do yield [y; y; y] ]

//yield! pushes a collection of values into the list
[for a in 1 .. 5 do
    yield! [ a .. a + 3 ] ]
    
//arrow-based syntax for list comprehensions
[ for a in 1 .. 5 -> a * a]

// Mixing yield! and yield
[for a in 1 .. 5 do
    match a with
    | 3 -> yield! ["hello"; "world"]
    | _ -> yield a.ToString() ]
