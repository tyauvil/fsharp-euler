module EulerTest

open Xunit
open FsUnit.Xunit

open Euler

[<Fact>]
let ``e001_9`` () =
    e001 9 |> should equal 23

[<Fact>]
let ``e001_999`` () =
    e001 999 |> should equal 233168
