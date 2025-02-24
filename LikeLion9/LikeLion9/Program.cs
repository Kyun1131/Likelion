using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이진수를 정수로 전환
            Console.Write("2진수를 입력하세요: ");
            string binayInput = Console.ReadLine(); // 입력받는다 문자열
            int decimalValue = Convert.ToInt32(binayInput, 2); // 2진수 -> 10진수로 전환
            // 정수를 이진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수

            Console.WriteLine($"입력한 이진수 : {binayInput}");
            Console.WriteLine($"10진수로변환 : {decimalValue}");
            Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");


        }
    }
}
