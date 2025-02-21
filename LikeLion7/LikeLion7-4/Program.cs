using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; // 단정밀도 실수
            double doublePrecision = 3.1415926535; // 배정밀도 실수 (4바이트)
            decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도 (16바이트)

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);


        }
    }
}
