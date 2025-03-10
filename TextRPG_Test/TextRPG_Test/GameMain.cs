using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    // 게임 메인
    public class MainGame
    {
        private Player _player;
        private Field _field;

        public void Initialize()
        {
            _player = Player.SelectJob();
            _field = new Field();
            _field.SetPlayer(_player);
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                _player.Render();
                Console.WriteLine("1. 필드 탐험 | 2. 종료");
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
}
