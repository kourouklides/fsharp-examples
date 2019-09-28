let  tail = function
    | [] -> []
    | hd :: tl -> tl

let  head = function
    | [] -> 0           // it could throw exeption here
    | hd :: tl -> hd
    
let x = 2::3::4::[]

tail x;;
head x;;
