open System

let main() =
    let P = Console.ReadLine() |> seq |> Seq.toList
    let Q = Console.ReadLine() |> seq |> Seq.toList

    seq { for i = 1 to 2*(Seq.length P) do if i%2<>0 then yield P.[((i+1)/2)-1] else yield Q.[(i/2)-1] } |> Seq.iter (printf "%c")

main()
