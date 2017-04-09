let square number =
    2I ** (number - 1)

let total =
    List.sumBy square  [1 .. 64]

square 16
total