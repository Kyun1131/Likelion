using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextRPG_Test
{
    public class Player : Character
    {
        public int Level { get; private set; } = 1;
        public int Exp { get; private set; } = 0;
        private int ExpToNextLevel => Level * 20;

        private int Potions = 2;

        public Player(string name, int hp, int attack) : base(name, hp, attack)
        {
        }

        // 캐릭터 선택
        public static Player SelectJob()
        {
            while (true)
            {
                Console.WriteLine("직업을 선택하세요 (1. 전사 | 2. 마법사 | 3. 도적): ");
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: return new Player("전사", 100, 10);
                        case 2: return new Player("마법사", 80, 20);
                        case 3: return new Player("도적", 70, 25);
                    }
                }
                Console.WriteLine("올바른 숫자를 입력하세요 (1~3)");
                
            }
        }

        // 레벨업 시스템
        public void GainExp(int amount)
        {
            Exp += amount;
            if (Exp >= ExpToNextLevel)
            {
                Exp -= ExpToNextLevel;
                Level++;
                MaxHp += 10;
                Attack += 5;
                Console.WriteLine($"레벨업! Lv.{Level} | HP: {MaxHp} | ATK: {Attack}");
            }
        }

        // 아이템 시스템 추가
        
        public void UsePotion()
        {
            if (Potions > 0)
            {
                Heal(20);
                Potions--;
                Console.WriteLine("포션을 사용하여 HP를 회복하였습니다!");
            }
            else
            {
                Console.WriteLine("포션이 부족합니다!");
            }
        }

        public void AddPotion() => Potions++;
    }
}
