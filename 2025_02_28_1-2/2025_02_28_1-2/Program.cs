using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2025_02_28_1_2
{
    /*class Person
    {
        private string name;

        public void SetName(string newName)
        {
            name = newName;
        }

        // 세터(Setter)함수 - 값 설정하기 
        public string GetName()
        {
            return name;
        }
    }*/

    /*class Person
    {
        private string name; // 내부 변수
        public string Name // 프로퍼티
        {
            get { return name; } // Getter
            set { name = value; } // Setter
        }
    }*/

    // 프로퍼티 자동 구현
    /*class Person
    {
        private int count = 100;
        public string Name { get; set; } // 자동 구현 프로퍼티

        public int Count
        {
            get { return count; } // 읽기만 가능
        }

        public float Balance { get; private set; } // 외부 변경 불가

        public void AddBal()
        {
            Balance += 100;
        }
    }*/

    class Marine
    {
        public string Name { get; private set; } = "마린";
        public int Cost { get; set; } = 50;
        public int Pop { get; set; } = 1;

    }

    class Program
    {
        static void Main(string[] args)
        {
            // get, set 캡슐화에 자주 쓰임.
            // get/set 방식의 함수와 프로퍼티 비교
            // C#에서는 객체의 값을 읽고(get), 설정(set)하는
            // 방식으로 함수(get/set 메서드) 또는
            // **프로퍼티(Property)**를 사용할 수 있습니다.

            /*Person p = new Person();

            p.Name = ("홍길동");
            p.AddBal();

            Console.WriteLine("이름: " + p.Name+"Count: "+p.Count+"Balanc"+p.Balance);*/
            Marine m = new Marine();

            Console.WriteLine($"이름: {m.Name}, 비용: {m.Cost}, 인구수: {m.Pop}");

        }
    }
}
