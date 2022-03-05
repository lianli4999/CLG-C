// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("What is the first number?");
    var firstInput = Console.ReadLine();

    if (firstInput == "X")
    {
        break;
    }

    var numOne = double.Parse(firstInput);
    Console.WriteLine("What is the second number?");
    var numTwo = double.Parse(Console.ReadLine());

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("'+': Addition = add both numbers");
    Console.WriteLine("'/': Divide = divide the first number by the second");
    Console.WriteLine("'-': Subtraction = subtract the first number by the second");
    Console.WriteLine("'^': Power = first number to the power of second number");
    Console.WriteLine("X: Exit");

    var userInput = Console.ReadLine();

    // exit the code if a user inputs X
    if (userInput == "X")
    {
        break;
    }

    mainProgram(numOne, numTwo, userInput);

}




static double addition(double numOne, double numTwo)
{
    return numOne + numTwo;
    //Console.WriteLine($"{numOne+numTwo}");
    //j=false; this has to be in the main to work
}

static double division(double numOne, double numTwo)
{
    return numOne / numTwo;
    //Console.WriteLine($"{numOne/numTwo}");
}

static double subtraction(double numOne, double numTwo)
{
    return numOne - numTwo;
    //Console.WriteLine($"{numOne-numTwo}");
}

static double power(double numOne, double numTwo)
{
    return Math.Pow(numOne, numTwo);
    //Console.WriteLine($"{Math.Pow(numOne, numTwo)}");
}



static void mainProgram(double numOne, double numTwo, string userInput)
{
    //var j=true;
    // respond to the user command
    switch (userInput)
    {
        case "+":
            var resultAddition = addition(numOne, numTwo);
            //Console.WriteLine($"{numOne+numTwo}");
            Console.WriteLine(resultAddition);
            break;
        case "/":
            var resultDivision = division(numOne, numTwo);
            Console.WriteLine(resultDivision);
            break;
        case "-":
            var resultSubtraction = subtraction(numOne, numTwo);
            Console.WriteLine(resultSubtraction);
            break;
        case "^":
            var resultPower = power(numOne, numTwo);
            Console.WriteLine(resultPower);
            break;
        default:
            Console.WriteLine("I didn't recognise that command, please try again");

            break;
    }
}