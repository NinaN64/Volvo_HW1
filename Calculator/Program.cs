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
                    case "+":
                        Console.WriteLine("Result: ");
                        Console.WriteLine(Addition(First_Number, Second_Number));                     
                        break;
                    //case "-":


                }
                    
            }
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
