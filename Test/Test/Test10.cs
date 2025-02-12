using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test10
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                array[i] = input;
            }
            Array.Sort(array);
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
