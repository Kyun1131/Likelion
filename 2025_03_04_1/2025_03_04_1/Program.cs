using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 배열과 컬레션
            // 배열 - 
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach(var num in numbers) // 끝이 없는 반복문
            //{
            //    Console.WriteLine(num);
            //}

            // 컬렉션 - 배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> names = new List<string> { "Alice", "Bob", "Cahrlie" };

            //names.Add("Dave"); // Add Dave 추가
            //names.Remove("Bob"); // Remove Bob 제외

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>(); // 리스트 생성

            //list.Add(1); // 리스트에 1추가 [1]
            //list.Add(2); // 리스트에 2추가 [1, 2]
            //list.Add(3); // 리스트에 3추가 [1, 2, 3]

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);
            //list.Insert(1, 100); // 1 다음에 100 넣기 [1, 100, 2, 3]
            //Console.WriteLine(list.Count); // 4 (현재 리스트의 요소 개수)

            //list[2] = 200; // 2를 200으로 변환 [1, 100, 200, 3]
            //list.Remove(3); // 3 제거 [1, 100, 200]

            //foreach (int i in list) // 리스트에 남은 요소 순차적으로 출력
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list.Count); // 3 (현재 리스트의 요소 개수)


            // Stack
            // Stack은 마지막에 추가된 요소가 가장 먼저 제거됨 (Last in, Fist out)
            //Stack stack = new Stack(); // Stack 객체 생성

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3); // Stack에 1, 2, 3 차례대로 추가

            //while (stack.Count > 0) // Stack.Count가 0보다 클 때 반복 실행
            //{
            //    Console.WriteLine(stack.Pop()); // 가장 최근에 추가된 요소가 먼저 제거 되면서 출력
            //}


            // Queue
            // Queue는 Stack과는 반대로 먼저 추가된 요소가 가장 먼저 제거됨 (Fist in, Fist out)
            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3); // Queue에 1, 2, 3 차례대로 추가

            //while (queue.Count > 0) // queue.Count가 0보다 작을 때까지 반복 실행
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //
            //Queue queue = new Queue(); // 큐 객체 생성

            //queue.Enqueue("→"); 
            //queue.Enqueue("↓");
            //queue.Enqueue("↘");
            //queue.Enqueue("→");
            //queue.Enqueue("풍신권"); // 큐에 요소를 차례대로 추가

            //while (queue.Count > 0) // 큐가 0보다 클 때 반복 실행
            //{
            //    Console.WriteLine(queue.Dequeue()); // 큐에 요소가 들어온 순서대로 출력
            //}

            //Console.WriteLine(queue.Count); // 요소가 얼마나 남았는지 출력


            // ArrayList
            // 크기가 동적으로 조절이 되는 배열, 다양한 
            //ArrayList arrayList = new ArrayList(); //ArrayList 객체 생성

            //// 요소 추가
            //arrayList.Add(1); // int 정수 추가
            //arrayList.Add("Hello"); // string 문자열 추가
            //arrayList.Add(3.14); // float 실수 추가

            //// 요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //// 요소 제거
            //arrayList.Remove(1);

            //// 요소 접근
            //Console.WriteLine("\n요소 제거 후: ");

            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            // Hashtable 클래스
            // 키-값 쌍을 저장하는 컬렉션, 키룰 이용해 값을 빠르게 검색
            //Hashtable hashtable = new Hashtable(); // 해쉬테이블 객체 생성

            //// 키-값 쌍 추가
            //hashtable["Alice"] = 25; 
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소: ");

            //foreach(DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}

            //// 특정 키의 값 가져오기
            //Console.WriteLine($"\nAlic의 나이 {hashtable["Alice"]}");

            //// 요소 제거
            //hashtable.Remove("Bob");

            //// 요소 접근
            //Console.WriteLine("\nHashtable 요소: ");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}

        }
    }
}
