using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            double number = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("Print a number : " + number);
            Console.WriteLine("Add Numbers. Input 2 numbers, press enter after each Input : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your first input was: " +  num1 + " And your second input was " + num2);
            
            int sum = num1 + num2;
            Console.WriteLine("Sum of your inputs is: " + sum);

            int modulo = num1 % num2;
            Console.WriteLine("Modulo of your inputs is: " + modulo);

            Console.WriteLine("First number to the power of second number: " + Math.Pow(num1, num2));

            Console.WriteLine("Division of inputs. i.e. First Number / Second number: " + num1/ num2);

            num1++;
            Console.WriteLine("First input incremented by 1: " + num1);

            Console.Read();

        }
    }
}
