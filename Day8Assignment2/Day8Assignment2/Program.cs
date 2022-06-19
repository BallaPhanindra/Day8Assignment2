using System;

namespace Day8Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=======UC1=========");
            UC1 u1 = new UC1();
            u1.length();

            Console.WriteLine("=======UC2=========");
            UC2 u2 = new UC2();
            u2.ComparingLines();

            UC3 u3 = new UC3();
            u3.Comparing();
        }
    }
}
