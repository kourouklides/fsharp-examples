// (Singly Linked) List using .. List Comprehensions
let firstHundred = [0..5..100]

// Mapping Lists
let doubled = List.map (fun x -> x * 2) firstHundred

// Filtering Lists
[1 .. 10] |> List.filter (fun x -> x % 2 = 0)

// List.init
List.init 3 (fun index -> (index, index * index, index * index * index))

// Arithmetic mean of int
let avg1 = List.averageBy (fun elem -> float elem) firstHundred

// Arithmetic mean of float
let avg2 = List.average [0.0; 1.0; 1.0; 2.0]

// the :: ("cons") Operator
let z = 1 :: 2 :: 3 :: 4 :: []
let y = 12 :: z 

// List.append and the @ Operator 
let first      = [1; 2; 3;]
let second     = [4; 5; 6;]
let combined1  = first @ second           (* returns [1; 2; 3; 4; 5; 6] *)
let combined2  = List.append first second (* returns [1; 2; 3; 4; 5; 6] *)

// List.choose (it filters and maps a list simultaneously)
let listWords = [ "and"; "Rome"; "Bob"; "apple"; "zebra" ]
let isCapitalized (string1:string) = System.Char.IsUpper string1.[0]
let results = List.choose (fun elem ->
    match elem with
    | elem when isCapitalized elem -> Some(elem + "'s")
    | _ -> None) listWords
printfn "%A" results

// List.fold or List.foldBack + fun/op + seed + input
let a = [ 1 .. 100 ] |> List.fold ( + ) 0

let factorial n = [ 1I .. n ] |> List.fold ( * ) 1I
let x = factorial 13I

// List.find and List.tryFind 

(*  return the first item in the list for which the search function returns true
    they only differ as follows:
    if no items are found that meet the search function,
        find throws a KeyNotFoundException,
        while tryfind returns None. *)
