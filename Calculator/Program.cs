using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;
            
            string userAnswer;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter you first number.");

            num1 = Convert.ToInt32(Console.ReadLine());

         
            Console.WriteLine("Please enter you second number.");

                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What tpye of operation would you like to perform?");

                Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'd' for Division or any other key for multiplication.");

                userAnswer = Console.ReadLine();

                if (userAnswer == "a")
                {
                    result = num1 + num2;
                }
                else if
                (userAnswer == "s")
                {
                    result = num1 - num2;
                }
                else if
                (userAnswer == "d")
                {
                    result = num1 / num2;
                }
                else
                {
                    result = num1 * num2;
                }
                Console.WriteLine("The result is " + result);
                Console.WriteLine("Thank you for using the program!");
                Console.ReadKey();
        
        }
    }
}
