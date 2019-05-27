using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Задача6
{
    class FileLines : IEnumerable
    {
        public FileLines(string path)
        {
            this.path = path;
            reader = new StreamReader(path);
        }

        string path;
        StreamReader reader;

        public IEnumerator GetEnumerator()
        {

            return new FileEnumerator(reader);
        }


        ~FileLines()
        {
            reader?.Close();
        }

    }
    class FileEnumerator : IEnumerator
    {
        StreamReader _lineReader;
        string currentStr;

        public FileEnumerator(StreamReader _lineReader)
        {
            if (_lineReader is null) throw new Exception();
            this._lineReader = _lineReader;
        }

        public bool MoveNext()
        {
            if ((currentStr = _lineReader.ReadLine()) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            if (_lineReader != null)
            {
                _lineReader.BaseStream.Position = 0;
            }
        }

        public object Current => currentStr;
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                FileLines obj = new FileLines(@"C:\Users\computer\Desktop\discra\dz_4\Task 3\pics\new.txt");
                foreach( string el in obj)
                {
                    Console.WriteLine(el);
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
