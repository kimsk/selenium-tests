module CanopyTests

open Xunit
open FsUnit.Xunit
open canopy
open System

[<Fact>]
let ``open google`` () =
    configuration.chromeDir <- @".\"

    start chrome
    browser.Manage().Window.Size <- new System.Drawing.Size(1440,900) 
   
    url "http://www.google.com"

    screenshot "." "google-using-chrome-canopy.png" |> ignore

    quit()