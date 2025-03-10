using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask3
{
    class Program
    {

        /*static int number(int num, int Num) // 문제3. Q1
        {
            return num + Num;
        }*/


        /*static int number(string str)
        {
            return str.Length;
        }*/


        /*static int Number(int[] Num)
        {
            int max = 0;
            for(int i=0; i<3; i++)
            {
                if (max < Num[i])
                {
                    max = Num[i];
                }
            }
            return max;
        }*/

        static void Main(string[] args)
        {
            // 문제1: 배열
            // Q1. 배열 요소 출력 - 크기가 5인 정수 배열을 만들고. {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            int[] num = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            // Q2. 배열 요소 합 구하기 - 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.
            /*int[] num = new int[5];
            int sum = 0;

            Console.Write("숫자 입력: ");
            string input = Console.ReadLine();
            string[] Num = input.Split(' ');

            for(int i=0; i<num.Length; i++)
            {
                num[i] = int.Parse(Num[i]);
                sum += num[i];
            }

            Console.WriteLine($"총 합: {sum}");*/


            // Q3. 최대값 찾기 - 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            /*int[] num = { 3, 8, 15, 6, 2 };
            int max = 0;

            for(int i=0; i<5; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            // 출력
            Console.WriteLine($"최대 값: {max}");*/


            // 문제2: 
            // Q1. 1부터 10까지 출력 (for문) - for문을 사용하여 1부터 10까지 출력하세요.
            /*for(int i=0; i<11; i++)
            {
                Console.Write(i + " ");
            }*/

            // Q5. 짝수만 출력 (while문) - while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
            /*int num = 1;

            while (num <= 10)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
                num++;
            }*/


            // Q6. 배열 요소 출력 (foreach문) - foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.
            /*int[] num = { 1, 2, 3, 4, 5 };

            foreach(int Num in num)
            {
                Console.Write(Num+" ");
            }*/


            // 문제3:
            // Q7. 두 수의 합을 구하는 함수 - 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            /*int num = 0;
            int num1 = 0;

            Console.Write("첫 번째 정수를 입력해주세요: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력해주세요: ");
            num1 = int.Parse(Console.ReadLine());

            int result = number(num, num1); // static int number(int num, int Num) // 문제3. Q7

            Console.Write($"합: {num} + {num1} = {result}");*/



            // Q8. 문자열 길이 반환 함수 - 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
            /*Console.Write("문자열 입력: ");
            string str = Console.ReadLine();
            Console.WriteLine("문자열 길이: " + number(str));*/


            // Q9. 가장 큰 수 반환 함수 - 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
            /*int num, num1, num2 = 0;
            
            Console.Write("첫 번째 정수를 입력해주세요: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력해주세요: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수를 입력해주세요: ");
            num2 = int.Parse(Console.ReadLine());

            int[] nums = { num, num1, num2 }; 
            // 출력
            Console.WriteLine($"가장 큰 수: " + Number(nums));*/
        }
    }
}
