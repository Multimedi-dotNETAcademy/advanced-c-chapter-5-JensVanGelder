using System;

namespace Ballspel
{
    internal class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy = -1;
                    vx = 0;
                    break;

                case ConsoleKey.DownArrow:
                    vy = 1;
                    vx = 0;
                    break;

                case ConsoleKey.LeftArrow:
                    vx = -1;
                    vy = 0;
                    break;

                case ConsoleKey.RightArrow:
                    vx = 1;
                    vy = 0;
                    break;

                default:
                    break;
            }
        }

        public override void Update()
        {
            x += vx;
            y += vy;
            if (y < 0)
            {
                y = 0;
            }
            if (x >= Console.WindowWidth || x < 0)
            {
                vx = 0;
                x += vx;
            }
            if (y >= Console.WindowHeight || y < 0)
            {
                vy = 0;
            }
        }
    }
}