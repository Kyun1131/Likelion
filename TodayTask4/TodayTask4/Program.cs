using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TodayTask4
{
    /// <summary>
    /// 문제.0-1
    /// </summary>
    /*struct Subject
    {
        public string Name;
        public int iKor;
        public int iEng;
        public int iMath;

        public void Print()
        {
            Console.WriteLine($"{Name,-3} {iKor,5}{iEng,7}{iMath,8}");
        }
    }*/



    class Program
    {
        /// <summary>
        /// 문제.0
        /// </summary>
        /*enum Weapontype
        {
            Sword,
            Bow,
            Staff
        }*/

        /*static void ChooseWeapon(Weapontype weapon)
        {
            if(weapon == Weapontype.Sword)
            {
                Console.WriteLine("검을 선택했습니다.");
            }
            else if(weapon == Weapontype.Bow)
            {
                Console.WriteLine("활을 선택했습니다.");
            }
            else if(weapon == Weapontype.Staff)
            {
                Console.WriteLine("스태프를 선택했습니다.");
            }
        }*/


        ///<summary>
        /// 12
        /// </summary>
        /*//최대 아이템 개수(배열 크기)
        const int MAX_ITEMS = 10;

        //아이템 배열 (이름 저장)
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];


        //아이템 추가 함수
        static void AddItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)  //이미 있는 아이템이면 개수 증가
                {
                    itemCounts[i] += count;
                    return;
                }
            }

            //빈 슬롯에 새로운 아이템 추가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");

        }

        static void RemoveItem(string name, int count)
        {
            for (int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] ==name) // 이름하고 같은지 확인
                {
                    if (itemCounts[i] >= count)
                    {
                        itemCounts[i] -= count;
                        if (itemCounts[i] == 0) // 개수가 0개면 삭제
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }
            }
        }

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리: ");
            bool isEmpty = true;

            for(int i=0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]}) ");
                    isEmpty = false;
                }

                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }
        }*/

        

        static void Main(string[] args)
        {
            /// <summary>
            /// 문제.0
            /// </summary>
            ///열거형과 함수를 이용해서 풀어주세요.
            ///Weapontype.Sword 검을 선택했습니다.
            ///Weapontype.Bow 활을 선택했습니다.
            ///Weapontype.Staff 지팡이를 선택했습니다.
            ///출력:  활을 선택했습니다.
            /*ChooseWeapon(Weapontype.Bow);*/


            /// <summary>
            /// 문제.0-1
            /// </summary>
            /// 구조체를 이용하여 학생 3명의 이름 성적을 받고 국어, 영어, 수학 점수를 출력 하시오.
            /// {이름, 국어, 영어, 수학}
            /// 홍길동, 100, 80, 70
            /// 홍길란, 90, 10, 20
            /// 홍길순, 20, 55, 70
            /// 
            /*Subject[] subjct = new Subject[3];

            for(int i=0; i<subjct.Length; i++)
            {
                Console.WriteLine("성적을 입력하세요.");
                Console.Write("이름: ");
                subjct[i].Name = Console.ReadLine();
                Console.Write("국어: ");
                subjct[i].iKor = int.Parse(Console.ReadLine()); // int.Parse 정수 받을때 필요! *string엔 불필요*
                Console.Write("영어: ");
                subjct[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                subjct[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름     국어   영어    수학");

            foreach(Subject sub in subjct)
            {
                sub.Print();
            }*/


            ///<summary>
            /// 12
            /// </summary>
            /*AddItem("포션", 5);
            AddItem("칼", 1);
            AddItem("포션", 3); // 포션 대수 추가

            ShowInventory();

            // 아이템 사용
            Console.WriteLine("포션 2개 사용");
            RenoveItem("퍼션", 2);
            ShowInventory();

            //테스트: 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);
            ShowInventory();

            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용 (초과 사용 테스트");
            RemoveIten("퍼션", 6);
            ShowInventory();*/
        }
    }
}
