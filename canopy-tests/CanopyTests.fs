module CanopyTests

open Xunit
open FsUnit.Xunit
open canopy
open System

[<Fact>]
let ``open google`` () =
    configuration.chromeDir <- @".\"

    start chrome
   
    url "http://www.google.com"

    screenshot "." "google-using-chrome-canopy.png" |> ignore

    quit()