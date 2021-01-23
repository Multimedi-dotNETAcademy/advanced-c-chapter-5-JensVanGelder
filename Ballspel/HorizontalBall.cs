using System;
using System.Collections.Generic;
using System.Text;

namespace Ballspel
{
    class HorizontalBall:Ball
    {
        public HorizontalBall(int yin, int vxin) : base(0, yin, vxin, 0)
        {
            drawChar = '-';
            drawColor = ConsoleColor.Cyan;
        }
    }
}
