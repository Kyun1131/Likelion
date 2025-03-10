using System;

namespace TextRPG2
{
    // 부모 클래스 (Character)
    public abstract class Character
    {
        public string Name;
        public int Attack;
        public int Hp;

        public Character(string name, int attack, int hp)
        {
            Name = name;
            Attack = attack;
            Hp = hp;
        }

        public void TakeDamage(int damage) => Hp -= damage;
        public bool IsAlive() => Hp > 0;

        public void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"학력: {Name}");
            Console.WriteLine($"정신력: {Hp} | 근성: {Attack}");
            Console.WriteLine("========================");
        }

        public int GetAttack() => Attack;
        public int GetHp() => Hp;
        public void SetHp(int hp) => Hp = hp;
    }

    // 플레이어 클래스 : Character 상속
    public class Player : Character
    {
        public Player(string name, int attack, int hp) : base(name, attack, hp) { }

        public static Player CreatePlayer()
        {
            while (true)
            {
                Console.WriteLine("직업을 선택하세요 (1. 고졸 | 2. 학사 | 3. 석사): ");
                if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 3)
                {
                    switch (input)
                    {
                        case 1: return new Player("고졸", 10, 100);
                        case 2: return new Player("학사", 20, 80);
                        case 3: return new Player("석사", 60, 60);
                    }
                }
                Console.WriteLine("올바른 숫자를 입력하세요 (1~3)\n");
            }
        }
    }

    // 몬스터 클래스 : Character 상속
    public class Monster : Character
    {
        public Monster(string name, int attack, int hp) : base(name, attack, hp) { }

        public static Monster CreateMonster(int level)
        {
            switch (level)
            {
                case 1: return new Monster("대리", 3, 30);
                case 2: return new Monster("과장", 6, 60);
                case 3: return new Monster("부장", 9, 90);
                default:
                    Console.WriteLine("⚠ 잘못된 입력입니다. 기본 몬스터를 생성합니다.");
                    return new Monster("인턴", 1, 20);
            }
        }
    }

    // 필드 클래스 & 전투 시스템
    public class Field
    {
        private Player _player;
        private Monster _monster;

        public void SetPlayer(Player player) => _player = player;

        public void Enter()
        {
            while (true)
            {
                Console.Clear();
                _player.Render();
                DrawMap();

                if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 4)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요 (1~4)");
                    continue;
                }

                if (input == 4) break; // 뒤로가기

                _monster = Monster.CreateMonster(input);
                Battle();
            }
        }

        private void Battle()
        {
            while (_monster != null) // 🔹 null 체크 추가
            {
                Console.Clear();
                _player.Render();
                _monster.Render();

                Console.WriteLine("1. 상대하기 | 2. 퇴근");
                if (!int.TryParse(Console.ReadLine(), out int action) || action < 1 || action > 2)
                {
                    Console.WriteLine("올바른 선택을 하세요 (1or2)");
                    continue;
                }

                if (action == 2) break;

                _player.TakeDamage(_monster.GetAttack());
                _monster.TakeDamage(_player.GetAttack());

                if (!_player.IsAlive())
                {
                    Console.WriteLine("플레이어가 지난 시간들에 회의감을 느끼며 퇴사를 고민합니다.");
                    _player.SetHp(100);
                    break;
                }

                if (!_monster.IsAlive())
                {
                    Console.WriteLine("축하드려요! 승진하셨습니다!");
                    _monster = null;
                    break;
                }
            }
        }

        private void DrawMap()
        {
            Console.WriteLine("1. 대리 (Lv.1)");
            Console.WriteLine("2. 과장 (Lv.2)");
            Console.WriteLine("3. 부장 (Lv.3)");
            Console.WriteLine("4. 돔황챠!@!");
            Console.WriteLine("=============");
        }
    }

    public class MainGame
    {
        private Player _player;
        private Field _field;

        public void Initialize()
        {
            _player = Player.CreatePlayer();
            _field = new Field();
            _field.SetPlayer(_player);
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                _player.Render();
                Console.WriteLine("1. 출근 | 2. 퇴사");
                if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 2)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요 (1~2)");
                    continue;
                }

                if (input == 2) break;

                if (input == 1) _field.Enter();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MainGame game = new MainGame();
            game.Initialize();
            game.Run();
        }
    }
}