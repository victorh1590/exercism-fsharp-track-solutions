module CarsAssemble

let successRate (speed: int): float =
    match(speed) with
    | 10 -> 0.77
    | 9 -> 0.8
    | speed when speed > 4 && speed <= 8 -> 0.9
    | speed when speed > 1 && speed <= 4 -> 1.0
    | 0 -> 0

let productionRatePerHour (speed: int): float =
    failwith "Please implement the 'productionRatePerHour' function"

let workingItemsPerMinute (speed: int): int =
    failwith "Please implement the 'workingItemsPerMinute' function"
