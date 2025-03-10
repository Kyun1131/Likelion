using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    /// <summary>
    /// 구조체(stuct)
    /// </summary>
    /// 클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠름
    /// 주로 간단한 데이터 묶음을 만들때 사용
    /// 구조체(stuct)에서도 생성자 사용 가능.
    /// 
    struct Point
    {
        public int X;
        public int Y;

    }


    /// <summary>
    /// 구조체(struct) 예문1, 2
    /// </summary>
    /// 
    /*struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width * Height;
    }*/

    class Program
    {

        static void Main(string[] args)
        {
            /// <summary>
            /// 구조체(struct) Main
            /// </summary>
            /// 
            /*Point p; // 구조체 선언 (초기화 필요)

            p.X = 10;
            p.Y = 20;

            p.Print();*/

            /// <summary>
            /// 구조체(struct) 예문1
            /// </summary>
            /// 
            /*var rect = new Rectangle { Width = 5, Height = 4 };
            Console.WriteLine($"Area: {rect.GetArea()}");*/

            /// <summary>
            /// 구조체(struct) 예문2
            /// </summary>
            /// 
            /*Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area: {rect.GetArea()}");*/

            /// <summary>
            /// 구조체(struct) 예문3
            /// </summary>
            /// 
            Point[] points = new Point[2];

            points[0].X = 10;
            points[0].Y = 10;

            points[1].X = 20;
            points[1].Y = 20;


            foreach(var point in points)
            {
                Console.WriteLine($"Point: ({point.X}, {point.Y})");
            }
        }
    }
}
