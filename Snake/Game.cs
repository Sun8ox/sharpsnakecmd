using System;
namespace Snake
{
	public class Game
	{
		public Game()
		{


            var none = Settings.empty;

            var a1 = none;
            var a2 = none;
            var a3 = none;
            var a4 = none;
            var a5 = none;
            var a6 = none;
            var a7 = none;
            var a8 = none;
            var a9 = none;
            var a10 = none;
            var a11 = none;
            var a12 = none;
            var a13 = none;
            var a14 = none;
            var a15 = none;
            var a16 = none;

            var b1 = none;
            var b2 = none;
            var b3 = none;
            var b4 = none;
            var b5 = none;
            var b6 = none;
            var b7 = none;
            var b8 = none;
            var b9 = none;
            var b10 = none;
            var b11 = none;
            var b12 = none;
            var b13 = none;
            var b14 = none;
            var b15 = none;
            var b16 = none;

            var c1 = none;
            var c2 = none;
            var c3 = none;
            var c4 = none;
            var c5 = none;
            var c6 = none;
            var c7 = none;
            var c8 = none;
            var c9 = none;
            var c10 = none;
            var c11 = none;
            var c12 = none;
            var c13 = none;
            var c14 = none;
            var c15 = none;
            var c16 = none;

            var d1 = none;
            var d2 = none;
            var d3 = none;
            var d4 = none;
            var d5 = none;
            var d6 = none;
            var d7 = none;
            var d8 = none;
            var d9 = none;
            var d10 = none;
            var d11 = none;
            var d12 = none;
            var d13 = none;
            var d14 = none;
            var d15 = none;
            var d16 = none;

            var e1 = none;
            var e2 = none;
            var e3 = none;
            var e4 = none;
            var e5 = none;
            var e6 = none;
            var e7 = none;
            var e8 = none;
            var e9 = none;
            var e10 = none;
            var e11 = none;
            var e12 = none;
            var e13 = none;
            var e14 = none;
            var e15 = none;
            var e16 = none;

            var f1 = none;
            var f2 = none;
            var f3 = none;
            var f4 = none;
            var f5 = none;
            var f6 = none;
            var f7 = none;
            var f8 = none;
            var f9 = none;
            var f10 = none;
            var f11 = none;
            var f12 = none;
            var f13 = none;
            var f14 = none;
            var f15 = none;
            var f16 = none;

            var g1 = none;
            var g2 = none;
            var g3 = none;
            var g4 = none;
            var g5 = none;
            var g6 = none;
            var g7 = none;
            var g8 = none;
            var g9 = none;
            var g10 = none;
            var g11 = none;
            var g12 = none;
            var g13 = none;
            var g14 = none;
            var g15 = none;
            var g16 = none;

            void resetColor()
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            void highlight()
            {
                Console.ForegroundColor = Settings.selectedColor;
            }

            Random random = new Random();

            var direction = Settings.startDirection;

            var startX = 3;
            var startY = 3;

            bool firstTick = true;

            var positionX = 0;
            var positionY = 0;

            var oldPositionX = 0;
            var oldPositionY = 0;

            int ticks = 0;

            int length = Settings.defaultLength;

            int appleX = 1;
            int appleY = 1;

            int difficulty = Settings.difficulty;

            int sleepV = Settings.getSpeedV(difficulty);
            int sleepH = Settings.getSpeedH(difficulty);

            var apple = Settings.apple;
            var snake = Settings.snakeBody;

            ConsoleKey up = Settings.up;
            ConsoleKey down = Settings.down;
            ConsoleKey right = Settings.right;
            ConsoleKey left = Settings.left;

            var f = Settings.frame;
            var name = Settings.title;

            bool gameOver = false;
            List<int> oldPositionsX = new List<int>();
            List<int> oldPositionsY = new List<int>();

            // Functions
            void setBlock(int x, int y, bool set)
            {
                var output = none;

                if (x == 0 || x >= 8)
                {
                    gameOver = true;
                }

                if (y == 0 || y >= 16)
                {
                    gameOver = true;
                }

                /*

                    if(oldPositionsX.Contains(x) && oldPositionsY.Contains(y))
                    {
                        gameOver = true;
                    }

                 */


                if (x == 1 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g1 = output;
                }

                if (x == 1 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g2 = output;
                }

                if (x == 1 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g3 = output;
                }

                if (x == 1 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g4 = output;
                }

                if (x == 1 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g5 = output;
                }

                if (x == 1 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g6 = output;
                }

                if (x == 1 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g7 = output;
                }

                if (x == 1 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g8 = output;
                }

                if (x == 1 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g9 = output;
                }

                if (x == 1 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g10 = output;
                }

                if (x == 1 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g11 = output;
                }

                if (x == 1 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g12 = output;
                }

                if (x == 1 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g13 = output;
                }

                if (x == 1 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g14 = output;
                }

                if (x == 1 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g15 = output;
                }

                if (x == 1 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    g16 = output;
                }

                if (x == 2 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f1 = output;
                }

                if (x == 2 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f2 = output;
                }

                if (x == 2 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f3 = output;
                }

                if (x == 2 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f4 = output;
                }

                if (x == 2 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f5 = output;
                }

                if (x == 2 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f6 = output;
                }

                if (x == 2 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f7 = output;
                }

                if (x == 2 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f8 = output;
                }

                if (x == 2 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f9 = output;
                }

                if (x == 2 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f10 = output;
                }

                if (x == 2 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f11 = output;
                }

                if (x == 2 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f12 = output;
                }

                if (x == 2 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f13 = output;
                }

                if (x == 2 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f14 = output;
                }

                if (x == 2 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f15 = output;
                }

                if (x == 2 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    f16 = output;
                }

                if (x == 3 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e1 = output;
                }

                if (x == 3 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e2 = output;
                }

                if (x == 3 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e3 = output;
                }

                if (x == 3 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e4 = output;
                }

                if (x == 3 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e5 = output;
                }

                if (x == 3 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e6 = output;
                }

                if (x == 3 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e7 = output;
                }

                if (x == 3 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e8 = output;
                }

                if (x == 3 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e9 = output;
                }

                if (x == 3 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e10 = output;
                }

                if (x == 3 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e11 = output;
                }

                if (x == 3 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e12 = output;
                }

                if (x == 3 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e13 = output;
                }

                if (x == 3 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e14 = output;
                }

                if (x == 3 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e15 = output;
                }

                if (x == 3 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    e16 = output;
                }

                if (x == 4 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d1 = output;
                }

                if (x == 4 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d2 = output;
                }

                if (x == 4 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d3 = output;
                }

                if (x == 4 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d4 = output;
                }

                if (x == 4 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d5 = output;
                }

                if (x == 4 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d6 = output;
                }

                if (x == 4 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d7 = output;
                }

                if (x == 4 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d8 = output;
                }

                if (x == 4 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d9 = output;
                }

                if (x == 4 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d10 = output;
                }

                if (x == 4 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d11 = output;
                }

                if (x == 4 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d12 = output;
                }

                if (x == 4 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d13 = output;
                }

                if (x == 4 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d14 = output;
                }

                if (x == 4 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d15 = output;
                }

                if (x == 4 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    d16 = output;
                }

                if (x == 5 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c1 = output;
                }

                if (x == 5 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c2 = output;
                }

                if (x == 5 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c3 = output;
                }

                if (x == 5 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c4 = output;
                }

                if (x == 5 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c5 = output;
                }

                if (x == 5 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c6 = output;
                }

                if (x == 5 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c7 = output;
                }

                if (x == 5 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c8 = output;
                }

                if (x == 5 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c9 = output;
                }

                if (x == 5 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c10 = output;
                }

                if (x == 5 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c11 = output;
                }

                if (x == 5 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c12 = output;
                }

                if (x == 5 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c13 = output;
                }

                if (x == 5 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c14 = output;
                }

                if (x == 5 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c15 = output;
                }

                if (x == 5 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    c16 = output;
                }

                if (x == 6 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b1 = output;
                }

                if (x == 6 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b2 = output;
                }

                if (x == 6 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b3 = output;
                }

                if (x == 6 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b4 = output;
                }

                if (x == 6 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b5 = output;
                }

                if (x == 6 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b6 = output;
                }

                if (x == 6 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b7 = output;
                }

                if (x == 6 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b8 = output;
                }

                if (x == 6 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b9 = output;
                }

                if (x == 6 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b10 = output;
                }

                if (x == 6 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b11 = output;
                }

                if (x == 6 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b12 = output;
                }

                if (x == 6 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b13 = output;
                }

                if (x == 6 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b14 = output;
                }

                if (x == 6 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b15 = output;
                }

                if (x == 6 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    b16 = output;
                }

                if (x == 7 && y == 1)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a1 = output;
                }

                if (x == 7 && y == 2)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a2 = output;
                }

