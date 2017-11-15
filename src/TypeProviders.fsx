//Install Ionide-Paket
//CTRL + SHIFT + P
//Paket: Init
//Paket: Install
//Paket: Add Nuget Package FSharp.Data

#r "packages/FSharp.Data/lib/net45/FSharp.Data.dll"

open FSharp.Data

type Stocks = CsvProvider<"http://www.google.com/finance/historical?q=MSFT&output=csv">
let data = Stocks.GetSample()
let rows = data.Rows
rows |> Seq.length
rows |> Seq.head
rows |> Seq.map(fun r -> r.Date, r.Open)
