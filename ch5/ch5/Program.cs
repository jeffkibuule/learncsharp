using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ch5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            int[] big = new int[100000000];
            Console.WriteLine("Initializing");
            sw.Start();
            var r = new Random(0);
            for (int i = 0; i < big.Length; i++)
            {
                big[i] = r.Next(big.Length);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString("s\\.f"));
            Console.WriteLine();

            Console.WriteLine("Searching");
            for (int i = 0; i < 6; ++i)
            {
                int searchFor = r.Next(big.Length);
                sw.Reset();
                sw.Start();
                int index = Array.IndexOf(big, searchFor);
                sw.Stop();
                Console.WriteLine("Index: {0}", index);
                Console.WriteLine("Time: {0:s\\.ffff}", sw.Elapsed);
            }
            Console.WriteLine();

            Console.WriteLine("Sorting");
            sw.Reset();
            sw.Start();
            Array.Sort(big);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.ToString("s\\.f"));
            Console.WriteLine();

            Console.WriteLine("Searching (binary)");
            for (int i = 0; i < 6; ++i)
            {
                int searchFor = r.Next(big.Length);
                sw.Reset();
                sw.Start();
                int index = Array.BinarySearch(big, searchFor);
                sw.Stop();
                Console.WriteLine("Index: {0}", index);
                Console.WriteLine("Time: {0:s\\.fffffff}", sw.Elapsed);
            }
            Console.WriteLine();
        }
    }
}
