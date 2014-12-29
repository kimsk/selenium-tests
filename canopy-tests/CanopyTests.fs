module CanopyTests

open Xunit
open FsUnit.Xunit
open canopy
open System

[<Fact>]
let ``open google`` () =
    start chrome

    url "http://www.google.com"

    quit()