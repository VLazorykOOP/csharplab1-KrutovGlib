// See https://aka.ms/new-console-template for more information

using System.Data;

static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("volume = ");
    string? volume = Console.ReadLine();
    double V = 0; 
    if (volume != null) V = Double.Parse(volume);
    double rebs = Math.Pow(V, 1.0 / 3.0);
    Console.WriteLine("Reeb = " + rebs);
}

static void task2()
{
    Console.WriteLine("Task2 !");
    Console.Write("Number = ");
    string? str = Console.ReadLine();
    int number = 0;
    if (str != null && str.Length == 2) {
        number = Convert.ToInt32(str); 
    } else
    {
        Console.WriteLine("Inputs number larger then 2.");
        return;
    }
    int firstnum = number / 10;
    int secondnum = number % 10;
    int sum = firstnum + secondnum;
    if(sum % 2 != 0)
    {
        Console.WriteLine("The sum of the numbers is odd. Sum = " + sum);//непарна
    } else
    {
        Console.WriteLine("The sum of the numbers is even. Sum = " + sum);//парна
    }
}

static void task4()
{
    Console.Write("input Date (YYYY-MM-DD) = ");
    string inputDate = Console.ReadLine();

    Console.Write("Input n = ");
    string InputDay = Console.ReadLine();

    if(DateTime.TryParse(inputDate, out DateTime startDate) && int.TryParse(InputDay, out int days))
    {
        DateTime resultDate = startDate.AddDays(days);
        Console.WriteLine($"Unknown date after {days} days will be {resultDate.ToShortDateString()}"); ;
    }
    else
    {
        Console.WriteLine("incorrect data.");
    }
}

static void task5()
{
    Console.Write("Input first integer number = ");
    string input1 = Console.ReadLine();
    int firstNum = Convert.ToInt32(input1);
    Console.Write("Input second integer number = ");
    string input2 = Console.ReadLine();
    int secondNum = Convert.ToInt32(input2);
    
    int sum = firstNum + secondNum;

    int result = (int)Math.Pow(sum, 2);

    Console.WriteLine($"The result of raising two integer numbers to the power of 2 = {result}");
}

static void task6()
{
    Console.Write("Input first number = ");
    string input1 = Console.ReadLine(); 
    double a = Convert.ToDouble(input1);

    Console.Write("Input first second = ");
    string input2 = Console.ReadLine();
    double b = Convert.ToDouble(input2);

    double result = (5 + (b / (Math.Pow(b, 2) + 1))) + (a - b) * (1 / (a + b));

    Console.WriteLine($"Result of equation = {result}");
}
Console.WriteLine("Lab 1 ! 10 Variant");


Console.Write("""
    First task -> 1
    Second task -> 1
    Third task -> 1
    Fourth task -> 1
    Fifth task -> 1
    Sixth task -> 1
    Input your choise = 
    """);

string str = Console.ReadLine();
int choise = Convert.ToInt32(str);

switch (choise)
{
    case 1: task1(); break; 
    case 2: task2(); break;
    case 3: break;
    case 4: task4(); break;
    case 5: task5(); break;
    case 6: task6(); break;
}


