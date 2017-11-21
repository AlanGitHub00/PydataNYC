//Welcome to FSharp!
//This is a comment
//To execute a command, highlight the line and hit ALT + ENTER


//---ASSIGN A VALUE---
//I Do: add 3 and 4 and assign it to a value called 'lucky'
let lucky = 3 + 4
printfn "lucky is %i" lucky
//You Do: add 8 and 7 and assign it to a value called 'unlucky'

//---CREATE A FUNCTION---
//I Do: create a function named 'add' that takes two ints and adds them together
let add x y = x + y
add 3 4
//You Do: create a function named 'multiply' that takes two ints and adds them together

//---CREATE A SEQUENCE---
//I Do: create a Sequence named 'firstTen' that contains the numbers 1 to 10
let firstTen = [1 .. 10]
printfn "The first 10 numbers are %A" firstTen
//You Do: create a Sequence named 'firstHundred' that contains the numbers 0 to 100

//---USE A HIGH ORDER FUNCTION WITH A NAMED FUNCTION---
//I Do: create a function that takes in an int and adds 1 to it
//then create a Sequence that contains the numbers 1 to 10
//then use the map high-order function to apply the named function to the sequence
let addOne x = x + 1
[1 .. 10]
|> Seq.map(addOne)
//You Do: create a function that takes in an int and multiplies it by 10
//then create a Sequence that contains the numbers 0 to 100
//then use the map high-order function to apply the named function to the sequence


//---USE A HIGH ORDER FUNCTION WITH A LAMBDA---
//I Do: create a Sequence that contains the numbers 1 to 10 then create a lambda that adds 1 to each number
[1 .. 10]
|> Seq.map(fun i -> i + 1)
//You Do: create a Sequence that contains the numbers 0 to 100 then create a lambda that multiplies 2 to each number

//---CHAINING HIGH ORDER FUNCTIONS---
//I Do: create a Sequence that contains the numbers 1 to 10 
//then create a lambda that adds 1 to each number 
//then create a lambda that turns the ints into floats
//then create a lambda that sums all of the numbers up
[1 .. 10]
|> Seq.map(fun i -> i + 1)
|> Seq.map(fun i -> float i)
|> Seq.sum
//You Do: create a Sequence that contains the numbers 0 to 100 
//then create a lambda that turns the ints into floats
//then create a lambda that averages all of the numbers (hint: Seq.average)

//--CREATING A DISCRIMINATED UNION
//I Do: create a discriminated union for gender (male and female)
type Gender =
| Male
| Female
//You Do: create a discriminated union for pet type (dog, cat, and fish)

//---CREATING A RECORD TYPE---
//I Do: create a record type of a person that has name(string), age(float), gender(Gender)
//then create an instance of that type named 'Jamie' aged 42.5, and is a male
type Person = {Name:string; Age:float; Gender:Gender}
let jamie = {Name="Jamie"; Age=42.5; Gender=Male}
printfn "Jamie's information %A" jamie
//You Do:create a record type of a Pet Toy that has a name(string), rating(float), and Pet(Pet)
//then create an instance of that type named 'Busy Bone', 4.8 rating, and is for a Dog

//---CREATE A TUPLE---
//I Do: create a tuple called jamieTuple of 'Jamie' and '42'
let jamieTuple = "Jamie", 42
printfn "Jamie's information %A" jamieTuple
//You Do:create a tuple called 'YourName' and '24'


















