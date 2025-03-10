using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_28_1_1
{
    class Game
    {
        public static int Mineral;
        public static int Gas;
        public static int Pop;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄: {Mineral}, 가스: {Gas}, 인구수: {Pop}");
        }
    }
    
    // 마린 클래스를 만드세요.
    // 이름, 코스트
    // 기본 생성자, 인자있는 생성자

    /// <summary>
    /// 마린 클래스
    /// </summary>
    /// 이름: 마린, 미네랄: 50
    class Marine
    {
        
        public string Name;
        public int Cost;

        public Marine()
        {
            Name = "마린";
            Cost = 50;
        }

        public Marine(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {Cost}");
        }
    }

    /// <summary>
    /// SCV
    /// </summary>
    /// 이름: SCV, 미네랄: 
    class SCV
    {
        public string Name;
        public int Cost;

        public SCV()
        {
            Name = "SCV";
            Cost = 50;
        }

        public SCV(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {Cost}");
        }
    }
       
    /// <summary>
    /// 배럭 클래스
    /// </summary>
    /// 이름: 배럭, 미네랄: 150
    class Barracks
    {
        public string Name;
        public int Cost;

        public Barracks()
        {
            Name = "병영";
            Cost = 150;
        }

        public Barracks(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 미네랄: {Cost}");
        }
    }

    /// <summary>
    /// 미네랄 클래스
    /// </summary>
    /// Cost 1500개 기본 제공, 총 7개 존재
    class Mineral
    {
        public string Name;
        public int Max;
        public int Object;

        public Mineral()
        {
            Name = "미네랄";
            Max = 1500;
            Object = 7;
        }

        public Mineral(string name, int max, int @object)
        {
            Name = name;
            Max = max;
            Object = @object;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {Name}, 채굴 가능한 미네랄: {Max}");
        }
    }
    /*class Person 
    {
        public string Name;
        public int Age;
        /// <summary>
        /// 기본 생성자
        /// </summary>
        /// 클래스가 객체로 생성될때 자동으로 특별한 메서드
        /// 클래스와 같은 이름을 가지며, 반환형이 없다 (void도 사용하지 않음)
        /// 객체를 만들때 필요한 초기값을 설정할때 사용많이한다.
        /// 


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("매개변수있는 생성자가 실행됨");
        }
        public void ShowInfo() //기본 생성자
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }

    }*/

    class Program
    {
        static void Main(string[] args)
        {
            //클래스
            //
            //Person p1 = new Person("철수", 25); //객체 생성  instance 
            //p1.ShowInfo();

            //Person p2 = new Person("영희", 30);
            //p2.ShowInfo();

            Game.Mineral = 50;
            Game.Gas = 0;
            Game.Pop = 4;
            Game.ShowInfo();

            Marine marine = new Marine(); // 각 배열에  new 객체화
            marine.ShowInfo(); // 출력

            SCV scv = new SCV(); 
            scv.ShowInfo(); 

            Barracks barracks = new Barracks();  
            barracks.ShowInfo(); 

            Mineral[] mineral = new Mineral[7]; // 클래스의 배열 7개 생성
            for(int i=0; i<mineral.Length; i++) 
            {
                mineral[i] = new Mineral(); // 각 배열에  new 객체화
                mineral[i].ShowInfo(); // 출력
            }

        }
    }
}
