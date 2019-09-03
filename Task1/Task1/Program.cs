using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------\nThis Program can give the result of base^exponent\n-----\n");    //Program Intro
            Console.WriteLine("Please enter the Base value:"); 
            double num1 = double.Parse(Console.ReadLine());     //Gets the base value from user and converts
            Console.WriteLine("Please enter the Exponent value: ");
            int num2 = int.Parse(Console.ReadLine());           //Gets the exponent value from user and converts
            double result = Math.Pow(num1, num2);               //Does the math calculation
            Console.WriteLine($"{num1}^{num2} = {result}");     //Ouputs the result

        }
    }
}
