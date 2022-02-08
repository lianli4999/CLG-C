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

static double addition(double numOne, double numTwo)
{
    return numOne+numTwo;
}

static double division(double numOne, double numTwo)
{
    return numOne/numTwo;
}

static double subtraction(double numOne, double numTwo)
{
    return numOne-numTwo;
}			

static double power(double numOne, double numTwo)
{
    return Math.Pow(numOne, numTwo);
}



static void mainProgram(double numOne, double numTwo, string userInput)
{
while (true)
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
                break;
            case "/":
                division(numOne, numTwo);
                break;
            case "-":
                subtraction(numOne, numTwo);
                break;
            case "^":
                power(numOne, numTwo);
                break;
            default:
                Console.WriteLine("I didn't recognise that command, please try again");
                break;
        }
    }
}       