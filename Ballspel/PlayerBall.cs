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
            if (x<0)
            {
                x = 0;
            }
            if (x >= Console.WindowWidth )
            {
                vx = 0;
                x = Console.WindowWidth - 1;
            }
            if (y >= Console.WindowHeight)
            {
                vy = 0;
                y = Console.WindowHeight - 1;
            }
        }
    }
}