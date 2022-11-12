// See https://aka.ms/new-console-template for more information
//EXERCISE 1!
using System.ComponentModel;

Console.WriteLine("Hey there! You look like you could use a break, let's play a game!");
Console.WriteLine("--------------------------------");

Console.WriteLine("So new friend, what's your name?");
var name = Console.ReadLine();
Console.WriteLine($"That's a cool name, {name}! Good to meet ya!");
Console.WriteLine();

Console.WriteLine("Do you like music? I LOVE all types of music! What're you currently listening to?");
var music = Console.ReadLine();
Console.WriteLine($"Sweet! {music} sounds like some good stuff!");
Console.WriteLine();

Console.WriteLine("Do you have a favorite color? Mine is pink, but I also love black!");
var color = Console.ReadLine();
Console.WriteLine($"{color} is so pretty! I like that too!");
Console.WriteLine();

Console.WriteLine("Do ya like animals? Have a favorite animal? I love Owls!");
var animal = Console.ReadLine();
Console.WriteLine($"Good choice! I would own a farm of animals if I could.");
Console.WriteLine();

Console.WriteLine("Do you work? What do you do? I'm a Teaching Assistant for TrueCoders!");
var job = Console.ReadLine();
Console.WriteLine($"{job} sounds interesting!");
Console.WriteLine();

Console.WriteLine("Do you have any hobbies you enjoy in your spare time? I love to code and spend time with my family.");
var hobby = Console.ReadLine();
Console.WriteLine($"Cool! {hobby} sounds really nice.");
Console.WriteLine();

Console.WriteLine($"Well, {name}, this has been real fun! Thanks for playing along. :)");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
Console.WriteLine();



//EXERCISE 2!
Console.WriteLine($"Hey {name}! Let's do some math!");
Console.WriteLine("------------------------");
Console.WriteLine();

//Multiply
Console.WriteLine("What is the first number you would like to multiply?");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And the second number?");
var num2 = Convert.ToInt32(Console.ReadLine());

var multiAnswer = num1 * num2;
Console.WriteLine($"Your answer is: {multiAnswer}");
Console.WriteLine();

//Addition 
Console.WriteLine("What is the first number you would like to add?");
var num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And the second number?");
var num4 = Convert.ToInt32(Console.ReadLine());

var addAnswer = num3 + num4;
Console.WriteLine($"Your answer is: {addAnswer}");
Console.WriteLine();

//Subtraction
Console.WriteLine("What is the first number you would like to subtract?");
var num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And the second number");
var num6 = Convert.ToInt32(Console.ReadLine());

var subAnswer = num5 - num6;
Console.WriteLine($"Your answer is: {subAnswer}");
Console.WriteLine();

//Divide
Console.WriteLine("What is the first number you would like to divide?");
var num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And the second number?");
var num8 = Convert.ToInt32(Console.ReadLine());

var divAnswer = num7 / num8;
Console.WriteLine($"Your answer is: {divAnswer}");
Console.WriteLine();

Console.WriteLine($"Alright, {name}, thanks for doing some math!");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine();

//EXERCISE 3!
Console.WriteLine($"Well, well, hello AGAIN {name}!!! Here's our last math task which I will do....");
Console.WriteLine("-------------------------------");

 static int Add(int num1, int num2, int num3)
 {
    return num1 + num2 + num3;
 }
var answerAdd = Add(1, 1, 1);;
Console.WriteLine($"We're going to ADD 1 + 1 + 1 and the answer is: {answerAdd}");
Console.WriteLine();

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}
var answerSub = Subtract(8, 5);
Console.WriteLine($"We're going to SUBTRACT 8 - 5 and the answer is: {answerSub}");
Console.WriteLine();

static int Multiply(int num1, int num2)
{
    return num1 * num2;
}
var answerMulti = Multiply(24, 13);
Console.WriteLine($"We're going to MULTIPLY 24 * 13 and the answer is: {answerMulti}");
Console.WriteLine();

static int Divide(int num1, int num2)
{
    return num1 / num2;
}
var answerDiv = Divide(6, 8);
Console.WriteLine($"We're going to DIVIDE 6 / 8 and the answer is: {answerDiv}");
Console.WriteLine();