using System;
using System.Collections;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            int num01;
            int num02;
            Console.Write("Enter a number to be divided: ");
            num01 = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter a number to be divide by: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            int v = (num01 / num02);
            Console.WriteLine(num01 + " divided by " + num02 + " is equal to  " + v);

            // wait for user to press a key
            Console.ReadKey();
            Console.WriteLine();
            goto Start; // Jump to start
        }
    }
}
