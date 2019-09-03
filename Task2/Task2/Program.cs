using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("------\nThis Program will give the sum total of 5 prices\n-----\n");    //Program Intro
            for (int i = 1;i <= 5;i++) {
                Console.WriteLine($"Enter the price of item {i}: ");
                double price = double.Parse(Console.ReadLine());
                total += price;
            }
            //double sum = Math.Round(total,2);
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
