using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача5
{
    class IteratorClass: IEnumerator
    {
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            do {



                Console.WriteLine("esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
