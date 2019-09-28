open System

(*USER CODE BEGIN*)
let rec e_term (x:double) n : double =
    if n = 0 then 1.0
    else (x/float(n)) * e_term x (n-1)

let rec exp (x:double) T : double =
    if T = 0 then e_term x 0
    else e_term x T + exp x (T-1)

let f n (arr:list<double>) : list<double> =
    let precision = 9
    seq { for i = 1 to n do
            yield exp arr.[i-1] precision
        } |> Seq.toList
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Double.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse() |>List.rev
    let h = int(arr.[0])
    let t = arr |> List.tail
    f h t |> List.iter (printf "%f \n")

(*
let exp f =
  [ 1 .. 9 ]
  |> List.fold (fun acc n ->
    let fac = [ 1 .. n ] |> List.fold ( * ) 1 |> float
    acc + (pown f n) / fac) 1.

stdin.ReadToEnd().Split '\n'
|> Seq.skip 1
|> Seq.iter (float >> exp >> printfn "%f")
*)
