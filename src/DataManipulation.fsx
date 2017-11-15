
//---SELECTING---

[1 .. 10].[3]

[1 .. 10].[3..6]

[1 .. 10]
|> Seq.head

[1 .. 10]
|> Seq.tail

[1 .. 10]
|> Seq.take(10)

[1 .. 10]
|> Seq.windowed(3)

//---FILTERING---
[1 .. 10]
|> Seq.filter(fun x -> x % 2 = 0)

["Dog";"Cat";"Fish"]
|> Seq.filter(fun x -> x.Contains("a"))

//---SORTING---
["Dog";"Cat";"Fish"]
|> Seq.sort

["Dog",6;"Cat",3;"Fish",1]
|> Seq.sortBy(fun (x,y) -> y)

//---MAPPING---
[1 .. 10]
|> Seq.map(fun x -> x + 1)

["Dog";"Cat";"Fish"]
|> Seq.map(fun x -> x + " of doom")

["Dog",6;"Cat",3;"Fish",1]
|> Seq.map(fun (x,y) -> x)

[1 .. 10]
|> Seq.mapi(fun idx x -> idx + x)

//---AGGREGATING---
[1 .. 10]
|> Seq.length

[1 .. 10]
|> Seq.map(fun x -> float x)
|> Seq.average

["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.countBy(fun (x,y) -> x)

["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.sumBy(fun (x,y) -> y)

[1 .. 10]
|> Seq.reduce(fun acc x -> acc + x)

[1 .. 10]
|> Seq.fold(fun acc x -> acc + x) 100

//---GROUPING---
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,y) -> x)

["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,y) -> x)
|> Seq.map(fun (a,b) -> a, b|> Seq.length)

["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,y) -> x)
|> Seq.map(fun (a,b) -> a, b|> Seq.map(fun (x,y) -> y) |> Seq.sum)

//---MERGING---
let seq1 = ["Dog";"Cat";"Fish"]
let seq2 = [6;3;1]
Seq.zip seq1 seq2

let seq3 = ["Dog",6;"Cat",3;"Fish",1]
let seq4 = ["Dog",2;"Fish",8;"Dog",3]
Seq.append seq3 seq4

//---PARALLEL---
//Paket: Add Nuget Package FSharp.Collections.ParallelSeq

#r "packages/FSharp.Collections.ParallelSeq/lib/net40/FSharp.Collections.ParallelSeq.dll"
open FSharp.Collections.ParallelSeq

let isPrime n = 
    let upperBound = int (sqrt (float n))
    let hasDivisor =     
        [2..upperBound]
        |> List.exists (fun i -> n % i = 0)
    not hasDivisor
let nums = [|1..500000|]

let start1 = System.DateTime.Now
let finalDigitOfPrimes = 
        nums 
        |> Seq.filter isPrime
        |> Seq.groupBy (fun i -> i % 10)
        |> Seq.map (fun (k, vs) -> (k, Seq.length vs))
        |> Seq.toArray 
let end1 = System.DateTime.Now

printfn "serial: %A" (end1 - start1)

let start2 = System.DateTime.Now
let parallelFinalDigitOfPrimes = 
        nums 
        |> PSeq.filter isPrime
        |> PSeq.groupBy (fun i -> i % 10)
        |> PSeq.map (fun (k, vs) -> (k, Seq.length vs))
        |> PSeq.toArray 
let end2 = System.DateTime.Now

printfn "parallel: %A" (end2 - start2)








