// Exponentination
let rec powerN  x n =
    if n = 0 then 1
    else x * (powerN x (n-1))
    
//Efficient Exponentination
let rec power x n =
    if n = 0 then 1
    //if n is even
    elif (n % 2 = 0) then ((power x (n/2)) * (power x (n/2)))
     //if n is odd
    else x * (power x (n-1))
 
power 5 2;;

//powerN 2 3;;
