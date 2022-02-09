// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is the first number?");
var numOne = double.Parse(Console.ReadLine());
Console.WriteLine("What is the second number?");
var numTwo = double.Parse(Console.ReadLine());

Console.WriteLine("What would you like to do?");
Console.WriteLine("'+': Addition = add both numbers");
Console.WriteLine("'/': Divide = divide the first number by the second");
Console.WriteLine("'-': Subtraction = subtract the first number by the second");
Console.WriteLine("'^': Power = first number to the power of second number");
Console.WriteLine("X: Exit");

var userInput = Console.ReadLine();

mainProgram(numOne, numTwo, userInput);


static void addition(double numOne, double numTwo)
{
    //return numOne+numTwo;
    Console.WriteLine($"{numOne+numTwo}");
    //j=false; this has to be in the main to work
}

static void division(double numOne, double numTwo)
{
    //return numOne/numTwo;
    Console.WriteLine($"{numOne/numTwo}");
}

static void subtraction(double numOne, double numTwo)
{
   //return numOne-numTwo;
    Console.WriteLine($"{numOne-numTwo}");
}			

static void power(double numOne, double numTwo)
{
    //return Math.Pow(numOne, numTwo);
    Console.WriteLine($"{Math.Pow(numOne, numTwo)}");
}



static void mainProgram(double numOne, double numTwo, string userInput)
{
var j=true;

while (j)
    {
        
        // exit the code if a user inputs X
        if (userInput == "X")
        {
            break;
        }

        // respond to the user command
        switch (userInput)
        {
            case "+":
                addition(numOne, numTwo);
                //Console.WriteLine($"{numOne+numTwo}");
                j=false;
                break;
            case "/":
                division(numOne, numTwo);
                j=false;
                break;
            case "-":
                subtraction(numOne, numTwo);
                j=false;
                break;
            case "^":
                power(numOne, numTwo);
                j=false;
                break;
            default:
                Console.WriteLine("I didn't recognise that command, please try again");
                break;
        } break;
    }
}       