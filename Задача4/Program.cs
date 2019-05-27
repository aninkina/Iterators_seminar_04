using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача4
{
    class Even : IEnumerable
    {
        int Nmin;
        int Nmax;
        public Even ( int Nmin, int Nmax)
        {
            if (Nmin > Nmax) throw new Exception("eerrror");
            this.Nmin = Nmin;
            this.Nmax = Nmax;
        }
        public IEnumerator GetEnumerator()
        {
            for( int i = Nmin; i < Nmax; i++)
            {
                if( IsNumberPrime(i))
                {
                    yield return i;
                }
            }
        }

        public static bool IsNumberPrime( int number)
        {
            for( int i =2; i <= Math.Sqrt(number+5); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do {
                Even obj = new Even(10, 20);
                foreach( int el in obj)
                {
                    Console.WriteLine(el);
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
