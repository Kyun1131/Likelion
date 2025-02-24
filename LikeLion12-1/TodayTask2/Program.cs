using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제1. 세 정수의 최대 값 구하기
            Console.WriteLine("문제1");
            Console.Write("첫 번째 정수를 입력해 주세요 : ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("두 번째 정수를 입력해 주세요 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("세 번째 정수를 입력해 주세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            int max = num;

            if (num1 > max) max = num1;
            if (num2 > max) max = num2;

            Console.WriteLine($"최대값 : {max}");


            // 문제2. 점수에 따른 학점 평가
            Console.WriteLine("\n문제2");
            Console.Write("당신의 학점을 입력해 주세요 : ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }


            // 문제3. 간단한 사칙연산 계산기
            Console.WriteLine("\n문제3");
            Console.Write("첫 번째  숫자를 입력해 주세요 : ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("연산자 (+, -, *, /)를 입력해 주세요 : ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("두 번째  숫자를 입력해 주세요 : ");
            double num4 = double.Parse(Console.ReadLine());

            double result = 0;
            bool isValid = true;

            if (op == '+')
                result = num3 + num4;
            else if (op == '-')
                result = num3 - num4;
            else if (op == '*')
                result = num3 * num4;
            else if (op == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("오류: 0으로 나눌 수 없습니다.");
                    isValid = false;
                }
                else
                    result = num1 / num2;
            }
            else
            {
                Console.WriteLine("오류: 잘못된 연산자입니다.");
                isValid = false;
            }

            if (isValid)
                Console.WriteLine($"결과: {result}");
        }
    }
}
