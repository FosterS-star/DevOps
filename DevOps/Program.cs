using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevOps
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
