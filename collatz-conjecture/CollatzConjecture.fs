module CollatzConjecture

let stepForEven (number: int): int = int (number / 2)
let stepForOdd (number: int): int = (number * 3) + 1
let isEven (number: int): bool = (number % 2) = 0
        
let steps (number: int): int option =
    let mutable counter = 0
    let mutable lastNumber = number
    while (lastNumber > 1) do
        if isEven lastNumber then
            lastNumber <- stepForEven lastNumber
            counter <- counter + 1
        else
            lastNumber <- stepForOdd lastNumber
            counter <- counter + 1
    match counter with
    | counter when counter > 0 -> Some counter
    | counter when counter < 0 || number <= 0 -> None
    | _ when number = 1 -> Some 0
    | _ -> failwith "Error"