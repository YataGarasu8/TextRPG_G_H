// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG
{
    public class Dungeon
    {
        private static Dungeon dungeon = new Dungeon();
        
        public Entrance entrance = new Entrance();//new를 지정 안 하면 null이고 지정하면 무한반복이라니 이건 대체... 
        //무한 반복 해결: Entrance에 상속했다가 위의 new Dungeon(); 계속 반복되었음. 튜터님도 처음 보는 오류라고ㅋㅋㅋ
    }
    public class Entrance
    {
        public static UI ui = new UI();
        public void Enter()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("[던전 난이도 선택]\n" +
                    "\n1. 하급 던전" +
                    "\n2. 중급 던전" +
                    "\n3. 상급 던전" +
                    "\n4. 최종 던전" +
                    "\n\n0. 돌아가기");
                string Ward = Console.ReadLine();
                Console.Clear();
                switch (Ward)
                {
                    case "0":
                        UI.Window();// 넌 왜 되냐...?
                        back = true;
                        break;
                    case "1":
                        break;
                }
            }
        }
    }
    public class Godungeon
    {
        public void AdVenture()
        { }
    }
    public class LesserDungeon
    { }
    public class MiddleDungeon
    { }
    public class HighDungeon
    { }
    public class LastDungeon
    { }
}
