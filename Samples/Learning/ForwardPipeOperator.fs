// with Forward Pipe Operator ( it reads much more cleanly)
[0..100]
|> List.filter (fun x -> x % 2 = 0)
|> List.map (fun x -> x * 2)
|> List.sum

// without Fwrd Pipe Op
List.sum (List.map (fun x -> x * 2) 
    (List.filter (fun x -> x % 2 = 0) [0..100]))

// example
let stockData =
    [ 
      "2012-03-30,32.40,32.41,32.04,32.26,31749400,32.26";
      "2012-03-29,32.06,32.19,31.81,32.12,37038500,32.12";
      "2012-03-28,32.52,32.70,32.04,32.19,41344800,32.19";
      "2012-03-27,32.65,32.70,32.40,32.52,36274900,32.52";]
      
let splitCommas (x:string) =
    x.Split([|','|])

stockData
|> List.map splitCommas
|> List.maxBy (fun x -> abs(float x.[1] - float x.[4]))
|> (fun x -> x.[0])
