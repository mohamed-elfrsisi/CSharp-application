using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World lets begin");
            
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter Socend Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter The Operator: ");
            char Operator = Convert.ToChar(Console.ReadLine());
            
            switch (Operator)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"{num1} % {num2} = {num1 * num2}");
                    break;
                    
            }
        Console.WriteLine("press any key to exit...");
        Console.ReadKey();
        }
    }
}





