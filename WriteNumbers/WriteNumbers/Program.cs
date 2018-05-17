using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WriteNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                var thread = new Thread(WriteNumber);
                thread.Start(i);
            }
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }

        static void WriteNumber(Object number)
        {
            int i = 0;
            try
            {
                i = (int)number;
            }
            catch(Exception e)
            {
                i = 9999;
                Console.WriteLine("Not a correct number");
            }
            Console.WriteLine("Write number: " + i);
        }
    }
}
