using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2(x – 3) + x = 12               * x = 6
            */ 
            int x = 6;
            Console.WriteLine("find x for:\n  2(x – 3) + x = 12\n");
            Console.WriteLine("your guess: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == x) {Console.WriteLine("correct");}
            else {Console.WriteLine("incorrect");}
            Console.ReadKey();


        }
    }
}
