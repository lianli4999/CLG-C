// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is the initial deposit");
// var initialDeposit = Console.ReadLine();
// Console.WriteLine(initialDeposit.GetType()); 
    //returns system.string

var initialDeposit = int.Parse(Console.ReadLine());
// Console.WriteLine(initialDeposit.GetType());
    // returns system.int32

Console.WriteLine("What is the monthly interest rate");
var interestRate = double.Parse(Console.ReadLine());
var interestRateAsPercentage = interestRate/100;

Console.WriteLine("What is the number of months");
var months = int.Parse(Console.ReadLine());

var savings = initialDeposit * Math.Pow(1 + interestRateAsPercentage, months);
    // this gives compound interest calculations
Console.WriteLine($"Total Savings: ${Math.Round(savings,2)}");
    // Math.Round rounds to 2 decimals
    // Math.Ceiling rounds up to next int
