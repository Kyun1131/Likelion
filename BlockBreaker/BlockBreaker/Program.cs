using System;
using System.Text;
using System.Threading;

class BlockBreaker
{
    private const int Width = 80;  // 게임 가로 크기
    private const int Height = 25; // 게임 세로 크기
    private char[,] board = new char[Height, Width];

    private int paddleX = 36; // 패들 위치
    private int ballX = 40, ballY = 20; // 공 위치
    private int ballDirX = 1, ballDirY = -1; // 공 이동 방향

    private bool isRunning = true;

    private int ballSpeed = 3;  // 공 속도 (값이 클수록 느려짐)
    private int ballSpeedCounter = 0; // 공 이동 카운터

    public void Run()
    {
        Console.CursorVisible = false;
        InitializeBoard();

        while (isRunning)
        {
            UpdateGame();
            DrawBoard();
            Thread.Sleep(16); // 60FPS 유지
        }

        Console.Clear();
        Console.WriteLine("🎉 게임 종료! 감사합니다!");
    }

    private void InitializeBoard()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                if (y < 5 && (x % 2 == 0)) board[y, x] = '■'; // 블록 배치 (격자 패턴)
                else board[y, x] = ' ';
            }
        }
    }

    private void DrawBoard()
    {
        StringBuilder sb = new StringBuilder(Width * Height);

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                if (y == ballY && x == ballX) sb.Append("O"); // 공 출력
                else if (y == Height - 1 && (x >= paddleX && x < paddleX + 8)) sb.Append("="); // 패들 출력
                else sb.Append(board[y, x]); // 블록 출력
            }
            sb.Append("\n");
        }
        sb.Append("A/D 이동 | Q 종료");

        Console.SetCursorPosition(0, 0);
        Console.Write(sb.ToString());
    }

    private void UpdateGame()
    {
        while (Console.KeyAvailable) // 키 입력이 있으면 처리
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.A && paddleX > 0) paddleX--; // 왼쪽 이동
            if (key == ConsoleKey.D && paddleX < Width - 8) paddleX++; // 오른쪽 이동
            if (key == ConsoleKey.Q) isRunning = false; // 게임 종료
        }

        // 공 이동 속도 조절
        ballSpeedCounter++;
        if (ballSpeedCounter < ballSpeed) return; // 속도 조절 (값이 클수록 느림)
        ballSpeedCounter = 0;

        // 공 이동
        ballX += ballDirX;
        ballY += ballDirY;

        // 벽 충돌 (좌우)
        if (ballX <= 0 || ballX >= Width - 1) ballDirX *= -1;

        // 천장 충돌
        if (ballY <= 0) ballDirY *= -1;

        // 패들 충돌d
        if (ballY == Height - 2 && ballX >= paddleX && ballX < paddleX + 8) ballDirY *= -1;

        // 블록 충돌
        if (ballY < 5 && board[ballY, ballX] == '■')
        {
            board[ballY, ballX] = ' ';
            ballDirY *= -1;
        }

        // 패배 조건 (공이 바닥에 떨어짐)
        if (ballY >= Height - 1) isRunning = false;
    }

    static void Main()
    {
        new BlockBreaker().Run();
    }
}
