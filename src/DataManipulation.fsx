
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
//You Do: create an sequence of three pets and filters any that contains a 'c'

//---SORTING---
//I Do: create an sequence of three pets and sorts them alphabetically
["Dog";"Cat";"Fish"]
|> Seq.sort
//I Do: create an sequence of three pets and sorts them decending alphabetically


//I Do: create an sequence of three tuples of (pet,count) and sorts them by the count
["Dog",6;"Cat",3;"Fish",1]
|> Seq.sortBy(fun (_,y) -> y)
//I Do: create an sequence of three tuples of (pet,count) and sorts them by the count decending

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
|> Seq.map(fun (x,_) -> x)
//You Do: create an sequence of three tuples of (pet,count) and selects just the name

//I Do: create an sequence from 1 to 10 and adds the number with its index position
[1 .. 10]
|> Seq.mapi(+) // equivalant to "Seq.mapi(fun idx x -> idx + x)"
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
|> Seq.averageBy(float) // equivalant to "Seq.map(fun x -> float x) |> Seq.average"
//You Do: create an sequence from 1 to 100
//then turns the ints into floats
//then calculates the average

//I Do: create an sequence of six tuples of (pet,count)
//then counts the number of times each pet is present
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.countBy(fun (x,_) -> x)
//You Do: create an sequence of five tuples of (pet,count)
//then counts the number of times each pet is present

//I Do: create an sequence of six tuples of (pet,count)
//then sums the number of total counts
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.sumBy(fun (_,y) -> y)
//You Do: create an sequence of five tuples of (pet,count)
//then sums the number of total counts

//I Do: create an sequence from 1 to 10 
//sum up a running, cumulative total
[1 .. 10]
|> Seq.reduce(+) // equivalant to "Seq.reduce(fun acc x -> acc + x)"
//You Do: create an sequence from 1 to 100
//sum up a running, cumulative total

//I Do: create an sequence from 1 to 10 
//sum up a running, cumulative total starting at 100
[1 .. 10]
|> Seq.fold(+) 100 // equivalant to "Seq.fold(fun acc x -> acc + x) 100"
//You Do: create an sequence from 1 to 100
//sum up a running, cumulative total starting at 200

//---GROUPING---
//I Do: create an sequence of six tuples of (pet,count)
//then group the tuples into sequences based on their name
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,_) -> x)
//You Do: create an sequence of five tuples of (pet,count)
//then group the tuples into sequences based on their name

//I Do: create an sequence of six tuples of (pet,count)
//then group the tuples into sequences based on their name
//then get the number that each name appears
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,_) -> x)
|> Seq.map(fun (a,b) -> a, b|> Seq.length)
//You Do: create a sequence of five tuples of (pet,count)
//then group the tuples into sequences based on their name
//then get the number that each name appears

//I Do: create a sequence of six tuples of (pet,count)
//then group the tuples into sequences based on their name
//then get the total of the count
["Dog",6;"Cat",3;"Fish",1;"Dog",2;"Fish",8;"Dog",3]
|> Seq.groupBy(fun (x,_) -> x)
|> Seq.map(fun (a,b) -> a, b |> Seq.sumBy(fun (_,y) -> y))
//You Do: create an sequence of six tuples of (pet,count)
//then group the tuples into sequences based on their name
//then get the total of the count


//---MERGING---
//I Do: create a sequence of three pet types
//then creat a sequence of three counts
//then 'zip' both sequences together to create a single sequence of tuples
let seq1 = ["Dog";"Cat";"Fish"]
let seq2 = [6;3;1]
Seq.zip seq1 seq2
//You Do: create a sequence of three sport types
//then create a sequence of three counts
//then 'zip' both sequences together to create a single sequence of tuples

//I Do: create ansequence of three tuples of (pet,count)
//then create a sequence of three tuples of (pet,count)
//the combine both sequences into a single six-item sequence
let seq3 = ["Dog",6;"Cat",3;"Fish",1]
let seq4 = ["Dog",2;"Fish",8;"Dog",3]
Seq.append seq3 seq4
//You Do: create ansequence of three tuples of (sport,count)
//then create a sequence of three tuples of (sport,count)
//the combine both sequences into a single six-item sequence

//---PARALLEL---
//Paket: Add Nuget Package FSharp.Collections.ParallelSeq

//I Do: show you that with immutabity, parallelizing long-running tasks is a snap
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

// Serial Final Digit of Primes
nums 
|> Seq.filter isPrime
|> Seq.groupBy (fun i -> i % 10)
|> Seq.map (fun (k, vs) -> (k, Seq.length vs))
|> Seq.toArray 

let end1 = System.DateTime.Now

printfn "serial: %A" (end1 - start1)

let start2 = System.DateTime.Now

// Parallel Final Digit of Primes
nums 
|> PSeq.filter isPrime
|> PSeq.groupBy (fun i -> i % 10)
|> PSeq.map (fun (k, vs) -> (k, Seq.length vs))
|> PSeq.toArray 

let end2 = System.DateTime.Now

printfn "parallel: %A" (end2 - start2)