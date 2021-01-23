using System;

namespace Ballspel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 20;
            Console.WindowWidth = 31;
            Ball b1 = new Ball(15, 1, 1, 1);
            Ball b2 = new Ball(15, 1, -1, 1);
            Ball b3 = new Ball(25, 20, 1, 1);
            Ball b4 = new Ball(5, 20, -1, 1);
            Ball v1 = new VerticalBall(20, 1);
            Ball v2 = new VerticalBall(10, 1);
            Ball v3 = new VerticalBall(5, 1);
            Ball v4 = new VerticalBall(25, 1);
            Ball h1 = new HorizontalBall(5, 1);
            Ball h2 = new HorizontalBall(15, 1);
            Ball h3 = new HorizontalBall(2, 1);
            Ball h4 = new HorizontalBall(18, 1);
            Ball[] balls = new Ball[12] { b1, b2, b3, b4, v1, v2, v3, v4, h1, h2, h3, h4 };
            PlayerBall player = new PlayerBall(15, 10, 0, 0);
            int timer = 100;

            Console.WriteLine("Try to survive!\nPress Enter.");
            Console.ReadLine();

            while (timer > 0)
            {
                Console.Clear();

                //Ball
                foreach (Ball i in balls)
                {
                    i.Update();
                    i.Draw();
                }

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                foreach (Ball i in balls)
                {
                    if (Ball.CheckHit(i, player))
                    {
                        Console.Clear();
                        Console.WriteLine("You Lose.");
                        Console.WriteLine($"\nSCORE: {timer}");
                        Console.ReadLine();
                    }
                }
                System.Threading.Thread.Sleep(100);
                timer--;
            }
            Console.Clear();
            Console.WriteLine("You Win!");
            Console.ReadLine();
        }
    }
}