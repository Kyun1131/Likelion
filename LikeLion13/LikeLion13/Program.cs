using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion13
{
    class Program
    {
        static void Main(string[] args)
        {
            //캐릭터 선택화면 만들기//

            // 스위치문을 사용하여 만들어보자
            // 캐릭터 선택하세요 (1.검사, 2.마법사, 3.도적) 
            // 1. 검사 - 공 100, 방 90, 2. 마법사 - 공 110, 방 80, 3. 도적 - 공 115, 방 70

            /*Console.Write("캐릭터를 선택하세요 (1. 검사, 2. 마법사, 3. 도적): ");
            Console.Write("번호 입력: ");
            
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.");
                return;
            }

            string jab = "";
            int atk = 0, def = 0;
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("전사");
                    atk = 100;
                    def = 90;
                    break;

                case 2:
                    Console.WriteLine("마법사");
                    atk = 110;
                    def = 80;
                    break;

                case 3:
                    Console.WriteLine("도적");
                    atk = 115;
                    def = 70;
                    break;

                default:
                    Console.WriteLine("잘못된 선택입니다. 1 ~ 3 사이의 숫자를 입력하세요");
                    return;
            }

            Console.WriteLine("\n===== 캐릭터 선택 완료 =====");
            Console.WriteLine($"선택한 캐릭터: {jab}");
            Console.WriteLine($"공격력: {atk}");
            Console.WriteLine($"방어력: {def}");
            Console.WriteLine("=========================");*/

            // for문으로 0 ~ 9까지 만들기//

            // for문을 이용하여 만들기

            /*for (int i = 0; i<=9; i++)
            {
                Console.WriteLine("숫자 : " + i);
            }*/


            // 1부터 10까지의 합 구하기

            /*int sum = 0;

            for (int i=1; i<=10; i++ )
            {
                sum += i;

                Console.WriteLine($"sum : {sum} i : {i}");
            }

            Console.WriteLine($"1부터 10까지 합: {sum}");*/




            // 대장장이 키우기
            // 도끼 등급: S 10%, U 40%, R 50%

            /*Random rand = new Random(); // 랜덤 값을 뽑는 문장

            int rnd = 0;

            for(int i =0; i<20; i++)
            {
                rnd = rand.Next(1, 100);

                if(rnd >= 1 && rnd <=10)
                {
                    Console.WriteLine("도끼 등급 SSS");
                }
                else if (rnd <= 11 && rnd <=40)
                {
                    Console.WriteLine("도끼 등급 SS");
                }
                else
                {
                    Console.WriteLine("도끼 등급 S");
                }
                Thread.Sleep(500);
            }*/




            // do while
            // 1회 무조건 실행하고 while문과 같이 조건 진행

            /*int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);*/




            // break
            // 반복문을 탈출할수있다.

            /*for(int i=1; i<=10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }*/


            // continue
            // 현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            /*for(int i =1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }*/



            // goto
            // 레이블로 이동 잘안씀

            /*int n = 1;
        start:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start;
            }*/



            // 콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            // 콘솔 버퍼 크기도 설정
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;


            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃                               스트라이커 키우기                              ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("┃                                                                              ┃");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            
            Thread.Sleep(5000);



            for (int x = 0; x < 30; x++) // 0~ 29이동
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("o");
                Console.SetCursorPosition(x, 11);
                Console.Write("╋");
                Console.SetCursorPosition(x, 12);
                Console.Write("∧");
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("내 버블이 어디갔지?!");
            Thread.Sleep(3000);
        }
    }
}
