using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            c1++;
            Counter c2 = c1;
            Counter c3 = new Counter();
            c3++;

            Console.WriteLine(c1.Count);
            Console.WriteLine(c2.Count);
            Console.WriteLine(c3.Count);
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == c3);
            Console.WriteLine(c2 == c3);
            Console.WriteLine(object.ReferenceEquals(c1, c2));
            Console.WriteLine(object.ReferenceEquals(c1, c3));
            Console.WriteLine(object.ReferenceEquals(c2, c3));
        }
    }
}
