using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace задача2
{
    class Rainbow
    {
        public IEnumerator GetEnumerator()
        {
            yield return "каждый ";
            yield return "охотник ";
            yield return "желает ";
            yield return "знать ";
            yield return "где ";
            yield return "сидит ";
            yield return "фазан ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Rainbow colors = new Rainbow();
                int i = 0;
                foreach (string color in colors)
                {
                    if (++i % 3 == 0) break;
                    Console.Write(color);
                }
                Console.WriteLine();
                //.. Второе обращение к тому же объекту:
                foreach (string color in colors)
                    Console.Write(color);
                Console.WriteLine();

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
