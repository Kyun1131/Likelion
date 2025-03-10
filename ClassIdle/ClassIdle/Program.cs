using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassIdle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);
            // 콘솔 버퍼 크기도 설정
            Console.SetBufferSize(80, 25);


            Console.CursorVisible = false;

            Random rand = new Random();

            int gold = 500; ; // 소지 골드
            int health = 16; // 버블
            int power = 10; // 공격력
            int level = 1; // 무기 레벨
            int costPerTry = 1000; // 강화 시도 비용
            int input;
            bool isAlive = true;

            // 인트로

            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(10000);
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("☆ 스트라이커 키우기 ☆");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("☆ 스트라이커 키우기 ☆");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("☆ 스트라이커 키우기 ☆");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("☆ 스트라이커 키우기 ☆");
            Thread.Sleep(500);
            Console.Clear();
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("★ 스트라이커 키우기 ★");
            Thread.Sleep(500);



            while (isAlive)
            {
                Console.SetCursorPosition(0, 17);
                Console.WriteLine($"현재 상태 ┃ ♥ 버블 {health} ┃ ⓖ 골드 {gold} ┃ ◎ 공격력 {power} ┃");
                Console.WriteLine("\n1.▷ 레이드하기 ");
                Console.WriteLine("2.▶ 장비 강화 (1000골드)");
                Console.WriteLine("3.▷ 버블 쌓기 (버블 +4)");
                Console.WriteLine("4.▶ 로아 접기");
                Console.Write("입력: ");

                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.SetCursorPosition(40, 22);
                    Console.WriteLine("Ⅹ 잘못된 입력입니다. 숫자를 입력하세요.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }

                if (input == 1) // 레이드하기
                {
                    Console.Clear();
                    Console.WriteLine(" 레이드를 하고 있습니다.");
                    Thread.Sleep(500);
                    Console.WriteLine(" 레이드를 하고 있습니다..");
                    Thread.Sleep(500);
                    Console.WriteLine(" 레이드를 하고 있습니다...");
                    Thread.Sleep(500);
                    Console.WriteLine(" 레이드를 하고 있습니다....");

                    int eventChance = rand.Next(1, 101); // 1~100 랜덤 이벤트 발생

                    if (eventChance <= 20) // 20% 확률 전투 발생
                    {
                        int damage = rand.Next(8, 16);
                        Console.WriteLine($"Ⅹ 버그가 발생했다! 버블이 사라졌다.. (버블 -{damage}");
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(800, 1001);
                        Console.WriteLine($"ⓖ 괜찮은 아이템이 드랍됐다! (+{reward} 골드)");
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(1, 4);
                        Console.WriteLine($"♥ 버블 버그 하나가 고쳐졌다!! (+{heal} 버블)");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\nⅩ 버블이 0이 되어 수련을 할 수 없다... 꼬접 Ⅹ");
                        isAlive = false;
                    }
                }
                else if (input == 2) //장비 강화
                {
                    if (gold < costPerTry)
                    {
                        Console.WriteLine("Ⅹ 골드가 부족합니다! 강화할 수 없습니다.");
                        continue;
                    }

                    gold -= costPerTry; // 강화 비용 차감
                    int successRate = GetSuccessRate(level); // 현재 단계의 성공 확률
                    int chance = rand.Next(1, 101); // 1~100 사이 랜덤 값 생성

                    Console.Clear();
                    Console.WriteLine($" 강화 시도 중. (성공 확률: {successRate}");
                    Thread.Sleep(500);
                    Console.WriteLine($" 강화 시도 중.. (성공 확률: {successRate}");
                    Thread.Sleep(500);
                    Console.WriteLine($" 강화 시도 중... (성공 확률: {successRate}");
                    Thread.Sleep(500);
                    Console.WriteLine($" 강화 시도 중.... (성공 확률: {successRate}");
                    Thread.Sleep(1000);

                    if (chance <= successRate) // 성공 확률보다 낮으면 성공
                    {
                        level++;
                        power += 5; // 공격력 증가량
                        Console.WriteLine($"◎ 강화 성공! 장비 레벨: +{level}, 공격력: {power}");
                    }
                    else
                    {
                        Console.WriteLine("Ⅹ 강화 실패! 장인의 기운은 없어요~");
                    }

                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.WriteLine($" 버블을 쌓고 있는 중. ");
                    Thread.Sleep(500);
                    Console.WriteLine($" 버블을 쌓고 있는 중.. ");
                    Thread.Sleep(500);
                    Console.WriteLine($" 버블을 쌓고 있는 중... ");
                    Thread.Sleep(500);
                    Console.WriteLine($" 버블을 쌓고 있는 중.... ");
                    Thread.Sleep(1000);

                    Console.WriteLine("♥ 버블이 쌓였다! (+4 버블)");
                    health += 4;
                }
                else if (input == 4)
                {
                    Console.WriteLine("Ⅹ 게임을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ⅹ 잘못된 입력입니다. 1~4 사이 숫자를 입력하세요.");
                }
            }

            Console.WriteLine("\n 최종 상태: ");
            Console.WriteLine($"♥ 버블: {health}");
            Console.WriteLine($"ⓖ 남은 골드: {gold}");
            Console.WriteLine($"◎ 최종 공격력: {power} (장비 +{level})");
        }

        // 현재 강화 단계에 따른 성공 확률 반환
        static int GetSuccessRate(int level)
        {
            if (level <= 5) return 90 - (level - 1) * 10; // 1강~5강: 90%, 80%, 70%, 60%, 50%
            return Math.Max(5, 50 - (level - 5) * 5); // 6강 이후: 45%, 40%, 35%, ..., 최소 5%
        }
    }
}
