let compute first second =
    Seq.zip first second 
        |> Seq.filter (fun (a, b) -> a <> b) 
        |> Seq.length

compute "GGACGGATTCTG" "AGGACGGATTCT"