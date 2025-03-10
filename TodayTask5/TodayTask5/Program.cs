using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TodayTask5
{
    class Unit
    {
        public string Name;
        public int ATK;
        public int DEF;
        public int HP;
        public float ATKSpeed;
        public int Move;
        public int Range;

        public Unit(string name, int atk, int def, int hp, float atks, int move, int range)
        {
            Name = name;
            ATK = atk;
            DEF = def;
            HP = hp;
            ATKSpeed = atks;
            Move = move;
            Range = range;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[ {Name} ]");
            Console.WriteLine($"| 공격력: {ATK}  |   공격 속도: {ATKSpeed}  |      사거리: {Range} |");   
            Console.WriteLine($"|   체력: {HP} |      방어력: {DEF}     |   이동 속도: {Move} |");
            Console.WriteLine("------------------------------------------------------");
        }
    }



    class MeleeMinion : Unit
    {
        public MeleeMinion()
            : base("전사 미니언", 12, 0, 477, 1.25f, 325, 110)
        {
        }
    }

    class CasterMinion : Unit
    {
        public CasterMinion() : base("마법사 미니언", 24, 0, 296, 0.667f, 325, 550)
        {
        }
    }

    class SiegeMinion : Unit
    {
        public SiegeMinion() : base("공성 미니언", 41, 0, 900, 0.667f, 325, 300) { }
    }

    class SuperMinion : Unit
    {
        public SuperMinion() : base("슈퍼 미니언", 230, 100, 1600, 0.850f, 325, 170) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MeleeMinion melee = new MeleeMinion();
            CasterMinion caster = new CasterMinion();
            SiegeMinion siege = new SiegeMinion();
            SuperMinion super = new SuperMinion();

            melee.PrintInfo();
            caster.PrintInfo();
            siege.PrintInfo();
            super.PrintInfo();
        }
    }
}
