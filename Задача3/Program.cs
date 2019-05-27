using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача3
{
    class Fibbonacci
    {
        int ak_1 = 0;
        int ak_2 = 1;


        public IEnumerable MyIterator(int limit)
        {
            int t;
            for( int i = 0; i< limit; i++)
            {
                t = ak_1 + ak_2;
                ak_1 = ak_2;
              yield return  ak_2 = t;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do {
                Fibbonacci obj = new Fibbonacci();
                Console.WriteLine($"first 10 elements in fib-i");
                foreach (int el in obj.MyIterator(10))
                {
                    Console.WriteLine(el);
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
