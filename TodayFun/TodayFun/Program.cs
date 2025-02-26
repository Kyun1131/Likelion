using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // 가지고 있는 소지금을 입력하세요

            //("단단한 바닷가재", 1, 65)
            //("커다란 키조개", 2, 130)
            //("꽝꽝 언 고등어", 4, 440)
            //("코모도왕도마뱀", 8, 880)
            //("뾰족한 돛새치", 16, 1760)
            //("천산갑", 32, 3520)

            // 2단계
            //캐릭터 이름
            //공격력 : 100 + 1
            int gold = 0;
            int atk = 10;
            string name = "z1존멋사z";
            string equippedWeapon = "맨손"; // 기본 착용 무기

            Console.Write("당신의 소지금을 입력해 주세요. : ");

            // 예외 처리 추가
            if (!int.TryParse(Console.ReadLine(), out gold) || gold < 0)
            {
                Console.WriteLine("잘못된 입력입니다. 숫자를 입력해 주세요.");
                return;
            }

            // 무기 데이터 (무기 이름, 공격력 증가량, 가격)
            (string weapon, int bonusAtk, int price)[] weapons =
            {
                ("단단한 바닷가재", 1, 65),
                ("커다란 키조개", 2, 130),
                ("꽝꽝 언 고등어", 4, 440),
                ("코모도왕도마뱀", 8, 880),
                ("뾰족한 돛새치", 16, 1760),
                ("천산갑", 32, 3520)
            };

            while (true)
            {
                Console.WriteLine($"\n{name}, 현재 소지금: {gold} 골드");
                Console.WriteLine("구매 가능한 무기 목록:");

                int index = 1;
                var availableWeapons = new List<(int, string, int, int)>();
                foreach (var (weapon, bonusAtk, price) in weapons)
                {
                    if (gold >= price) // 보유 골드로 구매 가능한 무기만 표시
                    {
                        availableWeapons.Add((index, weapon, bonusAtk, price));
                        Console.WriteLine($"[{index}] {weapon} (공격력 +{bonusAtk}) - {price} 골드");
                        index++;
                    }
                }

                if (availableWeapons.Count == 0)
                {
                    Console.WriteLine("소지금이 부족하여 구매할 수 있는 무기가 없습니다.");
                    break;
                }

                Console.Write("\n구매할 무기의 번호를 입력하세요 (0 입력 시 구매 종료): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > availableWeapons.Count)
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해 주세요.");
                    continue;
                }

                if (choice == 0) break; // 구매 종료

                var selectedWeapon = availableWeapons[choice - 1];

                gold -= selectedWeapon.Item4; // 가격 차감
                atk = 10 + selectedWeapon.Item3; // 공격력 업데이트
                equippedWeapon = selectedWeapon.Item2; // 착용 무기 변경

                Console.WriteLine($"{selectedWeapon.Item2}을(를) 장착하였습니다! 남은 소지금: {gold} 골드");

                // 추가 구매 여부 확인
                while (true)
                {
                    Console.Write("\n더 구매하시겠습니까? (Y/N): ");
                    string answer = Console.ReadLine().Trim().ToUpper();

                    if (answer == "Y")
                    {
                        break; // 다시 무기 구매 목록 표시
                    }
                    else if (answer == "N")
                    {
                        goto Finish; // 구매 종료 후 결과 출력
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 'Y' 또는 'N'을 입력해 주세요.");
                    }
                }
            Finish:
                // 결과 출력
                Console.WriteLine("\n====================");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"착용 무기: {equippedWeapon}");
                Console.WriteLine($"최종 공격력: {atk}");
                Console.WriteLine($"남은 소지금: {gold} 골드");
                Console.WriteLine("====================");
            }
    }
}
