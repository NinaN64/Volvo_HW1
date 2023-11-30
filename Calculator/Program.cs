namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator instructions:");
            Console.WriteLine("Enter two numbers and an operation\nAvailable operations: +, -, *, /, ^, !");

            int First_Number = 0;
            int Second_Number = 0;
            string Operation;

            while(true)
            {
                //Number Inputs
                Console.WriteLine("\nFirst number: ");
                First_Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number: ");
                Second_Number = Convert.ToInt32(Console.ReadLine());

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
                    
            }
        }

        static int Factorial(int x)
        {
            int ResaultNumber = 1;
            for(int  i = 1; i <= x; i++)
            {
                ResaultNumber = ResaultNumber * i;               
            }
            return ResaultNumber;
        }
        static int Exponentiation(int x)
        {
            int ResaultNumber = x;
            Console.WriteLine("Exponentiation number:");
            int ExpNumber = Convert.ToInt32(Console.ReadLine());
            for(int  i = 1; i < ExpNumber; i++)
            {
                ResaultNumber = ResaultNumber * x;
            }
            return ResaultNumber;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static int Multiplication(int x, int y)
        {
            return x * y;
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Subtraction(int x, int y)
        {
            return x - y;
        }
    }
}
