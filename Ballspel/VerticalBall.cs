using System;
using System.Collections.Generic;
using System.Text;

namespace Ballspel
{
    class VerticalBall:Ball
    {
        public VerticalBall(int xin, int vyin) : base(xin, 0, 0, vyin)
        {
            drawChar = '|';
            drawColor = ConsoleColor.Blue;
        }
    }
}
