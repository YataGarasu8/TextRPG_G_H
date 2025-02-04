// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG
{

    public class Character
    {
        private static Character character = new Character();
        public Job? job;
        public Skil? skil;

    }
    public class Job
    {
        public int Lv = 1;
        public string? Jobname;
        public int Atk;
        public int Def;
        public int HitP;
        public int Gold;
        public int code;
        public Job(int A, int D, int H, int G, string J)//생성자
        {
            Jobname = J;
            Atk = A;
            Def = D;
            HitP = H;
            Gold = G;
        }
        public Job() { }
    }

    public class Warrior : Job
    {

        public Warrior(int A, int D, int H, int G, string J) : base(A, D, H, G, J) //튜터님이 가르쳐 주셔서 써봤는데 아래 생성자에 넣어도 되지 않았을까?
        {

        }
        public Warrior() { code = 1; } //직업을 구별하기 위한 코드

    }

    public class Thief : Job
    {

        public Thief(int A, int D, int H, int G, string J) : base(A, D, H, G, J)
        {

        }
        public Thief() { code = 2; }
    }
    public class Butcher : Job
    {

        public Butcher(int A, int D, int H, int G, string J) : base(A, D, H, G, J)
        {

        }
        public Butcher() { code = 3; }
    }

    public class Duelist : Job
    {
        public Duelist(int A, int D, int H, int G, string J) : base(A, D, H, G, J)
        {

        }
        public Duelist() { code = 3; }
    }
    public class Skil
    {
        public void Attack(string names)
        {
            Console.WriteLine($"{names}의 공격!");
        }
        public void Escape(string names)
        {
            Console.WriteLine($"{names}(은)는 도망쳤다!");
        }
        public void SpcialAttack(string names)
        {
            Console.WriteLine($"{names}의 헤비 슬래시!");
            Console.WriteLine($"{names}의 기습!");
            Console.WriteLine($"{names}의 고기 썰기!");
            Console.WriteLine($"{names}의 버서커 소울!");
        }
    }
}
