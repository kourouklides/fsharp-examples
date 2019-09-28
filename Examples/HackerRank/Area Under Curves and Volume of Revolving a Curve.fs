open System

let main()=
    let a = stdin.ReadLine().Split ' ' |> Array.map(fun x -> int(x)) |> Array.toList
    let b = stdin.ReadLine().Split ' ' |> Array.map(fun x -> int(x)) |> Array.toList
    let (L, R) = System.Console.ReadLine().Split(' ') |> Array.map (int) |> (fun arr -> arr.[0], arr.[1])
    let step = 0.001

    let eval (a:list<int>) (b:list<int>) (x:double) =
        let length = a |> List.length
        seq {for i = 1 to length do yield double(a.[i-1])*pown x b.[i-1]}
        |> Seq.sum

    let area a b L R (step:double) : double =
        let M = int(double(R-L)/step)
        seq {for i = 1 to M do yield double(L) + double(i)*step}
        |> Seq.fold (fun acc x -> acc + step * eval a b x) 0.

    let volume a b L R (step:double) : double =
        let M = int(double(R-L)/step)
        seq {for i = 1 to M do yield double(L) + double(i)*step}
        |> Seq.fold (fun acc x -> acc + Math.PI * step * eval a b x * eval a b x) 0.

    let A = area a b L R step
    let V = volume a b L R step
    printfn "%f" A
    printfn "%f" V

main()

(*
//Enter your code here. Read input from STDIN. Print output to STDOUT
let toIntSeq (str : string) = (str.Split [|' '|]) |> Seq.map float
let firstLine = System.Console.ReadLine()
let secondLine = System.Console.ReadLine()
let thirdLine = System.Console.ReadLine()

let pol = Seq.zip (toIntSeq firstLine) (toIntSeq secondLine)
let interval = (toIntSeq thirdLine) |> Seq.toList

let eval p x =
    p
    |> Seq.map (fun (c,e) -> c * System.Math.Pow(x, e))
    |> Seq.sum

let area p a b step =
    [a .. step .. b]
    |> Seq.map (fun x -> (eval p x) * step)
    |> Seq.sum

let volume p a b step =
    [a .. step .. b]
    |> Seq.map (fun x -> System.Math.Pow(eval p x, 2.0) * System.Math.PI * step)
    |> Seq.sum
    
printf "%.1f\n" (area pol interval.[0] interval.[1] 0.001)
printf "%.1f\n" (volume pol interval.[0] interval.[1] 0.001)
*)
