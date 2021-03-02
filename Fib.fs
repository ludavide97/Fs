//programma pova
fsharp.AddFileToProject
let fib(x) = 
    let rec _fib(x) = 
        if x<=2 then
            (1,1)
        else
            let (a,b) = _fib(x-1)
            in 
                (a+b,a)
            in  let (a , _) = _fib(x)
            in 
            a