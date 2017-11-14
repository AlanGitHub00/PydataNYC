//Welcome to FSharp!
//This is a comment
//To execute a command, highlight the line and hit ALT + ENTER


//---ASSIGN A VALUE---
//I Do: add 3 and 4 and assign it to a value called 'lucky'
let lucky = 3 + 4
//You Do: add 8 and 7 and assign it to a value called 'unlucky'

//---CREATE A FUNCTION---
//I Do: create a function named 'add' that takes two ints and adds them together
let add x y = x + y
//You Do: create a function named 'multiply' that takes two ints and adds them together

//---CREATE A SEQUENCE---
//I Do: create a Sequence named 'firstTen' that contains the numbers 1 to 10
let firstTen = [1 .. 10]
//You Do: create a Sequence named 'firstHundred' that contains the numbers 0 to 100

//---CREATE A LAMBDA---
//I Do: create a Sequence that contains the numbers 1 to 10 then create a lambda that adds 1 to each number
[1 .. 10]
|> Seq.map(fun i -> i + 1)
//You Do: create a Sequence that contains the numbers 0 to 100 then create a lambda that multiplies 2 to each number

//---CHAINING LAMBDAS---
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
type Person = {Name:string;Age:float;Gender:Gender}
let jamie = {Name="Jamie";Age=42.5;Gender=Male}
//You Do:create a record type of a Pet Toy that has a name(string), rating(float), and Pet(Pet)
//then create an instance of that type named 'Busy Bone', 4.8 rating, and is for a Dog

//---CREATE A TUPLE---
//I Do: create a tuple called of 'Jamie' and '42'
let jamie = "Jamie",42
//You Do:create a tuple called 'YourName' and '24'


















