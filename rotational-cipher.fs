let shiftChar (c:char) (s:int) =
    let max = int 'z'
    let min = int 'a'
    let increasedChar = (int c) + s
    
    char (if increasedChar > max 
            then min + (increasedChar - max) 
            else increasedChar)

let rotationalCipher (key:int) (value:string) =
    System.String.Concat(
        [for c in value -> (shiftChar c key)])
    

rotationalCipher 13 "abcdefghijklmnopqrstuvwxyz"