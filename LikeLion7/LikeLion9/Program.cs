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
            //// 사용자 이름을 문자열에 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자가 이름 입력

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //// 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); // 사용자가 나이 입력
            //int age = int.Parse(input); // 문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); // 변환된 값 사용
            //Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", age+1);


            // 과제
            // 루인 스킬 피해  : 4.5% number1
            // 카드 게이지 획득량  : 3.2% number2
            // 각성기 피해  : 6.5% number3
            // 최대 마나  : 2877 number4
            // 전투 중 마나 회복량  : 101 number5
            // 비전투 중 마나 회복량  : 101 number6
            // 이동 속도  : 102.6% number7
            // 탈 것 속도  : 100.0% number8
            // 운반 속도  : 100.0% number9
            // 스킬 재사용 대기시간 감소  : 3,3% number10

            float skill = 0.0f;
            float card = 0.0f;
            float ult = 0.0f;
            int maxMP;
            int FMP;
            int NFMP;
            float speed = 0.0f;
            float rideSpeed = 0.0f;
            float carrySpeed = 0.0f;
            float coolDown = 0.0f;


            Console.Write("당신의 루인 스킬 추가 피해량을 입력하세요: ");
            skill = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량: ");
            card = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해: ");
            ult = float.Parse(Console.ReadLine());

            Console.Write("최대 마나: ");
            maxMP = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량: ");
            FMP = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량: ");
            NFMP = int.Parse(Console.ReadLine());

            Console.Write("이동 속도: ");
            speed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도: ");
            rideSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도: ");
            carrySpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소: ");
            coolDown = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\r활동                                 V ");
            Console.WriteLine($"루인 스킬 피해              : {skill}%");
            Console.WriteLine($"카드 게이지 획득량          : {card}%");
            Console.WriteLine($"각성기 피해                 : {ult}%");
            Console.WriteLine($"최대 마나                   : {maxMP}");
            Console.WriteLine($"전투 중 마나 회복량         : {FMP}");
            Console.WriteLine($"비전투 중 마나 회복량       : {NFMP}");
            Console.WriteLine($"이동 속도                   : {speed}%");
            Console.WriteLine($"탈 것 속도                  : {rideSpeed}%");
            Console.WriteLine($"운반 속도                   : {carrySpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소   : {coolDown}%");




        }
    }
}
