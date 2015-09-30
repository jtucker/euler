

let fibs = (0, 1) |> Seq.unfold( fun(a,b) -> Some(a, (b, a+b)) )
let sumOfFibs = 
 Seq.takeWhile (fun eI -> eI < 4000000) fibs |>
 Seq.filter (fun x -> x % 2 = 0 ) |>
 Seq.sum
