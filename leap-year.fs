let (|DivisibleBy|_|) (divisor:int) (integer:int) = 
    if integer % divisor = 0 
        then Some DivisibleBy 
        else None

let isLeapYear (year:int) =
    match year with
    | DivisibleBy 400 -> true
    | DivisibleBy 100 -> false
    | DivisibleBy 4 -> true
    | _ -> false

isLeapYear 1996
isLeapYear 1997