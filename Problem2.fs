

let rec fib x y = 
    fib x (x + y)

let rec fibFor4mill x y = 
    let next = x + y
    if next < 4000000 then
        fibFor4mill y next
    else
        next

printfn "Total: %i" (fibFor4mill 1 2)