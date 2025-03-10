using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_04_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //조건문
            /*int score = int.Parse(Console.ReadLine());


            if (score <= 100)
            {
                Console.WriteLine("레벨업!");
            }
            else
            {
                Console.WriteLine("노력 필요");
            }*/

            /*int age = int.Parse(Console.ReadLine());
            if(age < 13)
            {
                Console.WriteLine("어린이");
            }
            else if (age < 19)
            {
                Console.WriteLine("청소년");
            }
            else
            {
                Console.WriteLine("성인");
            }*/

            /*string grade = Console.ReadLine();

            switch (grade)
            {
                case "A": Console.WriteLine("최고"); break;
                case "B": Console.WriteLine("좋음"); break;
                case "C": Console.WriteLine("보통"); break;
                case "D": Console.WriteLine("탈락"); break;
            }*/

            /* // 입력
            Console.Write("");

            // 정수로 변환
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                string season = ""; // 변수 선언

                // switch로 묶기
                switch (month)
                {
                    case 3:
                    case 4:
                    case 5:
                        season = "봄";
                        break; // 돔황챠!
                    case 6:
                    case 7:
                    case 8:
                        season = "여름";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = "가을";
                        break;
                    case 12:
                    case 1:
                    case 2:
                        season = "겨울";
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다!");
                        return; // 프로그램 종료
                }

                // 출력
                Console.WriteLine($"{season}입니다.");
            }
            else
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }*/

            // 반복문
            // for문 = ~를 위한 -> 목적을 가지고, 어떤 대상에 대해
            // 어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            // 정해진 횟수나 특정 조건을 만족하는 범위를 대상을 반복하는 구조
            // for (초기화; 조건; 증감식)
            // 반복될 내용

            // int i=0; <- 초기화
            // i < 5; <- 조건문
            // i ++ <- 증감식
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"몬스터 소환 {i + 1}번째");
            }*/

            /*for(int i=0; i<11; i++)
            {
                Console.WriteLine($"{i + 1}");
            }*/

            /*for (int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i + 1;
            }
            Console.WriteLine(sum);*/

            /*int dan = int.Parse(Console.ReadLine());

            for(int i=1; i <= 9; i++)
            {
                Console.WriteLine($"{dan} x {i} = {dan*i}");
            }*/

            // 줄바꿈마다 *개수 늘려가기
            /*for(int i = 1; i <= 4; i++) // 1부터  4까지 반복
            {
                for (int j = 1; j<=i; j++) // 현재 줄(i) 만큼 *출력
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // enter
            }*/


        }
    }
}
