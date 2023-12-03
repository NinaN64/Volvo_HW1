﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator instructions:");
            Console.WriteLine("Enter two numbers and an operation\nAvailable operations: +, -, *, /, ^, !");

            double First_Number = 0;
            

            while(true)
            {
                //Number Inputs
                Console.WriteLine("\nFirst number: ");
                First_Number = Convert.ToDouble(Console.ReadLine());

                //string inputString = "2 + 2";

                /*for(int i = 0; i < inputString.Length; i++)
                {

                }*/

                Operations_Selecter(First_Number);
                
                Console.WriteLine("Exit? (y/n)");
                if(Console.ReadLine() == "y")
                {
                    break;
                }
            }
        }

        static void Operations_Selecter(double First_Number)
        {
        double Second_Number = 0;
        string Operation;
        //Operation Input
        Console.WriteLine("Operation: ");
        Operation = Console.ReadLine();
            if (Operation == "+" || Operation == "-" || Operation == "*" || Operation == "/" || Operation == "^" || Operation == "!")
            {
                switch (Operation)
                {
                    case "!":
                        Console.WriteLine("\n" + First_Number + Operation + " = " + Factorial(First_Number));
                        break;

                    case "^":
                        Console.WriteLine("Exponentiation number:");
                        double ExpNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n" + First_Number + Operation + ExpNumber + " = " + Exponentiation(First_Number, ExpNumber));
                        break;

                    case "/":
                        Console.WriteLine("Second number: ");
                        Second_Number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Result: ");
                        Console.WriteLine("\n" + First_Number + Operation + Second_Number + " = " + Division(First_Number, Second_Number));
                        break;

                    case "*":
                        Console.WriteLine("Second number: ");
                        Second_Number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Result: ");
                        Console.WriteLine("\n" + First_Number + Operation + Second_Number + " = " + Multiplication(First_Number, Second_Number));
                        break;

                    case "-":
                        Console.WriteLine("Second number: ");
                        Second_Number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Result: ");
                        Console.WriteLine("\n" + First_Number + Operation + Second_Number + " = " + Subtraction(First_Number, Second_Number));
                        break;

                    case "+":
                        Console.WriteLine("Second number: ");
                        Second_Number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Result: ");
                        Console.WriteLine("\n" + First_Number + Operation + Second_Number + " = " + Addition(First_Number, Second_Number));
                        break;
                }
            }
            else 
            {
                Console.WriteLine("You need to pick an existing operation!");
                Operations_Selecter(First_Number);
            }
        }

        static double Factorial(double x)
        {
            double ResaultNumber = 1;
            for(int  i = 1; i <= x; i++)
            {
                ResaultNumber = ResaultNumber * i;               
            }
            return ResaultNumber;
        }
        static double Exponentiation(double x, double ExpNumber)
        {
            double ResaultNumber = x;
            for(int  i = 1; i < ExpNumber; i++)
            {
                ResaultNumber = ResaultNumber * x;
            }
            return ResaultNumber;
        }

        static double Division(double x, double y)
        {
            return x / y;
        }

        static double Multiplication(double x, double y)
        {
            return x * y;
        }

        static double Addition(double x, double y)
        {
            return x + y;
        }

        static double Subtraction(double x, double y)
        {
            return x - y;
        }
    }
}
