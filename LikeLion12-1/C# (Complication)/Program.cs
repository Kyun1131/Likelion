using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C___Complication_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// 출력하는 법 
            Console.WriteLine("깃허브 연결하기");*/




            /*// 변수
            // 변수 선언 : 데이터 타입과 변수 이름을 지정합니다.
            int age; // 정수형 변수 age 선언
            age = 25; // 변수에서 값 저장

            Console.WriteLine(age); // 변수에 저장된 값을 출력*/




            /*// 리터럴
            // 리터럴: 코드에서 고정된 값을 의미합니다.
            int number = 10; //  정수형 리터럴
            double pi = 3.14; // 실수형 리터럴
            char letter = 'A'; // 문자 리터럴
            string name = "Alice"; // 문자열 리터럴

            Console.WriteLine(number); // 출력: 10
            Console.WriteLine(pi);     // 출력: 3.14
            Console.WriteLine(letter); // 출력: A
            Console.WriteLine(name);   // 출력: Alice*/




            /*//실습
            // 간단한 캐릭터 정보 
            int hp = 100; // hp : 100
            double att = 56.7; // att : 56.7
            string name = "??"; // 캐릭터 이름 : ??
            char grade = 'S'; // 등급 : S

            Console.WriteLine("캐릭터");
            Console.WriteLine("캐릭터 이름 : " + name);
            Console.WriteLine("등급 : " + grade);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);*/




            /*// 변수 선언 후 값 저장 후 사용하기
            //  변수 선언 후 값 저장
            string greeting; // 문자열 변수를 선언
            greeting = "Hello, World!"; // 변수에 값을 저장

            Console.WriteLine(greeting); //출력 : Hello, World!*/




            /*// 변수 선언과 동시에 초기화하기
            // 변수 선언과 초기화를 한번에 수행
            int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; // 문자열 변수 선언과 초기화

            Console.WriteLine(score); // 출력 100
            Console.WriteLine(temperature); // 출력 36.5
            Console.WriteLine(city); // 출력 : seoul*/




            /*// 같은 데이터 타입의 변수를 쉼표로 구분해 한 번에 선언
            int x = 10, y = 20, z = 30; // 정수형 변수 x, y, z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/




            /*//
            const double Pi = 3.14159;
            const int MaxScore = 100;

            // 출력
            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("Max Score : " + MaxScore);*/




            /*// 숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10; // 정수 데이터
            float floatNum = 3.14f; // 단정밀도 실수
            double doubleNum = 3.14159; // 배정밀도 실수

            // 출력
            Console.Write(integerNum); //출력: 10
            Console.WriteLine(floatNum); //츨력: 3.14
            Console.WriteLine(doubleNum); //출력: 3.14159*/




            /*// 정수 데이터형식: 소수점이 없는 숫자를 표현
            int intValue = -100; // 4바이트 크기의 정수
            long longValue = 1234567890L; // 8바이트 크기의 정수

            //출력
            Console.WriteLine(intValue); // 출력: -100
            Console.WriteLine(longValue); // 출력: 123456789*/




            /*// 부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50; // 1바이트
            short signedShort = -32000; // 2바이트
            int signrdInt = -200000000; // 4바이트

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signrdInt);*/




            /*//부호 없는 정수 데이터 형식 
            byte unsignedByte = 255; // 1바이트 크기
            ushort unignrdShort = 65000; // 2바이트 크기
            uint unsignedInt = 4000000000; // 4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unignrdShort);
            Console.WriteLine(unsignedInt);*/




            /*// 실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; // 단정밀도 실수
            double doublePrecision = 3.1415926535; // 배정밀도 실수 (4바이트)
            decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도 (16바이트)

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrecision);*/




            /*// 접미사 사용 숫자의 데이터 형식을 명시
            int integerValue = 100; // 기본 정수형 (int)
            long longValue = 100L; // 정수형 (long)
            float floatValue = 3.14f; // 실수형 (float)
            double doublrValue = 3.14; // 기본 실수형 (double)
            decimal decimalValue = 3.14m; // 고정밀 실수형 (decimal)

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doublrValue);
            Console.WriteLine(decimalValue);*/




            /*// char 형식: 단일 문자를 표현
            char letter = 'A'; // 문자 'A' 저장
            char symbol = '#'; // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number);*/




            /*//string 형식: 여러 문자를 저장
            string greeting = "Hello World";
            string name = "Alice";

            Console.WriteLine(greeting);
            Console.WriteLine(name);

            //Hello World Alice 만들기
            Console.WriteLine("Hello World Alice"); // me
            Console.WriteLine(greeting + " " + name); // 강사님 방법*/




            /* // bool형식: 참(True) 또는 거짓(Fasle)
             bool isrunning = true;
             bool isfinished = false;

             Console.WriteLine(isrunning);
             Console.WriteLine(isfinished);*/




            /*//const: 변하지 않는 값을 정의
            const double Pi = 3.14159; // 원주율
            const int MaxScore = 100; // 최대 점수

            Console.WriteLine(Pi);
            Console.WriteLine(MaxScore);
            // Pi = 3.14*/




            /*// 닷넷 형식 : 기본 형식의 닷넷 표현
            System.Int32 number = 123;
            System.String text = "Hello";
            System.Boolean flag = true;

            Console.WriteLine(number);
            Console.WriteLine(text);
            Console.WriteLine(flag);*/




            /*//int 래퍼 형식의 메서드 활용
            int number = 123;

            string numberAsString = number.ToString();

            bool 래퍼 형식의 메서드 활용
            bool flag = true;

            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);*/





            /*// 사용자 이름을 문자열에 받기
            Console.Write("이름을 입력하세요: ");
            string userName = Console.ReadLine(); // 사용자가 이름 입력

            Console.WriteLine($"안녕하세요, {userName}님!");

            // 문자열을 정수로 변환
            Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine(); // 사용자가 나이 입력
            int age = int.Parse(input); // 문자열을 정수로 변환

            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); // 변환된 값 사용
            Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            Console.WriteLine("내년에는 {0}살이 되겠군요!", age + 1);*/




            /*// 과제
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
            Console.WriteLine($"스킬 재사용 대기시간 감소   : {coolDown}%");*/




            /*// 단항 연산자
            int number = 5;
            bool flag = true;

            Console.WriteLine(+number);
            Console.WriteLine(-number);

            Console.WriteLine(!flag);*/




            /*// 변환 연산자: () 기호로 데이터 형식 변환하기
            // 캐스팅
            double pi = 3.14;
            int integerPi = (int)pi; // 실수를 정수로 변환

            Console.WriteLine(integerPi);*/




            /*// 산술 연산자
            int a = 10, b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/




            /*// 예시
            int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath; // 총점
            average = (float)sum / 3; // 평균 (소수점이 필요하여 flaot 넣기! 

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + average);*/




            /*// 문자열 연결 연산자
            string fistName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(fistName + " " + lastName);*/




            /*// 할당 연산자
            // =, +=, -=, /=, %=
            int a = 10;
            a += 5; // a = a + 5;
            Console.WriteLine(a);
            a -= 5; // a = a - 5;
            Console.WriteLine(a);
            a *= 5; // a = a * 5;
            Console.WriteLine(a);
            a /= 5; // a = a / 5;
            Console.WriteLine(a);
            a %= 5; // a = a % 5;
            Console.WriteLine(a);*/




            /*// 증감 연산자
            //++, -
            int b = 3;

            b++; // 후위 증가
            Console.WriteLine(b);

            --b; // 전위 감소
            Console.WriteLine(b);

            // 전위 ++b, 후위 b++ 다음 숫자부터 +1
            ++b;
            Console.WriteLine("b의 값은 : " + b);
            b++;
            Console.WriteLine("b의 값은 : " + b);*/




            /*// 오전 수업 내용 복습 문제
            // 1. 학점 평균  계산  프로그램
            Console.WriteLine("|---------학점 계산 프로그램----------|");
            Console.Write("당신의 국어 점수를 입력해 주세요. : ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("당신의 영어 점수를 입력해 주세요. : ");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("당신의 수학 점수를 입력해 주세요. : ");
            int math = int.Parse(Console.ReadLine());

            int sum = 0;
            sum = kor + eng + math;
            float average = (float)sum / 3;

            Console.WriteLine($"당신의 총점은 {sum}점 입니다.");
            Console.WriteLine($"당신의 평균 점수는 {average}점 입니다.");

            // 2. 비트 반전(~) 연산자 프로그램
            Console.WriteLine("\n|-------------비트 반전--------------|");
            Console.Write("정수를 입력해 주세요. : ");
            int num = int.Parse(Console.ReadLine());

            int result = ~num;

            Console.WriteLine("입력 값 : " + num);
            Console.WriteLine("반전 값: " + result);*/



            /*// 관계형 연산자
            //두 값을 비교하여 관계를 평가한다.
            // == 같다, != 같지 않다, >= 왼쪽항이 오른쪽 항보다 크거나 같다, <= 오른쪽항이 왼쪽 항보다 크거나 작다
            int x = 5, y = 10;

            Console.WriteLine(x < y); // true
            Console.WriteLine(x == y); // false
            Console.WriteLine(x != y); // true
            Console.WriteLine(x >= y); // false
            Console.WriteLine(x <= y); // true*/




            /*// 논리형 연산자
            // &&, || , !
            bool a = true;
            bool b = false;

            // <&&>
            Console.WriteLine(a && b);
            // AND : t : t  t
            //       t : f  f
            //       f : f  f
            //       f : t  f
            // AND는 무조건 둘 다 true일때만 통과 가능.

            // <||>
            Console.WriteLine(a || b);
            // OR : t : t  t
            //      t : f  t
            //      f : t  t
            //      f : f  f
            // true가 포함 되어 있으면 통과 가능.

            // <!>
            Console.WriteLine(!a); // NOT : 선언을 고치지 않아도 bool 값을 바꿔줌.*/




            /*//비트 연산자
            int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine(x & y); // AND : 1 (0001)
            Console.WriteLine(x | y); // OR : 7 (0111)
            Console.WriteLine(x ^ y); // XOR : 6 (0110) XOR 같은 수끼리 더하면 0, 다른 수끼리 더하면 1
            Console.WriteLine(~x); // NOT : -6*/




            /*// 시프트 연산자
            // 비트를 좌우로 이동시킴 (<<,>>)
            int value = 4; // 0100

            Console.WriteLine(value << 1); // 왼쪽으로 이동 : 8 (1000)
            Console.WriteLine(value >> 0); // 오른쪽으로 이동 : 2 (0010)*/




            // 기타 연산자
            // ? : 삼항 연산자 - 조건문을 간단히 표현.
            // is : 객체가 특정 형식인지 확인.
            // ?? : null 병합 연산자.

            /*// ? 예제 : 삼항 연산자 예제 
            int a = 10, b = 20;
            int max;
            max = (a < b) ? a : b; // max = (비교) ? 참 : 거짓;

            Console.WriteLine(max);*/

            /*// ?예제2 : 삼항 연산자 예제2
            int key1 = 2;

            string str;
            str = (key1 == 2) ? "문이 열렸습니다." : "문을 못열었습니다.";

            Console.WriteLine(str);*/




            /*// 연산자 우선순위
            // 연산자는 혼합계산의 우선순위를 따라간다.
            // 괄호를 사용하여 우선순위는 명시적으로 지정할 수 있습니다.

            int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            int adjustedResult = (10 + 2) * 5; // 괄호로 우선순위 먼저 계산

            Console.WriteLine(result);
            Console.WriteLine(adjustedResult);*/




            // 제어문
            // 순차문
            // 조건문
            /*int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score  >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }*/




            /*string GameID = "멋사검존";

            if (GameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }*/




            // 학점 평가
            /*Console.Write("당신의 학점을 입력해 주세요 : ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }*/



            // 2025.02.25

            // swith문 사용하기
            // if문과 기능은 같지만 if문보다 많은 코드를 작성할 때 용이하다.

            /*int day = 3;  // case 3

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }*/



            // for문으로 반복하기
            /*for (int i= 1; i <= 5; i++) // 초기화; 조건문; 증감식;
            {
                Console.WriteLine($"숫자: {i}");
            }*/


            // for문으로 무한 반복하기
            // 1. 뚜따식
            /*for (; ; )
            {
                Console.WriteLine("무한 루프 실행");
            }*/

            //2. while사용
            /*int count = 0; // 초기화
            while (true) // 조건식
            {
                Console.WriteLine("무한 루프 실행");
                count++; // 증가, 감소

                if (count == 3) break; // 무한 루프 탈출 조건
            }*/


            // for문으로 1부터 4까지 팩토리얼 값 출력하기



            // 랜덤
            /*Random rand = new Random();*/ // Random 객체를 생성한다.

            // 랜덤에 반복문 사용

            /*int randomInrange = 0;
            for(int i =0; i<100; i++)
            {
                randomInrange = rand.Next(5, 15);
                Console.WriteLine("5부터 14까지: " + randomInrange);
            }*/


            ////////////


            // 배열 - 동일한 데이터 타입의 연속된 집합.
            // 반복문이랑 많이 사용

            /*int[] num = new int[3]; // 3개의 메모리를 만들겠다고 선언. new = 메모리 할당

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            for(int i =0; i<3; i++)
            {
                Console.WriteLine(num[i]);
            }*/


            // 다양한 배열 선언 방법
            /*int[] numbers = { 1, 2, 3 }; // 간단한 선언과 초기화
            int[] numbers2 = new int[3]; // 크기만 지정 선언
            int[] numbers3 = new int[] { 1, 2, 3 }; // 초기화와 함께 선언

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/



            // string을 이용한 배열
            /*string[] fruits = { "사과", "바나나", "오렌지" };

            for(int i =0; i<3; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/




            // 문제잇
            // 국어, 수학, 영어 점수를 입력 받고
            // 총점과 평균을 출력하세요

            /*int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];

            // 입력 받기
            for(int i =0; i<3; i++)
            {
                Console.Write("성적을 입력해주세요: ");
                Console.Write("\n국어: ");
                iKor[0] = int.Parse(Console.ReadLine());
                Console.Write("영어: ");
                iEng[0] = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                iMath[0] = int.Parse(Console.ReadLine());

                sum[i] += iKor[i] + iEng[i] + iMath[i];

                aver[i] = (float)sum[i] / 3;
            }

            // 출력
            for(int i =0; i<3; i++)
            {
                Console.WriteLine((i+1)+"번학생");
                Console.WriteLine($"국어: {iKor[i]} 영어: {iEng[i]} 수학: {iMath[i]}");
                Console.WriteLine("총점: " + sum[i]);
                Console.WriteLine("평균: " + aver[i].ToString("F2"));
            }*/


            // 1차원 배열
            /*int[] scores = new int[3];

            scores[0] = 90;
            scores[0] = 85;
            scores[0] = 88;


            for(int i=0; i<scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + i}:{scores[i]}");
            }*/


            /*double value = 123.456789;
            // 소수점 자리수 설정하는 포맷
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점둘째자리: {value:F2} ");
            Console.WriteLine(String.Format("소수점 둘째 자리: {0:F2}", value));
            // 소수점 없이 정수 출력
            Console.WriteLine(value.ToString("F0"));*/

            // 출력 포맷
            /*double value = 12341234.123412;

            Console.WriteLine(value.ToString("N2"));*/


            // 2차원 배열 선언
            /*int[,] matrix = new int[2, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            for(int i=0; i<2; i++)
            {
                Console.WriteLine("i = " +i);
                for(int j=0; j<3; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/


            /*int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[3];

            // 값 입력
            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;

            // 출력
            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }*/


            // 6. 가변배열
            /*Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            for(int i=0; i<jaggedArray.Length; i++)
            {
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedArray[i][j]}");
                    Console.WriteLine();
                }

                Console.WriteLine("var 키워드 사용");
                var number = new[] { 1, 3, 4, 5 };
                Console.WriteLine($"배열 타입: {number.GetType()}");
            }*/


            /*// foreach
            string[] fruits = { "사과", "바나나", "체리" };

            // 반복문
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/



        }
    }
}
