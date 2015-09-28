// Multiple of 3 and 5 below 1000

let isMultipleOf3or5 item = 
    if (item % 3 = 0 || item % 5 = 0) then
     true
    else
     false

let sumOfMultiples = [1..999] |> 
    List.filter isMultipleOf3or5 |>
    List.sum 

printfn "Sum of multiples below 1000 is %i " sumOfMultiples
