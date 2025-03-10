using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_03_05_1_2
{
    // 부모 클래스
    class Animal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    // 자식 클래스
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }


    }

    /*class Player
    {
        public string name;

        public void Render()
        {
            Console.WriteLine("플레이어: " + name);
        }

    }*/

    /*class Wizard: Player
    {
        public string job;

        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            // 다운캐스팅(Downcasting)
            // 불완전함
            Animal myAnimal = new Dog();
            //Dog myDog = (Dog)myAnimal; // 다운캐스팅(명시적 변환)

            Dog myDog = myAnimal as Dog;

            if (myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

            //Animal myAnimal2 = new Animal();
            //Dog myDog = (Dog)myAnimal2;

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark(); //실행
            }
            else
            {
                Console.WriteLine("변환할수 없습니다.");



                // 업캐스팅(Upcasting)
                /*// 자식 클래스 -> 부모 클래스로 변환하는 것
                // 암시적 변환이 가능
                Dog myDog = new Dog(); // 자식 클래스 객체 생성
                Animal myAnimal = myDog; // 업 캐스팅

                myAnimal.Speak(); // 사용 가능*/

                // 상속 클래스
                /*Animal myAnimal = new Animal();
                myAnimal.Name = "일반동물";
                myAnimal.Speak(); //부모클래스의 기본메서드 실행


                Dog myDog = new Dog();
                myDog.Name = "바둑이";
                myDog.Speak();  //오버라이딩된 메서드 실행*/


                /*Player p = new Player();

                p.name = "홍길동";
                p.Render();

                Wizard w = new Wizard();

                w.name = "멀린";
                w.job = "마법사";

                w.Render();
                w.Render2();*/



            }
        }
    }
}
