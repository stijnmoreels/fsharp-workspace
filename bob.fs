let (|EndsWith|_|) (tail:string) (input:string) = 
    if input.EndsWith(tail) 
        then Some EndsWith 
        else None

let (|IsEmpty|_|) (input:string) =
    if System.String.IsNullOrWhiteSpace(input)
        then Some IsEmpty
        else None

module bob =
    let hey (input:string) =
        match input with
        | EndsWith "?" -> "Sure"
        | EndsWith "!" -> "Whao, chill out!"
        | IsEmpty input -> "Fine. Be that way!"
        | _ -> "Whatever"

open bob

hey "Tom-ay-to, tom-aaaah-to."
hey "WATCH OUT!"
hey "Does this cryogenic chamber make me look fat?"
