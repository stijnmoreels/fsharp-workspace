let toRna dna =
    let dnas = [for c in dna -> c]
    let replace x = 
        match x with
        | 'G' -> 'C'
        | 'C' -> 'G'
        | 'T' -> 'A'
        | 'A' -> 'U'
    let chars = List.map replace dnas
    new System.String(List.toArray(chars))

toRna "ACGTGGTCTTAA"
    