using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test7
    {
        public class Unit
        {
            public virtual void Move()
            {
                Console.WriteLine("두발로 걷기");
            }

            public void Attack()
            {
                Console.WriteLine("Unit 공격");
            }
        }

        public class Marine : Unit
        {

        }

        public class Zergling : Unit
        {
            public override void Move()
            {
                Console.WriteLine("네발로 걷기");
            }
        }

        static void Main(string[] args)
        {
            Zergling zerg = new Zergling();
            zerg.Move();
        }
    }
    //출력 결과: 네발로 걷기
    //Zergling 클래스는 Unit 클래스를 상속받았고, Move 메서드를 오버라이딩하여 재정의했다.자동완성이 자꾸...나도 알고 있었는데...
}
