using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Iterators_seminar_04
{
    class TeenAge
    {
        int begin = 12;
        int number;
        public TeenAge(int number)
        { this.number = number; }

        public IEnumerable TeenIterator()
        {
            for (int i = begin; i < begin + number; i++)
            {
                if (i > 18) yield break;
                yield return $"{i} is teen age";
            }
        }


    /*    public IEnumerator GetEnumerator()
        {
            for( int i= begin; i < begin + number; i++)
            {
                if (i > 18) yield break;
                yield return $"{i} is teen age";
            }
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            do {

                TeenAge obj = new TeenAge(15);
                foreach( string el in obj.TeenIterator())
                {
                    Console.WriteLine(el);
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
