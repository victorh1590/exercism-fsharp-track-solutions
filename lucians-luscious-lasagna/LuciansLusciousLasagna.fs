module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven minutesInOven = expectedMinutesInOven - minutesInOven

let preparationTimeInMinutes layers = layers * 2

let elapsedTimeInMinutes layers minutesInOven =
    preparationTimeInMinutes layers + minutesInOven