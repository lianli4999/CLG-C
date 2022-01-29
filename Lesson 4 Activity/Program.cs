// See https://aka.ms/new-console-template for more information

// generate a number from 1 to 10
int num = new Random().Next(1,10);

// ask user to guess the number
Console.WriteLine("Game 1! Please guess a number between 1 and 10");

var input = int.Parse(Console.ReadLine());

if (input == num)
{
    // determine whether the user's guess was correct and writes the result out to the user
    Console.WriteLine($"Your guess of {num} was correct");
}
else
{
    Console.WriteLine($"Your guess was {input}. The correct number was {num}");
}

// user has 3 guesses

int secondNum = new Random().Next(1,10);


var i=1;
int n=3;
while(i<=3)
{
    Console.WriteLine("Game 2! Please guess a number between 1 and 10");
    var secondInput = int.Parse(Console.ReadLine());

    if(secondNum == secondInput)
    {
        Console.WriteLine($"Your guess of {secondNum} was correct");
        break;
    }

//hint
    else if(secondInput > secondNum)
    {
        Console.WriteLine($"Your guess of {secondInput} is too high");

        if(Math.Abs(secondInput - secondNum) <=2)
        {
            Console.WriteLine($"Your guess of {secondInput} is getting hotter");
        }
        else
        {
           Console.WriteLine($"Your guess is getting colder"); 
        }
    }

//hint
    else if (secondInput < secondNum)
    {
        Console.WriteLine($"Your guess of {secondInput} is too low");
        
        if(Math.Abs(secondInput - secondNum) <=2)
        {
            Console.WriteLine($"Your guess of {secondInput} is getting hotter");
        }
        else
        {
           Console.WriteLine($"Your guess is getting colder"); 
        }
    }

//hint
    else if (Math.Abs(secondInput - secondNum) >=3)
    {
        Console.WriteLine($"Your guess of {secondInput} is cold");
    }
    n--;
    Console.WriteLine($"You have {n} chances left.");
    // Console.WriteLine($"Loop {i}");
    i++;

}




// user has infinite guesses
// program stops when user guesses the correct answer
// specify if correct number is even or odd

int thirdNum = new Random().Next(1,10);


var j=true;
while(j)
{
    Console.WriteLine("Game 3! Please guess a number between 1 and 10");
    var thirdInput = int.Parse(Console.ReadLine());

    if(thirdNum == thirdInput)
    {
        Console.WriteLine($"Your guess of {thirdNum} was correct");
        break;
    }

    else
    {
        Console.WriteLine($"Your guess of {thirdInput} was incorrect, please try again");
        
//hints
        if (thirdInput%2==1 && thirdNum%2==0)
        {
            Console.WriteLine($"The correct number is even");
        }
        else if (thirdInput%2==0 && thirdNum%2==1)
        {
            Console.WriteLine($"The correct number is odd");
        }
    }
}