using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test4
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;

            x += x * ++y;

            Console.WriteLine(x++);
            //출력값 = 10
            //사칙연산 순서대로 지만 ++이 먼저 적용되어 계산하므로 식으로 표현하면 2 + 2 * 4 = 10가 된다.
            //x++은 출력 후에 연산되므로 11이 아닌 10으로 출력된다.
        }
    }
}
