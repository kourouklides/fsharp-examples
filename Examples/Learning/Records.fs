// Cloning Records
type TransactionItem =
    { Name : string;
        ID : int;
        ProcessedText : string;
        IsProcessed : bool }
 
let getItem name id =
    { Name = name; ID = id; ProcessedText = null; IsProcessed = false }
 
let processItem item =
    { item with
        ProcessedText = "Done";
        IsProcessed = true }
 
let printItem msg item =
    printfn "%s: %A" msg item   
 
let main() =
    let preProcessedItem = getItem "Steve" 5
    let postProcessedItem = processItem preProcessedItem
 
    printItem "preProcessed" preProcessedItem
    printItem "postProcessed" postProcessedItem
 
main()

// Pattern Matching Records
type coords = { X : float; Y : float }
 
let getQuadrant = function
    | { X = 0.0; Y = 0.0 } -> "Origin"
    | item when item.X >= 0.0 && item.Y >= 0.0 -> "I"
    | item when item.X <= 0.0 && item.Y >= 0.0 -> "II"
    | item when item.X <= 0.0 && item.Y <= 0.0 -> "III"
    | item when item.X >= 0.0 && item.Y <= 0.0 -> "IV"
 
let testCoords (x, y) =
    let item = { X = x; Y = y }
    printfn "(%f, %f) is in quadrant %s" x y (getQuadrant item)
 

testCoords(0.0, 0.0);;
testCoords(1.0, 1.0);;
testCoords(-1.0, 1.0);;
testCoords(-1.0, -1.0);;
testCoords(1.0, -1.0);;
