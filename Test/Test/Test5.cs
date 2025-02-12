using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test5
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                string answer = Console.ReadLine();

                bool isSuccess = int.TryParse(answer, out int result);

                if (isSuccess)
                {
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("짝수입니다.");
                    }
                    else
                    {
                        Console.WriteLine("홀수입니다..");
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}

