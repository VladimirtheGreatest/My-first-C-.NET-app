using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Better calculator 1.0");
            Console.WriteLine("The current time is " + DateTime.Now);

             Console.Write("Enter your number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            string Operator = Console.ReadLine();

            Console.Write("Enter your second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double Result = 0;

            if(Operator == "+")
            {
                Result = number1 + number2;
                Console.WriteLine(Result);
            } else if (Operator == "-")
            {
                Result = number1 - number2;
                Console.WriteLine(Result);
            } else if (Operator == "*")
            {
                Result = number1 * number2;
                Console.WriteLine(Result);
            } else if (Operator == "*")
            {
                Result = number1 / number2;
                Console.WriteLine(Result);
            } else
            {
                Console.WriteLine("Invalid operator");
            }

        }
    }
}
