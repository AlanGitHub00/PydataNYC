
//---SELECTING---
//I Do: create an sequence from 1 to 10 and selects the 3rd element
[1 .. 10].[3]
//You Do: create an sequence from 1 to 100 and selects the 41st element

//I Do: create an sequence from 1 to 10 and selects the 3rd through 6th element
[1 .. 10].[3..6]
//You Do: create an sequence from 1 to 100 and selects the 41st through 54th element

//I Do: create an sequence from 1 to 10 and selects the 1st element
[1 .. 10]
|> Seq.head
//You Do: create an sequence from 1 to 100 and selects the 1st element

//I Do: create an sequence from 1 to 10 and selects all elements but the 1st
[1 .. 10]
|> Seq.tail
//You Do: create an sequence from 1 to 100 and selects all elements but the 1st

//I Do: create an sequence from 1 to 10 and selects the top 3
[1 .. 10]
|> Seq.take(3)
//You Do: create an sequence from 1 to 100 and selects the top 11

//I Do: create an sequence from 1 to 10 and creates a sequence of rolling windows of 3 elements
[1 .. 10]
|> Seq.windowed(3)
//You Do: create an sequence from 1 to 100 and creates a sequence of rolling windows of 10 elements

//---FILTERING---
//I Do: create an sequence from 1 to 10 and filters even numbers
[1 .. 10]
|> Seq.filter(fun x -> x % 2 = 0)
//You Do: create an sequence from 1 to 100 and filters numbers divisible by 5

//I Do: create an sequence of three pets and filters any that contains an 'a'
["Dog";"Cat";"Fish"]
|> Seq.filter(fun x -> x.Contains("a"))
//You Do: create an sequence of three pets and filters any that contains an 'c'

//---SORTING---
//I Do: create an sequence of three pets and sorts them alphabetically
["Dog";"Cat";"Fish"]
|> Seq.sort
//I Do: create an sequence of three pets and sorts them alphabetically


//I Do: create an sequence of three tuples of (pet,count) and sorts them by the count
["Dog",6;"Cat",3;"Fish",1]
|> Seq.sortBy(fun (x,y) -> y)
//I Do: create an sequence of three tuples of (pet,count) and sorts them by the count

//---MAPPING---
//I Do: create an sequence from 1 to 10 and add each by one
[1 .. 10]
|> Seq.map(fun x -> x + 1)
//You Do: create an sequence from 1 to 100 and multiply each by 5

//I Do: create an sequence of monster names and add ' of doom' to each
//http://www.worldofmunchkin.com/duckofdoom/
["Dragon";"Ogre";"Duck"]
|> Seq.map(fun x -> x + " of doom")
//You Do: create an sequence of king names and add ' the third' to each

//I Do: create an sequence of three tuples of (pet,count) and selects just the name
["Dog",6;"Cat",3;"Fish",1]
|> Seq.map(fun (x,y) -> x)
//You Do: create an sequence of three tuples of (pet,count) and selects just the name

//I Do: create an sequence from 1 to 10 and adds the number with its index position
[1 .. 10]
|> Seq.mapi(fun idx x -> idx + x)
//You Do: create an sequence from 1 to 100 and multiplies the number with its index position

//---AGGREGATING---
//I Do: create an sequence from 1 to 10 and calculates the number of items
[1 .. 10]
|> Seq.length
//You Do: create an sequence from 1 to 100 and calculates the number of items

//I Do: create an sequence from 1 to 10 
//then turns the ints into floats
//then calculates the average
[1 .. 10]
|> Seq.map(fun x -> float x)
|> Seq.average
//You Do: create an sequence from 1 to 100
//then turns the ints into floats
//then calculates the average

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








