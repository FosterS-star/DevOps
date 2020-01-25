using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevOps
{
    public static class Addition
    {
        public static void AdditionalTwoNumbers()
        {
            int firstNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            int secondNumber;
            Console.WriteLine("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber + secondNumber;
            Console.WriteLine("Result is: " + result);
            Thread.Sleep(1000);
            Thread.Sleep(1000);

        }       // added comment to break application

        public static void SubtractTwoNumbers()
        {
            int firstNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            int secondNumber;
            Console.WriteLine("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber - secondNumber;
            Console.WriteLine("Result is: " + result);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
        }
    }
}
