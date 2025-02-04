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
        Entrance entrance = new Entrance();
    }
    public class Entrance
    {
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
