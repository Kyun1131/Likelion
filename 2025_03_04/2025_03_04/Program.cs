using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _2025_03_04
{

    class Program
    {
        // 클래스 시그니처
        // C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

        // [접근 지정자] [수정자] class 클래스 이름: 부모 클래스, 인터페이스 
        // public 공개    (abstract)             : BaseClass , IComparable
        // private 비공개 (sealed)
        // protected 상속 (static)
        //                (partia)

        //public class Player
        //{
        //    public string Name { get; set; }
        //    public int Score { get; set; }
        //}

        //public class Warrior : Player
        //{
        //    public int Strength { get; set; }
        //}
        // 인터페이스를 구현하는 클래스

        //public class Enemy: IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }
        //}
        // 추상 클래스 (abstract)

        //public abstract class Animal
        //{
        //    public abstract void MakeSound();
        //}

        static void Main(string[] args)
        {
            // Environment 프로그램 종료
            //Console.WriteLine("Exiting the program...");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0);


            // Random 랜덤 클래스
            //Random random = new Random();

            //int randomNumber = random.Next(1, 101);
            //Console.WriteLine("랜덤 숫자: " + randomNumber);


            // 프로그램 실행 시간 구하기
            //Stopwatch stopwatch = Stopwatch.StartNew();

            //for (int i = 0; i<1000000; i++) // 실행 코드
            //{
            //    Thread.Sleep(100);
            //}

            //stopwatch.Stop();

            //Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");


            // 정규식
            //string input = " Hrllo, my phone number is 010-0000-0000.";
            //string patter = @"\d{3}-\d{4}-\d{4}";

            //bool isMatch = Regex.IsMatch(input, patter);
            //Console.WriteLine($"전화번호가 존재하는가? {isMatch}");


            //
            //

            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType: {valueType}"); // 20
            //Console.WriteLine($"ReferenceType: {referenceType}");


            // 박싱 언박싱
            // 값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)
            //int value = 42;
            //object boxed = value; // 박싱
            //int unboxed = (int)boxed; // 언박싱

            //Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}");


            // is 연산자 형식 비교하기
            // 객체가 특정 형식인지 확인할 수 있다.
            //object obj = "Hello";

            //Console.WriteLine(obj is string); // true
            //Console.WriteLine(obj is int); // false


            // as 연산자로 형식 변환하기
            // as 연산자를 사용해 안전하게 형 변환을 수행한다.
            //object obj = "Hello";
            //string str = obj as string;

            //Console.WriteLine(str is string);


            //var obj = 42; // obj는 int형이다.

            //if (obj is int number) // 만약 obj가 int형이면 number로
            //{
            //    Console.WriteLine($"Number: {number}"); // Number: 42
            //}
            //else // int형이 아니라면
            //{
            //    Console.WriteLine("Not a number"); // Not a number
            //}


            // 문자열 다루기
            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); // Hello, Alice

            //Console.WriteLine($"Length of name: {name.Length}"); // 문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); // 대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); // 부분 문자열


            // string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome': {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#': {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is': {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great': {text.Replace("awesome", "great")}"); 

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());


            // String과 StringBuilder클래스 성능차이 비교
            // 반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.
            //int iterations = 10000;
            //Stopwatch sw = Stopwatch.StartNew();
            //string text = "";

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");
            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");


            // 예외 처리하기
            // 예외는 프로그램 실행 중 발생하는 오류 입니다. 예외를 처리하면 프로그램이 중단되지 않고,
            // 실행을 계속할 수 있습니다.
            // try catch - 오류가 발생시 프로그램을 중단하지 않고 계속 실행시키는 예외 처리문
            //try
            //{
            //    int[] numbers = { 1, 2, 3, };
            //    Console.WriteLine(numbers[5]); // 오류 발생
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            // fially 블록은 예외 발생여부와 상관없이 항상 실행됩니다.
            //try
            //{
            //    int number = int.Parse("NotANumber"); // 오류 발생
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("항상 실행 됩니다.");
            //}


            // Exception 클래스
            // 모든 예외의 기본 클래스 입니다.
            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error: {ex.Message}");
            //}


            // throw 구문으로 직접 예외 발생시키디
            //try
            //{
            //    int age = -5;
            //        if (age < 0)
            //    {
            //        throw new ArgumentException("Age Cannot be negative");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //}


            

        }
    }
}
