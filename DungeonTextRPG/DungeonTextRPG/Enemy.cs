// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG
{
    public class Enemy
    {
        public static Enemy enemy = new Enemy();
    }

    public class Monster
    {
        public static Character character = new Character();

        public int HitP;
        public int Atk;
        public int Def;

        public void Attack(string Monstername)
        {
            Random rand = new Random();
            Console.WriteLine($"{Monstername}가 공격했습니다.");
            int playerDamage = Atk - character.job.Def;
            int realDamage = rand.Next(playerDamage - 5, playerDamage + 6); //피해 난수 만들기...
            if (realDamage < 1)
            {
                realDamage = 1;
            }
            character.job.HitP -= realDamage;
        }

        public Monster() { }
    }

    public class OldMan : Monster
    {
        public OldMan()
        {
            HitP = 200;
            Atk = 1;
            Def = 1;
        }
    }
}