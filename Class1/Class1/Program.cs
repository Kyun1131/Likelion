using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {

        /// <summary>
        /// 열거형(Enumeration = enum)
        /// </summary>
        /// 숫자 값에 이름을 부여하는 자료형
        /// 가독성을 높이고, 의미 있는 값으로 표현 가능
        /// 기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가
        /// 
        enum DayOfWeek
        {
            sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        static void Main(string[] args)
        {
            /// <summary>
            /// 2. 열거형 예문(1)
            /// </summary>
            /// 숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            /// 
            DayOfWeek today = DayOfWeek.Wednesday;

            Console.WriteLine(today);
            Console.WriteLine((int)today);

            /// <summary>
            /// 2. 열거형 예문(2)
            /// </summary>
            /// 숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            /// 
            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);

            ///<summary>
            /// Math 클래스 사용
            /// </summary>
            /// 수학적 계산
            /// 

            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.73): {Math.Round(3.75)}");

        }
    }
}
