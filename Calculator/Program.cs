namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator instructions:");
            Console.WriteLine("Enter two numbers and an operation\nAvailable operations: +, -, *, /, ^, !");

            double First_Number = 0;
            double Second_Number = 0;
            string Operation;

            while(true)
            {
                //Number Inputs
                Console.WriteLine("\nFirst number: ");
                First_Number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number: ");
                Second_Number = Convert.ToDouble(Console.ReadLine());

                //Operation Input
                Console.WriteLine("Operation: ");
                Operation = Console.ReadLine();
                switch(Operation)
                {
                    case "!":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Factorial(First_Number));
                        break;

                    case "^":
                        //Console.WriteLine("Result: ");
                        Console.WriteLine(Exponentiation(First_Number));
                        break;

                    case "/":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Division(First_Number, Second_Number));
                        break;

                    case "*":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Multiplication(First_Number, Second_Number));
                        break;

                    case "-":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Subtraction(First_Number, Second_Number));
                        break;

                    case "+":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Addition(First_Number, Second_Number));                     
                        break;                   
                }
                Console.WriteLine("Exit? (y/n)");
                if(Console.ReadLine() == "y")
                {
                    break;
                }
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
        static double Exponentiation(double x)
        {
            double ResaultNumber = x;
            Console.WriteLine("Exponentiation number:");
            double ExpNumber = Convert.ToInt32(Console.ReadLine());
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
