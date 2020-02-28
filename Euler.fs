module Euler

open System

let e001 limit =
    let arithSum n: float = (n * (n + 1.0)) / 2.0
    let x = 3.0 * arithSum (floor (float limit/3.0))
    let y = 5.0 * arithSum (floor (float limit/5.0))
    let z = 15.0 * arithSum (floor (float limit/15.0))
    Convert.ToInt32(x + y - z)
