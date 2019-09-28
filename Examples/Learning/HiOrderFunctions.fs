open System

//The Composition Function (<< operator) 
let f x = x*x
let g x = -x/2.0 + 5.0
 
let fog = f << g    // f(g(x))
let gof = f >> g    //g(f(x))

// The |> Operator
let square x = x * x
let add x y = x + y
let toString x = x.ToString()
let complexFunction1 x =
    x
    |> add 5 |> square |> toString

// Anonymous Functions (using the fun keyword)
let complexFunction2 =
    2                            (* 2 *)
    |> ( fun x -> x + 5)         (* 2 + 5 = 7 *)
    |> ( fun x -> x * x)         (* 7 * 7 = 49 *)
    |> ( fun x -> x.ToString() ) (* 49.ToString = "49" *)

// Timer Function (only works in Visual Studio)
(*let duration f = 
    let timer = new System.Diagnostics.Stopwatch()
    timer.Start()
    let returnValue = f()
    printfn "Elapsed Time: %i" timer.ElapsedMilliseconds
    returnValue
 
let rec fib = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib (n - 1) + fib (n - 2)
 
let main() =
    printfn "fib 5: %i" (duration ( fun() -> fib 5 ))
    printfn "fib 30: %i" (duration ( fun() -> fib 30 ))
 
main()
*)

complexFunction1 2;;
//(f << g) 2.0;;
fog 2.0;;   // 16.0 
gof 2.0;;   //3.0
