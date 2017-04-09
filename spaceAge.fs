type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let toSeconds x = x * 31556952m;;

let spaceAge (planet:Planet, s:decimal) =
    let earthYears = match planet with 
        | Earth -> 1m
        | Mercury -> 0.2408467m
        | Venus -> 0.61519726m
        | Mars -> 1.8808158m
        | Jupiter -> 11.862615m
        | Saturn -> 29.447498m
        | Uranus -> 84.016846m
        | Neptune -> 164.79132m

    s / toSeconds earthYears

spaceAge (Planet.Earth, 1000000000m)
spaceAge (Planet.Mercury, 2134835688m)