let squareOfSums number:int =
    let sums = List.sumBy (fun elem -> elem * elem) [1 .. number]
    let square x:int = x * x
    let squares = square (List.sum [1 .. number])
    squares - sums

squareOfSums 10