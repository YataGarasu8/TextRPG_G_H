using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test6
    {
        static void Main(string[] args)
        {
            int[] intArr = { 4, 7, 2, 5, 6, 8, 3 };

            Array.Sort(intArr);//체크리스트에서 들었지만 기억이 안났다...

            foreach (int i in intArr)
                Console.Write(i + " ");
        }
    }
}
