using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace im
{
    public class Base
    {
        public string Name;
        public int Attack;
        public int Health;

        public Base(string name, int atk, int hp)
        {
            Name = name;
            Attack = atk;
            Health = hp;
        }

        public void TakeDamage(int damage) => Health -= damage;
        public bool IsAlive() => Health > 0;

        public void Render()
        {
            Console.WriteLine($"{Name} | Atk: {Attack} | Hp: {Health}");
        }
    }

    public class Player : Base
    {
        public Player(string name, int atk, int hp) : base(name, atk, hp)
        {
        }

        public static Player SelectJob()
        {
            while (true)
            {
                Console.WriteLine("직업을 선택해 주세요 (1.전사, 2.마법사, 3.도적): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: return new Player("전사", 10, 100);
                        case 2: return new Player("전사", 15, 80);
                        case 3: return new Player("전사", 20, 65);
                    }
                }
                Console.WriteLine("올바른 숫자를 입력해주세요(1~3)");
            }
        }

    }
    
    public class Monster : Base
    {
        public Monster(string name, int atk, int hp) : base(name, atk, hp)
        {
        }
         public static Monster SelectMonster(int fieldChoice)
        {
            switch (fieldChoice)
            {
                default: return new Monster("나무", 5, 50);
                case 2: return new Monster("바닷물", 10, 70);
                case 3: return new Monster("콘크리트", 15, 90);
            }
        }
    }

    public class Field
    {
        private Player _player;
        private Monster _mon;

        public void SetPlayer(Player player) => _player = player;

        public void Enter()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("사냥터를 선택하세요 (1.숲 | 2.바다 | 3.도시)");
                if(int.TryParse(Console.ReadLine(), out int fieldChoice) && fieldChoice >= 1 && fieldChoice <=3 )
                {
                    _mon = Monster.SelectMonster(fieldChoice);
                    //Battle(fieldChoice);
                    break;
                }
                Console.WriteLine("올바른 숫자를 입력해 주세요 (1~3)");
            }
        }
    }



    public class MainGame
    {
        private Player _player;
        private Field _field;

        public void Initialize()
        {
            _player = Player.SelectJob(); // 직업 선택 화면
            _field = new Field(); // 필드 및 몬스터 정보
            _field.SetPlayer(_player); // 직업 정보
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                _player.Render();
                Console.WriteLine("1.사냥 | 2.종료");
                if(int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 2)
                {
                    Console.WriteLine("올바른 숫자를 입력해 주세요 (1~2)");
                    continue;
                }

                if (input == 2) break;

                if (input == 1) _field.Enter();

            }
        }
    }



    class Program
    {



         
        static void Main(string[] args)
        {
            MainGame game = new MainGame();
            game.Initialize();
            game.Run();
        }
    }
}
