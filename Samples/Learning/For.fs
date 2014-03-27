open System

 // A  (very inefficient) function for arithmetic mean
let avg() =
    // Initialise list [ 0; 5; 10; 15; ... 45; 50]
    let input = [0..5..50] 
    
    // Find sum
    let mutable sum = 0
    for num in input do
        sum <- sum + num

    //Find number of elements
    let mutable count = 0
    for _ in input do
        count <- count + 1
        
    // Evaluate average
    let average = sum / count
    Console.WriteLine("Average: {0}", average)

avg()
