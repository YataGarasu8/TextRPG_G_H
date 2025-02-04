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
        public int HitP;
        public int Atk;
        public int Def;


        public Monster() { }
    }

    public class OldMan : Monster
    {
        public OldMan() { }
    }
}