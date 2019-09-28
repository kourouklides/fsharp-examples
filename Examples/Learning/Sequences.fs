let intSeq =
    seq { for a in 1 .. 10 do
            printfn "intSeq: %i" a
            yield a }

let allEvens = 
    let rec loop x = seq { yield x; yield! loop (x + 2) }
    loop 0
            
seq {10 .. -1 .. 0};; (* descending *)

seq { for a in 1 .. 10 do yield a, a*a, a*a*a };; (* seq comprehensions *)

for a in (Seq.take 5 allEvens) do
    printfn "%i" a;;

// Returns the nth value of a sequence.
Seq.nth 3 intSeq;;

// Filter
Seq.filter (fun x-> if x%2=0 then true else false) (seq{0..9});;

// Fold
let sumSeq sequence1 = Seq.fold (fun acc elem -> acc + elem) 0 sequence1
Seq.init 10 (fun index -> index * index)
|> sumSeq
|> printfn "The sum of the elements is %d.";;

// Map
Seq.map (fun x->x*x+2) (seq[3;5;4;3]);;

// Seq.iter - Fibonacci
let fibs = (0I, 1I) |> Seq.unfold (fun (a, b) -> Some(a, (b, a + b) ) );;
Seq.iter (fun x -> printf "%O " x) (Seq.take 10 fibs);;
