using System;

namespace Ballspel
{
    internal class HorizontalBall : Ball
    {
        public HorizontalBall(int yin, int vxin) : base(0, yin, vxin, 0)
        {
            drawChar = '-';
            drawColor = ConsoleColor.Cyan;
        }
    }
}