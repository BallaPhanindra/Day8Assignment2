using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    internal class UC1
    {
        int x1 = 2;
        int y1 = 3;

        int x2 = 4;
        int y2 = 1;

        public void length()
        {
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            Console.WriteLine("length of the line: " + Math.Sqrt(z));

        }
    }
}
