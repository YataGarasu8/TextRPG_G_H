using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static void Add(int i, ref int result)
        {
            result += i;
        }
        static void Main(string[] args)
        {
            int total = 10;
            Console.WriteLine(total);
            Add(200, ref total);//ref가 값을 전달하는 거구나...
            Console.WriteLine(total);
        }
    }
}
