using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 10) continue;

                Console.WriteLine(i);
            }

            Console.ReadKey();
        }



    }
}

