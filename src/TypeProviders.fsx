
//Install Ionide-Paket
//CTRL + SHIFT + P
//Paket: Init
//Paket: Install
//Paket: Add Nuget Package FSharp.Data

//---CONSUME A .CSV---
//I Do: get stock prices from google
//http://www.google.com/finance/historical?q=AAPL&output=csv
//../data/aapl.csv

#r "packages/FSharp.Data/lib/net45/FSharp.Data.dll"
open FSharp.Data

type Stocks = CsvProvider<"http://www.google.com/finance/historical?q=AAPL&output=csv">
let data = Stocks.GetSample()
let rows = data.Rows
rows |> Seq.length
rows |> Seq.head
rows 
|> Seq.map(fun r -> r.Date, r.Open) 
|> Seq.iter(fun (d,o) -> printfn "%A %A" d o)

//You Do: get titanic data
//https://raw.githubusercontent.com/paulhendricks/titanic/master/inst/data-raw/train.csv 
//../data/titanic.csv

//---CONSUME .JSON---
//I Do: get Powerball Numbers 
//https://data.ny.gov/api/views/d6yy-54nr/rows.json
//../data/powerball.json
type Powerball = JsonProvider<"../data/powerball.json">
let powerball = Powerball.Load("../data/powerball.json")
let powerData = powerball.Data
powerData |> Seq.length
powerData |> Seq.head
powerData 
|> Seq.map(fun pd -> pd.Numbers)
|> Seq.iter(fun n -> printfn "%i" n.[0])

//You Do: get gas price data
//https://data.ny.gov/api/views/nqur-w4p7/rows.json
//"../data/gasPrices.json"


