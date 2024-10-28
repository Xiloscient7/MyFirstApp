// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;


class Calculator
{
    public static double DoOperation (double num1, double num2, string op)
    {
        double result = double.NaN;
        
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;

            default:
                break;

        }    

        return result;

    }

}


class Program
{
    static void Main (string[] args)
    {
        bool endApp = false;

        //basic intro
        Console.WriteLine("My Second Program in Ten Years Calculator this time featuring the use of Classes!!!\r");
        Console.WriteLine("-----------------------------------------------------------------------------------\n");

        while (!endApp)
        {

            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            Console.WriteLine("Enter a number and press enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("Non-Valid input.  Please enter a number and press enter: ");
                numInput1 = Console.ReadLine();
            }

            Console.WriteLine("Enter another number and press enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("Non-Valid input.  Please enter a number and press enter: ");
                numInput2 = Console.ReadLine();
            }

            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");

            string? op = Console.ReadLine();

            if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
            {
                Console.WriteLine("Error.  Unrecognized input.");
            }
            else
            {
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                { Console.WriteLine("Exception occured trying to do the math. \n - Details: " + e.Message); }   
            }

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Press 'n' and Enter to close the application or any other key and Enter to go again!: ");
            
            if (Console.ReadLine() == "n") endApp=true;

            Console.WriteLine("\n");

        }

        return;

    }


}


/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Yup.  Ok, pretty simple.  It's just a cout command");
Console.WriteLine("So far this is a much easier and simplier version of what I am used too.");

double num1 = 0;
double num2 = 0;

//basic prompt
Console.WriteLine("My First Program in Ten Years Calculator lol\r");
Console.WriteLine("--------------------------------------------\n");

//ask for first number input
Console.WriteLine("Enter an integer and press enter");
num1 = Convert.ToDouble(Console.ReadLine());

//ask for second number input
Console.WriteLine("Enter another integer and press enter");
num2 = Convert.ToDouble(Console.ReadLine());

//ask for first input
Console.WriteLine("Enter what operation you want to perform from the list below:");
Console.WriteLine("\ta - Addition");
Console.WriteLine("\ts - Subtraction");
Console.WriteLine("\tm - Multiplication");
Console.WriteLine("\td - Division");
Console.Write("What operation do you want to perform?");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result is: {num1} + {num2} =  " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result is: {num1} - {num2} =  " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result is: {num1} * {num2} =  " + (num1 * num2));
        break;
    case "d":
        // fix a diving by zero exception
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non zero divisor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        
        Console.WriteLine($"Your result is: {num1} / {num2} =  " + (num1 / num2));
        break;
}



// give the users a moment to see the results before closing when prompted
Console.WriteLine("Press any key to close the super basic one operation calculator application....");
Console.ReadKey();

*/
