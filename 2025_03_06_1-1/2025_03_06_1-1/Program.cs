using Bae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bae
{
    class Family
    {
        public string Name;
        public string Sex;
        public int Age;
        public string MariStatus;

        public Family(string name, string sex, int age, string maristatus)
        {
            Name = name;
            Sex = sex;
            Age = age;
            MariStatus = maristatus;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n검색하신 {Name}님은 {Sex}, {Age}살, {MariStatus}입니다.");
        }
    }

    class BaeSangKyun : Family
    {
        public BaeSangKyun() : base("배상균", "남", 27, "미혼") { }
    }

    class BaeSangMin : Family
    {
        public BaeSangMin() : base("배상민", "남", 24, "미혼") { }
    }

    class BaeYouJin : Family
    {
        public BaeYouJin() : base("배유진", "여", 20, "미혼") { }
    } 

    class Familytree
    {
        static void Main(string[] args)
        {
            List<Family> family = new List<Family>
            {
                new BaeSangKyun(),
                new BaeSangMin(),
                new BaeYouJin()
            };

            while (true)
            {
                Console.Write("궁금하신 가족의 이름을 검색해 주세요: ");
                string searchName = Console.ReadLine();

                Family foundFamily = family.Find(f => f.Name == searchName);

                if (foundFamily != null)
                {
                    foundFamily.DisplayInfo();
                    break;
                }
                else
                {
                    Console.WriteLine("\n존재하지 않는 이름입니다.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            
            
        }
    }


}

namespace _2025_03_06_1_1
{

}