                if (x == 7 && y == 3)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a3 = output;
                }

                if (x == 7 && y == 4)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a4 = output;
                }

                if (x == 7 && y == 5)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a5 = output;
                }

                if (x == 7 && y == 6)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a6 = output;
                }

                if (x == 7 && y == 7)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a7 = output;
                }

                if (x == 7 && y == 8)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a8 = output;
                }

                if (x == 7 && y == 9)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a9 = output;
                }

                if (x == 7 && y == 10)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a10 = output;
                }

                if (x == 7 && y == 11)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a11 = output;
                }

                if (x == 7 && y == 12)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a12 = output;
                }

                if (x == 7 && y == 13)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a13 = output;
                }

                if (x == 7 && y == 14)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a14 = output;
                }

                if (x == 7 && y == 15)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a15 = output;
                }

                if (x == 7 && y == 16)
                {
                    if (set)
                    {
                        output = snake;
                    }
                    a16 = output;
                }
            }

            void clear()
            {
                Console.Clear();
            }

            void spawnApple()
            {
                int y = 1;
                int x = 1;

                void setRandom()
                {
                    y = random.Next(1, 16);
                    x = random.Next(1, 7);
                }

                setRandom();

                appleX = x;
                appleY = y;

                if (x == 1 && y == 1)
                {
                    g1 = apple;
                }

                if (x == 1 && y == 2)
                {
                    g2 = apple;
                }

                if (x == 1 && y == 3)
                {
                    g3 = apple;
                }

                if (x == 1 && y == 4)
                {
                    g4 = apple;
                }

                if (x == 1 && y == 5)
                {
                    g5 = apple;
                }

                if (x == 1 && y == 6)
                {
                    g6 = apple;
                }

                if (x == 1 && y == 7)
                {
                    g7 = apple;
                }

                if (x == 1 && y == 8)
                {
                    g8 = apple;
                }

                if (x == 1 && y == 9)
                {
                    g9 = apple;
                }

                if (x == 1 && y == 10)
                {
                    g10 = apple;
                }

                if (x == 1 && y == 11)
                {
                    g11 = apple;
                }

                if (x == 1 && y == 12)
                {
                    g12 = apple;
                }

                if (x == 1 && y == 13)
                {
                    g13 = apple;
                }

                if (x == 1 && y == 14)
                {
                    g14 = apple;
                }

                if (x == 1 && y == 15)
                {
                    g15 = apple;
                }

                if (x == 1 && y == 16)
                {
                    g16 = apple;
                }

                if (x == 2 && y == 1)
                {
                    f1 = apple;
                }

                if (x == 2 && y == 2)
                {
                    f2 = apple;
                }

                if (x == 2 && y == 3)
                {
                    f3 = apple;
                }

                if (x == 2 && y == 4)
                {
                    f4 = apple;
                }

                if (x == 2 && y == 5)
                {
                    f5 = apple;
                }

                if (x == 2 && y == 6)
                {
                    f6 = apple;
                }

                if (x == 2 && y == 7)
                {
                    f7 = apple;
                }

                if (x == 2 && y == 8)
                {
                    f8 = apple;
                }

                if (x == 2 && y == 9)
                {
                    f9 = apple;
                }

                if (x == 2 && y == 10)
                {
                    f10 = apple;
                }

                if (x == 2 && y == 11)
                {
                    f11 = apple;
                }

                if (x == 2 && y == 12)
                {
                    f12 = apple;
                }

                if (x == 2 && y == 13)
                {
                    f13 = apple;
                }

                if (x == 2 && y == 14)
                {
                    f14 = apple;
                }

                if (x == 2 && y == 15)
                {
                    f15 = apple;
                }

                if (x == 2 && y == 16)
                {
                    f16 = apple;
                }

                if (x == 3 && y == 1)
                {
                    e1 = apple;
                }

                if (x == 3 && y == 2)
                {
                    e2 = apple;
                }

                if (x == 3 && y == 3)
                {
                    e3 = apple;
                }

                if (x == 3 && y == 4)
                {
                    e4 = apple;
                }

                if (x == 3 && y == 5)
                {
                    e5 = apple;
                }

                if (x == 3 && y == 6)
                {
                    e6 = apple;
                }

                if (x == 3 && y == 7)
                {
                    e7 = apple;
                }

                if (x == 3 && y == 8)
                {
                    e8 = apple;
                }

                if (x == 3 && y == 9)
                {
                    e9 = apple;
                }

                if (x == 3 && y == 10)
                {
                    e10 = apple;
                }

                if (x == 3 && y == 11)
                {
                    e11 = apple;
                }

                if (x == 3 && y == 12)
                {
                    e12 = apple;
                }

                if (x == 3 && y == 13)
                {
                    e13 = apple;
                }

                if (x == 3 && y == 14)
                {
                    e14 = apple;
                }

                if (x == 3 && y == 15)
                {
                    e15 = apple;
                }

                if (x == 3 && y == 16)
                {
                    e16 = apple;
                }

                if (x == 4 && y == 1)
                {
                    d1 = apple;
                }

                if (x == 4 && y == 2)
                {
                    d2 = apple;
                }

                if (x == 4 && y == 3)
                {
                    d3 = apple;
                }

                if (x == 4 && y == 4)
                {
                    d4 = apple;
                }

                if (x == 4 && y == 5)
                {
                    d5 = apple;
                }

                if (x == 4 && y == 6)
                {
                    d6 = apple;
                }

                if (x == 4 && y == 7)
                {
                    d7 = apple;
                }

                if (x == 4 && y == 8)
                {
                    d8 = apple;
                }

                if (x == 4 && y == 9)
                {
                    d9 = apple;
                }

                if (x == 4 && y == 10)
                {
                    d10 = apple;
                }

                if (x == 4 && y == 11)
                {
                    d11 = apple;
                }

                if (x == 4 && y == 12)
                {
                    d12 = apple;
                }

                if (x == 4 && y == 13)
                {
                    d13 = apple;
                }

                if (x == 4 && y == 14)
                {
                    d14 = apple;
                }

                if (x == 4 && y == 15)
                {
                    d15 = apple;
                }

                if (x == 4 && y == 16)
                {
                    d16 = apple;
                }

                if (x == 5 && y == 1)
                {
                    c1 = apple;
                }

                if (x == 5 && y == 2)
                {
                    c2 = apple;
                }

                if (x == 5 && y == 3)
                {
                    c3 = apple;
                }

                if (x == 5 && y == 4)
                {
                    c4 = apple;
                }

                if (x == 5 && y == 5)
                {
                    c5 = apple;
                }

                if (x == 5 && y == 6)
                {
                    c6 = apple;
                }

                if (x == 5 && y == 7)
                {
                    c7 = apple;
                }

                if (x == 5 && y == 8)
                {
                    c8 = apple;
                }

                if (x == 5 && y == 9)
                {
                    c9 = apple;
                }

                if (x == 5 && y == 10)
                {
                    c10 = apple;
                }

                if (x == 5 && y == 11)
                {
                    c11 = apple;
                }

                if (x == 5 && y == 12)
                {
                    c12 = apple;
                }

                if (x == 5 && y == 13)
                {
                    c13 = apple;
                }

                if (x == 5 && y == 14)
                {
                    c14 = apple;
                }

                if (x == 5 && y == 15)
                {
                    c15 = apple;
                }

                if (x == 5 && y == 16)
                {
                    c16 = apple;
                }

                if (x == 6 && y == 1)
                {
                    b1 = apple;
                }

                if (x == 6 && y == 2)
                {
                    b2 = apple;
                }

                if (x == 6 && y == 3)
                {
                    b3 = apple;
                }

                if (x == 6 && y == 4)
                {
                    b4 = apple;
                }

                if (x == 6 && y == 5)
                {
                    b5 = apple;
                }

                if (x == 6 && y == 6)
                {
                    b6 = apple;
                }

                if (x == 6 && y == 7)
                {
                    b7 = apple;
                }

                if (x == 6 && y == 8)
                {
                    b8 = apple;
                }

                if (x == 6 && y == 9)
                {
                    b9 = apple;
                }

                if (x == 6 && y == 10)
                {
                    b10 = apple;
                }

                if (x == 6 && y == 11)
                {
                    b11 = apple;
                }

                if (x == 6 && y == 12)
                {
                    b12 = apple;
                }

                if (x == 6 && y == 13)
                {
                    b13 = apple;
                }

                if (x == 6 && y == 14)
                {
                    b14 = apple;
                }

                if (x == 6 && y == 15)
                {
                    b15 = apple;
                }

                if (x == 6 && y == 16)
                {
                    b16 = apple;
                }

                if (x == 7 && y == 1)
                {
                    a1 = apple;
                }

                if (x == 7 && y == 2)
                {
                    a2 = apple;
                }

                if (x == 7 && y == 3)
                {
                    a3 = apple;
                }

                if (x == 7 && y == 4)
                {
                    a4 = apple;
                }

                if (x == 7 && y == 5)
                {
                    a5 = apple;
                }

                if (x == 7 && y == 6)
                {
                    a6 = apple;
                }

                if (x == 7 && y == 7)
                {
                    a7 = apple;
                }

                if (x == 7 && y == 8)
                {
                    a8 = apple;
                }

                if (x == 7 && y == 9)
                {
                    a9 = apple;
                }

                if (x == 7 && y == 10)
                {
                    a10 = apple;
                }

                if (x == 7 && y == 11)
                {
                    a11 = apple;
                }

                if (x == 7 && y == 12)
                {
                    a12 = apple;
                }

                if (x == 7 && y == 13)
                {
                    a13 = apple;
                }

                if (x == 7 && y == 14)
                {
                    a14 = apple;
                }

                if (x == 7 && y == 15)
                {
                    a15 = apple;
                }

                if (x == 7 && y == 16)
                {
                    a16 = apple;

                }

            }
            var clicked = 0;

            Console.Title = "SharpSnake";
            while (true)
            {

                if (gameOver)
                {
                    break;
                }

                ticks++;


                

                if (Console.KeyAvailable)
                {
                    var clickedKey = Console.ReadKey().Key;

                    if (clickedKey == ConsoleKey.Escape)
                    {

                        Console.Write("\n    PPaused \n  ");
                        Console.ReadKey();

                    }

                    if (clickedKey == up)
                    {
                        clicked = 1;
                        direction = 1;
                    }

                    if (clickedKey == down)
                    {

                        clicked = 2;
                        direction = 2;
                    }


                    if (clickedKey == left)
                    {
                        clicked = 3;
                        direction = 3;
                    }

                    if (clickedKey == right)
                    {
                        clicked = 4;
                        direction = 4;
                    }



                }

                if (firstTick)
                {
                    firstTick = false;

                    setBlock(startX, startY, true);
                    positionX = startX;
                    positionY = startY;

                    spawnApple();

                }
                else
                {
                    if (direction == 1)
                    {

                        oldPositionX = positionX;
                        oldPositionY = positionY;

                        positionX++;

                        //setBlock(oldPositionX, oldPositionY, false);
                        setBlock(positionX, positionY, true);
                    }

                    if (direction == 2)
                    {
                        oldPositionX = positionX;
                        oldPositionY = positionY;

                        positionX--;
                        //setBlock(oldPositionX, oldPositionY, false);
                        setBlock(positionX, positionY, true);
                    }

                    if (direction == 3)
                    {
                        oldPositionX = positionX;
                        oldPositionY = positionY;

                        positionY--;
                        //setBlock(oldPositionX, oldPositionY, false);
                        setBlock(positionX, positionY, true);
                    }

                    if (direction == 4)
                    {
                        oldPositionX = positionX;
                        oldPositionY = positionY;

                        positionY++;
                        //setBlock(oldPositionX, oldPositionY, false);
                        setBlock(positionX, positionY, true);
                    }

                    oldPositionsX.Add(oldPositionX);
                    oldPositionsY.Add(oldPositionY);


                    if (oldPositionsX.Count == length && oldPositionsY.Count == length)
                    {
                        int x = oldPositionsX[0];
                        int y = oldPositionsY[0];

                        oldPositionsX.Remove(x);
                        oldPositionsY.Remove(y);


                        setBlock(x, y, false);

                    }

                    if (positionX == appleX && positionY == appleY)
                    {
                        spawnApple();
                        length++;
                        sleepV -= 5;
                        sleepH -= 5;

                        if (length == 90)
                        {
                            break;
                        }
                    }



                }



                Console.Write($"<= {name}\n");
                Console.Write($" =========================================== ");
                Console.Write($"\n                                   \n");


                // "Display"

                Console.Write($"     {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} \n");
                Console.Write($"     {f} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9} {a10} {a11} {a12} {a13} {a14} {a15} {a16} {f} \n");
                Console.Write($"     {f} {b1} {b2} {b3} {b4} {b5} {b6} {b7} {b8} {b9} {b10} {b11} {b12} {b13} {b14} {b15} {b16} {f} \n");
                Console.Write($"     {f} {c1} {c2} {c3} {c4} {c5} {c6} {c7} {c8} {c9} {c10} {c11} {c12} {c13} {c14} {c15} {c16} {f} \n");
                Console.Write($"     {f} {d1} {d2} {d3} {d4} {d5} {d6} {d7} {d8} {d9} {d10} {d11} {d12} {d13} {d14} {d15} {d16} {f} \n");
                Console.Write($"     {f} {e1} {e2} {e3} {e4} {e5} {e6} {e7} {e8} {e9} {e10} {e11} {e12} {e13} {e14} {e15} {e16} {f} \n");
                Console.Write($"     {f} {f1} {f2} {f3} {f4} {f5} {f6} {f7} {f8} {f9} {f10} {f11} {f12} {f13} {f14} {f15} {f16} {f} \n");
                Console.Write($"     {f} {g1} {g2} {g3} {g4} {g5} {g6} {g7} {g8} {g9} {g10} {g11} {g12} {g13} {g14} {g15} {g16} {f} \n");
                Console.Write($"     {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} {f} \n");


                Console.Write("                                   ");

                Console.Write("\n =========================================== ");

                // Controls

                if (clicked == 1)
                {
                    highlight();
                }

                Console.Write("\n                     ↑                   \n");

                if (clicked == 1)
                {
                    resetColor();
                }

                if (clicked == 3)
                {
                    highlight();
                }
                Console.Write("                  ← ");

                if (clicked == 3)
                {
                    resetColor();
                }

                if (clicked == 2)
                {
                    highlight();
                }

                Console.Write(" ↓ ");

                if (clicked == 4)
                {
                    highlight();
                }

                Console.Write(" →                  \n ");

                if (clicked == 4)
                {
                    resetColor();
                }

                resetColor();

                Console.Write("===========================================");
                Console.Write("\n   Ticks: " + ticks + " Difficulty: " + difficulty + " Length: " + length + "\n  ");


                //"     "

                if (direction == 1 || direction == 2)
                {
                    Thread.Sleep(sleepV);
                }
                else
                {
                    Thread.Sleep(sleepH);
                }

                clear();

            }
            clear();

            // End

            if (gameOver)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine(" ");
                Console.WriteLine("Click any key to continue!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You won!");
                Console.WriteLine(" ");
                Console.WriteLine("Click any key to continue");
                Console.ReadKey();
            }





        }
	}
}

