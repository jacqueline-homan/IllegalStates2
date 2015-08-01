open System

type Price =
    { Id : int
      Ticker : string
      Side : int
      Price : decimal
      TraderId : int option
      BrokerId : int option }

let goodPrice =
    { Id = 1
      Ticker = "GOOG"
      Side = 1
      Price = 551.76M
      TraderId = Some 16
      BrokerId = None }

let badPrice =
    { Id = 1
      Ticker = ""
      Side = 3
      Price = 551.76M
      TraderId = None
      BrokerId = None }

type MarketSide =
    | Bid
    | Ask





[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

