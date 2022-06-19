using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    internal class UC3
    {
        public void Comparing()
        { 
        int x1 = 2;
        int y1 = 3;

        int x2 = 4;
        int y2 = 1;

        int x11 = 3;
        int y11 = 4;

        int x12 = 4;
        int y12 = 5;

        int x = (x2 - x1) * (x2 - x1);
        int y = (y2 - y1) * (y2 - y1);
        int z = x + y;
       
          
        Console.WriteLine("length of 1st line: " +Math.Sqrt(z));

        int u = (x11 - x12) * (x11 - x12);
        int v = (y11 - y12) * (y11 - y12);
        int w = u + v;


        Console.WriteLine("length of the 2nd line: " + Math.Sqrt(w));


            if (Math.Sqrt(z).CompareTo(Math.Sqrt(w)) == 1)
            {
                Console.WriteLine("1st line is greater than 2nd line");
            }
            else if((Math.Sqrt(z).CompareTo(Math.Sqrt(w)) == 1))
            {
                Console.WriteLine("2nd one is greater than 1st line");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }


        }
    }
}
