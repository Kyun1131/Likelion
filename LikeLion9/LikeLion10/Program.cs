using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion10
{
    class Program
    {
        static void Main(string[] args)
        {
            // var를 사용하여 변수 선언
            var name = "Alice"; //문자열 추론
            var age = 25; // 정수로 추론
            var isStudent = true; // 논리값으로 추론

            Console.WriteLine($"이름: {name}, 나이 : {age}, 학생 여부 : {isStudent}");

        }
    }
}
