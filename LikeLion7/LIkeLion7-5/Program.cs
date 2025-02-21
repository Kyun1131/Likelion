using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIkeLion7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 접미사 사용 숫자의 데이터 형식을 명시
            int integerValue = 100; // 기본 정수형 (int)
            long longValue = 100L; // 정수형 (long)
            float floatValue = 3.14f; // 실수형 (float)
            double doublrValue = 3.14; // 기본 실수형 (double)
            decimal decimalValue = 3.14m; // 고정밀 실수형 (decimal)

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doublrValue);
            Console.WriteLine(decimalValue);


        }
    }
}
