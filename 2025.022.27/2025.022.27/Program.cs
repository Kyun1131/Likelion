using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function2
{
    class Program
    {
        /// <summary>
        /// 3. 전역 변수
        /// </summary>
        /// 
        /*static int num2 = 20;*/



        /// <summary>
        /// 1. 매개변수도 반환값도 없는 함수
        /// </summary>
        /*static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }*/


        /// <summary>
        /// 2. 매개변수만 있는 함수
        /// </summary>
        /// <returns></returns>
        /*static int GetNumber()
        {
            return 42;
        }*/


        // 4. 
        /// <summary>
        /// 4. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /*static int Add(int a, int b)
        {
            return a + b;
        }*/


        /// <summary>
        /// 5. 기본값을 가진 매개변수 (디폴트 매개변수)
        /// </summary>
        /// 매개변수 이름을 지정하여 순서와 상관없이 값을 전달
        /// <param name="name"></param>
        /*static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }*/


        /// <summary>
        /// 6. 함수 오버로딩 (Overloading)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /*static int Multiplay(int a, int b)
        {
            return a + b;
        }
        static double Multiplay(double a, double b)
        {
            return a + b;
        }*/


        /// <summary>
        /// 7. out 키워드
        /// </summary>
        /// out이 붙은 인자는 return처럼 값을 넘겨받을 수 있고 reference로 동작하기 때문에 효율적임
        /*static void Divide(int a, int b, out int quotirnt, out int remainder)
        {
            quotirnt = a / b;

            remainder = a % b;
        }*/


        /// <summary>
        /// 8. ref 키워드 
        /// </summary>
        /// reference(참조), 값을 복사하는게 아닌 인자로 넘겨 받은 변수의 메모리 공간을 가리켜서 별도의 복사가 없기때문에 오버헤드가 적음, 
        /// 함수 내부에서 ref 키워드가 붙은 인자를 변경하면 함수 외부에서 인자로 넘긴 값도 바뀜
        /// 

        /*static void Increase(ref int num)
        {
            num += 10;
        }*/


        /// <summary>
        /// 9. params 키워드
        /// </summary>
        /// 가변 매개변수
        
        /*static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }*/


        /// <summary>
        /// 10. 재귀 함수 
        /// </summary>
        /// 자기 자신을 호출
        /*static int Factorial(int n)
        {
            if (n <= 1)
            {
                Console.Write("*" + n + " = "); // = 120 출력
                return 1;
            }
            Console.Write("*" + n + " "); // *n *n *n *n *n  출력

            return n * Factorial(n - 1);
        }*/


        /// <summary>
        /// 화살표 함수
        /// </summary>
        /// C#에서 화살표 => 람다 표현식 이라고도 하며 간결한 방식으로 함수를 정의 가능.
        /// 중괄호 {} return 생략 가능
        /*static int AddArrow(int a, int b) => a + b; // 1

        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!"); // 2*/

        static void Main(string[] args)
        {
            // PrintHello(); // 출력
            // Printessage("반갑습니다.");
            /*int num = GetNumber();
            Console.WriteLine(num);*/
            //


            /*int result = Add(3, 5);
            Console.WriteLine(result);*/
            // or
            /*Console.WriteLine(Add(3, 5));*/
            //



            /*Greet();
            Greet("철수");*/
            // 5. 기본값을 가진 매개변수 (디폴트 매개변수)
            // 출력 안녕하세요, 손님
            // 출력 안녕하세요, 철수


            /*Console.WriteLine(Multiplay(3, 4));
            Console.WriteLine(Multiplay(2.5, 3.5));*/


            // 7. out 키워드 
            /*int q, r;
            Divide(10, 3, out q, out r);
            Console.WriteLine($"몫: {q}, 나머지: {r}");*/


            // 8. ref  키워드
            /*int value = 5;
            Increase(ref value);
            Console.WriteLine(value);*/


            // 9. params 키워드 (가변 매개변수)
            /*Console.WriteLine(Sum(1, 2, 3)); // 출력 6
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); // 출력 55*/


            // 10.. 재귀 함수
            /*Console.WriteLine(Factorial(5));*/


            // 11. 화살표 함수
            /*Console.WriteLine(AddArrow(3, 5)); // 1

            PrintMessageArrow(); // 2*/
        }
    }
}
