using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame game = new MainGame();
            game.Initialize();
            game.Run();  
        }
    }
}
