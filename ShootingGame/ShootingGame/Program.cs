using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame
{

    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player // 플레이어 클래스
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;   //플레이어 X좌표
        public int playerY;   //플레이어 Y좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;

        public Player()
        {
            playerX = 0; // 플레이어 x좌표 
            playerY = 12; // 플레이어 y좌표

            for(int i = 0; i < 20; i++) // 총알 발사
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;

            }
        }

        public void GameMain()
        {
            KeyControl(); // 키 입력
            PlayerDraw(); // 캐릭터
            UIscore(); // 점수
            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl() // 키 입력을 받는 곳
        {
            int pressKey; // 정수형 변수선언 키값 받을거

            if (Console.KeyAvailable) // 키가 눌렸을 때 true
            {
                pressKey = _getch(); // 아스키 값 받아옴 ({난 아스키값이 먼지 모름}, {구글링 ㄱㄱ}, {님 천재임?})

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72: // 위쪽 화살표키 (아스키코드)
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;

                    case 75: // 왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;

                    case 77: // 오른쪽 화살표키
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;

                    case 80: // 아래 화살표키
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;

                    case 32: // 스페이스바
                        for(int i=0; i < 20; i++) // 총알 발사
                        {
                            if (playerBullet[i].fire == false) // 미사일이 false 발사가능
                            {
                                playerBullet[i].fire = true; 
                                playerBullet[i].x = playerX + 5; // 플레이어 앞에서 미사일 쏘기 +5
                                playerBullet[i].y = playerY + 1; // 미사일 발사 지점 가운데로 옮기기
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++) // 총알2 발사
                        {
                            if (playerBullet2[i].fire == false) // 미사일이 false 발사가능
                            {
                                playerBullet2[i].fire = true;
                                playerBullet2[i].x = playerX + 5; // 플레이어 앞에서 미사일 쏘기 +5
                                playerBullet2[i].y = playerY; // 미사일 발사 지점 가운데로 옮기기
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++) // 총알3 발사
                        {
                            if (playerBullet3[i].fire == false) // 미사일이 false 발사가능
                            {
                                playerBullet3[i].fire = true;
                                playerBullet3[i].x = playerX + 5; // 플레이어 앞에서 미사일 쏘기 +5
                                playerBullet3[i].y = playerY + 2; // 미사일 발사 지점 가운데로 옮기기
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void BulletDraw() // 총알
        {
            string bullet = "  >"; // 미사일 표현

            for (int i = 0; i < 20; i++) // 20발 발사
            {
                if (playerBullet[i].fire == true && playerBullet[i].x < 80)
                {
                    Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y); // 좌표 설정 -> 중간위치를 위해 보정을 위해 x-1

                    Console.Write(bullet); // 총알 출력

                    playerBullet[i].x++; // 미사일 오른쪽으로 날아가기

                    if (playerBullet[i].x > 79)
                    {
                        playerBullet[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = ">"; // 미사일 표현

            for (int i = 0; i < 20; i++) // 20발 발사
            {
                if (playerBullet2[i].fire == true && playerBullet2[i].x <80)
                {
                    Console.SetCursorPosition(playerBullet2[i].x, playerBullet2[i].y); // 좌표 설정 -> 중간위치를 위해 보정을 위해 x-1

                    Console.Write(bullet); // 총알 출력

                    playerBullet2[i].x++; // 미사일 오른쪽으로 날아가기

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = ">"; // 미사일 표현

            for (int i = 0; i < 20; i++) // 20발 발사
            {
                if (playerBullet3[i].fire == true && playerBullet3[i].x < 80)
                {
                    Console.SetCursorPosition(playerBullet3[i].x, playerBullet3[i].y); // 좌표 설정 -> 중간위치를 위해 보정을 위해 x-1

                    Console.Write(bullet); // 총알 출력

                    playerBullet3[i].x++; // 미사일 오른쪽으로 날아가기

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }




        public void PlayerDraw() // 캐릭터 그리기 
        {
            String[] player = new string[] // 배열 문자열로 캐릭터 그리기
            {
                ">->",
                " >--->",
                ">->"

            };

            for(int i=0; i<player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i); // 콘솔좌표 설정 (플레이어x, 플레이어y)

                Console.WriteLine(player[i]); // 문자열 배열 출력
            }

        }

        public void ClashEnemyAndBullet(Enemy enemy) // 충돌
        {
            BULLET[][] bullets = { playerBullet, playerBullet2, playerBullet3 };

            foreach (var bulletArray in bullets) // 각 총알 배열에 대해 반복
            {
                for (int i = 0; i < 20; i++)
                {
                    if (bulletArray[i].fire == true) // 총알이 활성화되어 있을 때
                    {
                        if (bulletArray[i].y == enemy.enemyY) // Y좌표가 같고
                        {
                            if (bulletArray[i].x >= (enemy.enemyX - 1) && bulletArray[i].x <= (enemy.enemyX + 1)) // X좌표 범위 충돌
                            {
                                item.ItemLife = true;
                                item.itemX = enemy.enemyX;
                                item.itemY = enemy.enemyY;

                                Random rand = new Random();
                                enemy.enemyX = 75;
                                enemy.enemyY = rand.Next(2, 22);

                                bulletArray[i].fire = false; // 총알을 비활성화

                                Score += 100; // 점수 증가
                            }
                        }
                    }
                }
            }

            /*for (int i = 0; i < 20; i++) // 미사일 20
            {
                if (playerBullet[i].fire == true) // 미사일1 20
                {
                    if (playerBullet[i].y == enemy.enemyY) // 미사일과 적의 y값이 같을 때
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX + 1)) // 충돌
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; // 미사일도 준비상태로 만들어주기

                            Score += 100; // 스코어

                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++) // 미사일2 20
            {
                if (playerBullet2[i].fire == true) // 살아있는 미사일
                {
                    if (playerBullet2[i].y == enemy.enemyY) // 미사일과 적의 y값이 같을 때
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) // 충돌
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; // 미사일도 준비상태로 만들어주기

                            Score += 100; // 스코어

                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++) // 미사일3 20
            {
                if (playerBullet3[i].fire == true) // 살아있는 미사일
                {
                    if (playerBullet3[i].y == enemy.enemyY) // 미사일과 적의 y값이 같을 때
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) // 충돌
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; // 미사일도 준비상태로 만들어주기

                            Score += 100; // 스코어

                        }
                    }
                }
            }*/
        }

        public void UIscore() // 점수UI 출력
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score); // 점수 출력
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }
        
        public void CrashItem() // 아이템 충돌이 일어나면 양쪽 미사일 발사
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) // 총알 발사
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;

                    }
                }
            }
        }

    }

    public class Enemy // 적 클래스
    {
        public int enemyX; // X좌표
        public int enemyY; // Y좌표

        public Enemy() 
        {
            enemyX = 77; // 적 좌표 초기화
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            if (enemyX >= 0 && enemyX <= 74) // 74까지만 허용 (5글자 길이)
            {
                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write("(◐ω◑ )");
            }
        }

        public void EnemyMove()
        {
            Random rand = new Random(); // 랜덤
            enemyX--; // 왼쪽으로 움직임

            if (enemyX < 2) // 화면 왼쪽 넘어가면 새로 좌표 잡아라
            {
                enemyX = 77; // 좌표77
                enemyY = rand.Next(2, 22); // 2~21
            }
        }
    } 

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            if (itemX >= 0 && itemX < 80) // 콘솔 범위 내에서만 출력
            {
                Console.SetCursorPosition(itemX, itemY);
                Console.Write("★ UP★");
            }
        }

        public void ItemMove()
        {
            if (itemX <= 1 || itemY <= 1)
            {
                ItemLife = false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player(); // 플레이어 생성
            Enemy enemy = new Enemy(); // 적 생성

            int dwTime = Environment.TickCount; // 1/1000초가 흐흠, 유니티처럼 속도 프레임속도 (게임엔진 같은거)

            while (true) // 무한 반복
            {
                if (dwTime + 50 < Environment.TickCount) // 0,05초 지연
                {
                    dwTime = Environment.TickCount; //현재 시간 세팅
                    Console.Clear();
                    
                    // 화면 출력
                    player.GameMain(); //플레이어

                    if (player.itemCount == 0) // 총알
                    {
                        player.BulletDraw(); 
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }


                    enemy.EnemyMove(); // 적 움직임
                    enemy.EnemyDraw(); // 적 그리기

                    player.ClashEnemyAndBullet(enemy); // 충돌 처리


                }
            }
        }
    }
}
