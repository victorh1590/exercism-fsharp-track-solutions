module CarsAssemble

open System

let productionPerHour : float = 221.0

let successRate (speed: int): float =
    match(speed) with
    | 10 -> 0.77
    | 9 -> 0.8
    | speed when (speed >= 5 && speed <= 8) -> 0.9
    | speed when (speed >= 1 && speed <= 4) -> 1.0
    | 0 -> 0.0

let productionRatePerHour (speed: int): float =
    successRate speed * productionPerHour
    |> (*) (float speed)

let workingItemsPerMinute (speed: int): int =
    (int (productionRatePerHour speed) / 60)