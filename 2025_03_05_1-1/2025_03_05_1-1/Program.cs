using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_05_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort
            /*string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n); // names.OrderBy(n => n) -> int Identity (int n) {return n ;}

            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A")); // A로 시작하는 첫번째 문자열을 찾는 코드

            Console.WriteLine($"First name starting with A: {firstName}");*/

            // 메서드구문, 쿼리 구문
            /*int[] nums = { 5, 3, 8, 1 };
            // 메서드 구문
            var sortedMeshod = nums.OrderBy(n => n);
            // 쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Meshod synyax: ");
            foreach (var n in sortedMeshod)
                Console.WriteLine(n);

            Console.WriteLine("Query syntax: ");
            foreach(var n in sortedQuery)
            {
                Console.WriteLine(n);
            }*/

            // select()로 길이 추출
            /*string[] words = { "apple", "banana", "cherry" };

            var lengths = words.Select(w => w.Length);

            foreach(var length in lengths)
            {
                Console.WriteLine(length);
            }*/

            // select 개념
            // LinQ 쿼리 연산자 중 하나
            // 각 요소를 변환하여 새로운 컬렉션을 생성
            /*var upperWords = words.Select(w => w.ToUpper());

            foreach (var word in upperWords)
            {
                Console.WriteLine(word);
            }*/

            // sum 알고리즘
            /*int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var d in data)
                sum += d;

            Console.WriteLine($"sum: {sum}");*/

            // count
            /*int[] data = { 1, 2, 3, 4, 5 };
            int count = data.Length; // 개수

            Console.WriteLine($"Count: {count}");*/

            // Average
            /*float[] data = { 80, 70, 60 };

            double avg = data.Average();

            Console.WriteLine($"Average: {avg:F2}");*/

            // Max
            /*int[] data = { 55, 76, 65 };
            int max = data.Max();

            Console.WriteLine($"Max: {max}");*/

            // Min
            /*int[] data = { 55, 76, 65 };

            int min = data.Min();

            Console.WriteLine($"Min: {min}");*/

            // 근삿값 구하기: NEAR 알고리즘
            // 배열에서 특정 값에 가장 가까운 값을 찾는 예제
            /*int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];

            foreach(var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearst to {target}: {nearest}");*/

            // 순위 구하기 Rank 알고리즘
            // 각 요소가 몇 번째로 큰지 순위를 매기는 예제
            /*int[] scores = { 90, 70, 50, 70, 60 };

            for (int i = 0; i < scores.Length; i++)
            {
                int rank = 1;
               
                for(int j=0; j<scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score: {scores[i]}, Rank: {rank}");
            }*/

            // 특정 값 검색하기: Search 알고리즘
            /*int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for(int i=0; i<data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }

            }
            Console.WriteLine(index >= 0 ? $"Found at index {index}": "Not found");*/

            // 그룹화하기: GROUP 알고리즘
            /*// 데이터를 특정 기준으로 그룹화하기
            // 문자열 배열 선언 (과일 이름 리스트)
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            // LINQ의 GroupBy()를 사용하여 첫 글자를 기준으로 그룹화
            var groups = fruits.GroupBy(f => f[0]); // 첫 글자로 그룹화

            // 각 그룹을 순회하며 출력
            foreach(var group in groups)
            {
                // 그룹의 Key (첫 글자) 출력
                Console.WriteLine($"Key: {group.Key}");

                // 해당 그룹에 속한 모든 요소 출력
                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }*/



        }
    }
}
