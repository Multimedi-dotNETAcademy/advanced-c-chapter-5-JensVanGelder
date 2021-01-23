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
            Ball v1 = new VerticalBall(20, 1);
            Ball v2 = new VerticalBall(10, 1);
            Ball h1 = new HorizontalBall(5, 1);
            Ball h2 = new HorizontalBall(15, 1);
            Ball[] balls = new Ball[6] { b1, b2, v1, v2,h1,h2 };
            PlayerBall player = new PlayerBall(15, 10, 0, 0);
            int timer = 300;

            Console.WriteLine("Try to survive!\nPress Enter.");
            Console.ReadLine();

            while (timer>0)
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
                System.Threading.Thread.Sleep(75);
                timer--;
            }
            Console.Clear();
            Console.WriteLine("You Win!");
        }
    }
}