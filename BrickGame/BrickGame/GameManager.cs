using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class GameManager
    {
        Ball _pBall = null;
        Bar _pBar = null;

        public void Initialize()
        {
            if (_pBall == null)
            {
                _pBall = new Ball();
                _pBall.Initialize();
            }

            if (_pBar == null)
            {

            }
        }



        public void Progress()
        {
            _pBall.Progress();
            _pBar.Progress(ref _pBall);
        }

        public void Render()
        {
            Console.Clear();
            _pBall.Render();
            _pBar.Render();
        }

        public void Release()
        {
            _pBall.Release();
            _pBar.Release();
        }



    }
}
