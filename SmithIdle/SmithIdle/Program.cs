using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projectSmithIdle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 랜덤
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            while (true)
            {
                Console.Clear(); // 화면 지우기
                Console.WriteLine("공방");
                Console.WriteLine("1. 광산으로 가기 ");
                Console.WriteLine("2. 무기 단조 ");
                Console.WriteLine("3. 자러가기 ");
                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine()); // input에 키로 눌린 숫자 담기

                if (input == 1) // 나무캐기화면
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금: " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if (input == 2)
                {
                    // 장비뽑기
                    if (pmoney >= 1000)
                    {
                        pmoney -= 1000;

                        // 20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)
                            {
                                Console.WriteLine("SSR 다이아 도끼");
                            }
                            else if (rnd >=2 && rnd <= 6)
                            {
                                Console.WriteLine("SR 금 도끼");
                            }
                            else if (rnd >=7 && rnd <= 17)
                            {
                                Console.WriteLine("UR 은 도끼");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("U 철 도끼");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("R 돌 도끼");
                            }
                            else
                            {
                                Console.WriteLine("C 나무 도끼");
                            }
                            Thread.Sleep(500); // 뽑기 간격 0.5초
                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}