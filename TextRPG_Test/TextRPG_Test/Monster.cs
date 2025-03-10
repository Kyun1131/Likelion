using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Monster : Character
    {
        public Monster(string name, int hp, int attack) : base(name, hp, attack)
        {
        }

        public static Monster SelectMonster(int fieldLevel)
        {
            switch (fieldLevel)
            {
                case 1: return new Monster("고블린", 40, 5);
                case 2: return new Monster("망둥어", 50, 7);
                case 3: return new Monster("스켈레톤", 60, 10);
                default: return new Monster("알 수없는 몬스터", 1000, 20);
            }
        }
    }
}
