using System;

namespace Ballspel
{
    internal class VerticalBall : Ball
    {
        public VerticalBall(int xin, int vyin) : base(xin, 0, 0, vyin)
        {
            drawChar = '|';
            drawColor = ConsoleColor.Blue;
        }
    }
}