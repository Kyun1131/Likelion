using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BrickGame
{
    public class Ball
    {
        BALLDATA _Ball = new BALLDATA();
        BARDATA _pBar = new BARDATA();

        // C# 공의 방향 배열 정의
        int[,] _WallCollision = new int[4, 6]
        {
            { 3, 2, -1, -1, -1, 4},
            { -1, -1, -1, -1, 2, 1},
            { -1, 5, 4, -1, -1, -1},
            { -1, -1, 1, 0, 5, -1}
        };





        public BALLDATA GetBall() { return _Ball; }
        public void SetX(int x) { _Ball.nX += x; }
        public void SetY(int y) { _Ball.nY += y; }
        public void SetBall(BALLDATA tBall) { _Ball = tBall; }
        public void setReady(int Ready) { _Ball.nReady = Ready; }


        // 움직일 bar
        // block
        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


        }

        public int Collision(int x, int y)
        {
            // 벽충돌
            if (y == 0)
            {
                _Ball.nDirect = _WallCollision[0, _Ball.nDirect];
                return 1; // 공 방향이 바뀌면 1리턴
            }

            if (x == 1)
            {
                _Ball.nDirect = _WallCollision[1, _Ball.nDirect];
                return 1;
            }

            if (x == 77)
            {
                _Ball.nDirect = _WallCollision[2, _Ball.nDirect];
                return 1;
            }

            if (y == 23)
            {
                _Ball.nDirect = _WallCollision[3, _Ball.nDirect];
                return 1;
            }

            //Bar충돌처리
            if (x >= _pBar.m_tBar.nX[0] && x <= _pBar.m_tBar.nX[2] + 1 &&
                y == (_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (_Ball.nDirect == 1)
                    _Ball.nDirect = 2;
                else if (_Ball.nDirect == 2)
                    _Ball.nDirect = 1;
                else if (_Ball.nDirect == 5)
                    _Ball.nDirect = 4;
                else if (_Ball.nDirect == 4)
                    _Ball.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= _pBar.m_tBar.nX[0] && x <= _pBar.m_tBar.nX[2] + 1 &&
              y == (_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (_Ball.nDirect == 1)
                    _Ball.nDirect = 2;
                else if (_Ball.nDirect == 2)
                    _Ball.nDirect = 1;
                else if (_Ball.nDirect == 5)
                    _Ball.nDirect = 4;
                else if (_Ball.nDirect == 4)
                    _Ball.nDirect = 5;

                return 1; //방향이 바뀐다.
            }


            return 0;
        }

        public void Initialize()
        {
            _Ball.nReady = 0; // 1안움직임 0움직임
            _Ball.nDirect = 1;
            _Ball.nX = 30;
            _Ball.nY = 10;

            // 커서 안보이게 숨기기
            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if (_Ball.nReady == 0)
            {
                // 공 방향에 따른 스위치문
                switch (_Ball.nDirect)
                {
                    // 위
                    case 0: 
                        if(Collision(_Ball.nX, _Ball.nY -1) ==0)
                            _Ball.nY--; break;

                    // 오른쪽 위
                    case 1:
                        if (Collision(_Ball.nX + 1, _Ball.nY - 1) == 0)
                        {
                            _Ball.nX++; _Ball.nY--; 
                        }
                        break;

                    // 오른쪽 아래
                    case 2: if (Collision(_Ball.nX + 1, _Ball.nY + 1) == 0)
                        {
                            _Ball.nX++; _Ball.nY++;
                        }
                            break;

                    // 아래
                    case 3: if (Collision(_Ball.nX, _Ball.nY + 1) == 0)
                        {
                            _Ball.nX++; _Ball.nY++;
                        }
                             break;

                    // 왼쪽 아래
                    case 4: if (Collision(_Ball.nX - 1, _Ball.nY + 1) == 0)
                        {
                            _Ball.nX--; _Ball.nY++;
                        }
                            break;

                    // 왼쪽 위
                    case 5: if (Collision(_Ball.nX - 1, _Ball.nY - 1) == 0)
                        {
                            _Ball.nX--; _Ball.nY--;
                        }
                            break;
                }
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(_Ball.nX, _Ball.nY);
            Console.Write("●");
        }

        public void Release() { }



    }
}
