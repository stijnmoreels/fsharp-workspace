let isMultiply (a:int, b:int) = a % b = 0

let isMultiples (elem:int, multiples:list<int>) =
    let rec check (elem:int, index:int) =
        if index = multiples.Length 
            then false
            else isMultiply (elem, multiples.[index]) || check (elem, (index + 1))
    
    check (elem, 0)

let sumofMultiples multiples max =
    [1 .. (max - 1)] 
        |> Seq.filter (fun elem -> isMultiples(elem, multiples)) 
        |> Seq.distinct 
        |> Seq.sum

sumofMultiples [3; 5] 20