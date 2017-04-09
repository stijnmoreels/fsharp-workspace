let nucleotide chars =
    let charAppearance char chars = List.filter ((=) char) (List.ofSeq chars) |> List.length

    [for char in ['A'; 'T'; 'C'; 'G'] -> (char, charAppearance char chars)]


nucleotide "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"
