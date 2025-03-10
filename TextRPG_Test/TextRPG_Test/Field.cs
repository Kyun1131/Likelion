using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Field
    {
        private Player _player;
        private Monster _monster;
        private string[] _quests = { "고블린 3마리 처치", "망둥어 2마리 처치", "스켈레톤 1마리 처치" };
        private int[] _questProgress = { 0, 0, 0 };

        public void SetPlayer(Player player) => _player = player;

        public void Enter()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("필드를 선택하세요 (1. 숲 | 2. 해변가 | 3. 미궁): ");
                if (int.TryParse(Console.ReadLine(), out int fieldLevel) && fieldLevel >= 1 && fieldLevel <= 3)
                {
                    _monster = Monster.SelectMonster(fieldLevel);
                    Battle(fieldLevel);
                    break;
                }
                Console.WriteLine("올바른 숫자를 입력해주세요 (1~3)");
            }
        }

        // 전투 시스템
        public void Battle(int fieldLevel)
        {
            Console.Clear();
            Console.WriteLine("전투 시작!");
            while (_player.IsAlive() && _monster.IsAlive())
            {
                _player.Render();
                _monster.Render();

                Console.WriteLine("\n1. 공격 | 2. 도망 | 3. 포션 사용): ");
                if(!int.TryParse(Console.ReadLine(), out int action) || action < 1 || action > 3)
                {
                    Console.WriteLine("올바른 숫자를 입력해주세요 (1~3)");
                    continue;
                }

                if (action == 2) break;
                if (action == 3)
                {
                    _player.UsePotion();
                    continue;
                }

                _monster.TakeDamage(_player.Attack);
                Console.WriteLine($"{_player.Name}이(가) {_monster.Name}을(를) 공격했습니다!");

                if (_monster.IsAlive())
                {
                    _player.TakeDamage(_monster.Attack);
                    Console.WriteLine($"{_monster.Name}이(가) 반격했습니다.");
                }

                Console.WriteLine($"\n아무 키나 누르면 계속...");
                Console.ReadKey();
            }

            if (!_player.IsAlive())
            {
                Console.WriteLine("당신은 전투에게 패배했습니다...");
                _player.Hp = _player.MaxHp;
            }
            else if (!_monster.IsAlive())
            {
                Console.WriteLine("몬스터를 처지했습니다!");
                _player.GainExp(10);
                _player.AddPotion();
                _questProgress[fieldLevel - 1]++;
                Console.WriteLine($"퀘스트 진행 상황: {_quests[fieldLevel - 1]} ({_questProgress[fieldLevel - 1]}/3)");

                if (_questProgress[fieldLevel - 1] >= 3)
                {
                    Console.WriteLine("퀘스트 완료! 보상을 받았습니다.");
                    _player.GainExp(20);
                }
            }
        }


    }
}
