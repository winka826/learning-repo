using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation;
            int result;

            Console.WriteLine("Hello, welcome to calculator");
            Console.WriteLine("Enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("What type of operation would you like to do?");
            System.Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, d for division.");
            
            operation = Console.ReadLine();

            if (operation == "a")
            {
                result = num1 + num2;
            }
            else if (operation == "s")
            {
                result = num1 - num2;
            }
            else if (operation == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            System.Console.WriteLine("Result is " + result);

            Console.ReadKey();
        }
    }
}