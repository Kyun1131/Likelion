using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_04_1_1
{
    class Program
    {
        // Generics
        //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들 수 있음
        /*class Cup<T>
        {
            public T Content { get; set; }
        }*/


        // IEnumerator
        /*public interface IEnumerator
        {
            bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환
            object Current { get; } // 현재 요소 반환
            void Reset(); // 처음 위치로 리셋
        }*/


        //
        /*class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }*/



        static void Main(string[] args)
        {
            // Generics
            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"CupOfInt: {cupOfInt.Content}");*/


            // List<string>
            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" }; // 리스트 객체 생성과 동시에 요소 추가
            names.Add("Dave"); // 요소 추가

            foreach(var name in names) // foreach로 요소를 순차적으로 반복 실행
            {
                Console.WriteLine(name); // 요소 출력
            }*/


            // IEnumerator를 사용하는 이유
            // 컬렉션을 직접 제어하며 순회할 수 있음, foreach 없이도 컬렉션 순회 가능, LINQ나 커스텀 컬렉션을 만들 때 유용함
            /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            IEnumerator enumerator = list.GetEnumerator(); // 열거자 가져오기

            while (enumerator.MoveNext()) // 다음 요소가 있는지 확인
            {
                Console.WriteLine(enumerator.Current); // 현재 요소 출력
            }*/


            //
            /*var collection = new SimpleCollection();

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }*/


            // 
            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["철도끼"] = 1;

            foreach (var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/


            // null 값
            // 참조 형식 null을 가질 수 있으며, 값 형식은 기본적으로 null을 가질 수 없습니다.
            /*string str = null;

            if (str == null)
            {
                Console.WriteLine("str is null");
            }

            int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/


            // null 값을 다루는 연산자 소개하기 ??, ?. 연산자
            // ?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?.은 null안전 접근을 합니다.
            /*string str = null;

            Console.WriteLine(str ?? "DefaultValua"); // str이 null이면 "Default Value"

            //str = "Holle";

            //Console.WriteLine(str.Length); //str이 null이 아니므로 길이 출력

            if (str != null)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("DafaultValue");
            }*/


            // LINQ
            // 링큐는 확장 메서드 형태로 제공된다.
            // LINQ (Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있습니다.
            /*int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }*/

        }
    }
}
