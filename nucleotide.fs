let nucleotide chars =
    let charAppearance char chars = List.filter ((=) char) (List.ofSeq chars) |> List.length
    let makeTupleForCharAppearance char chars = (char, charAppearance char chars)

    [for char in ['A'; 'T'; 'C'; 'G'] -> makeTupleForCharAppearance char chars]


nucleotide "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"