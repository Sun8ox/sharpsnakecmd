using System;
namespace Snake
{
	public class Settings
	{

        // Difficulty
        // 1 - Easy
        // 2 - Normal
        // 3 - Hard
        public static int difficulty = 2;


        // Controls
        public static ConsoleKey up = ConsoleKey.W;
        public static ConsoleKey down = ConsoleKey.S;
        public static ConsoleKey right = ConsoleKey.D;
        public static ConsoleKey left = ConsoleKey.A;


        // Directions:
        //       Up - 1
        //  Left - 3     4 - Right
        //     Down - 2
        public static int startDirection = 4;

        // Style
        public static string empty = " ";
        public static string apple = "♦";
        public static string snakeBody = "□";
        public static string frame = "☼";
        public static string mainMenuSelected = "*";
        public static ConsoleColor selectedColor = ConsoleColor.Blue;
        public static string title = "SharpSnake";

        // Speed
        public static int easyH = 700;
        public static int easyV = 1200;

        public static int normalH = 600;
        public static int normalV = 800;

        public static int hardH = 500;
        public static int hardV = 500;

        public static int defaultLength = 2;



        public static int getSpeedH(int difficulty)
        {
            if (difficulty == 1)
            {
                return easyH;
            }

            if (difficulty == 2)
            {
                return normalH;
            }

            if (difficulty == 3)
            {
                return hardH;
            }

            return normalH;

        }
        public static int getSpeedV(int difficulty)
        {
            if (difficulty == 1)
            {
                return easyV;
            }

            if (difficulty == 2)
            {
                return normalV;
            }

            if (difficulty == 3)
            {
                return hardV;
            }

            return normalV;

        }



        public Settings()
		{
            void resetColor()
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            void highlight()
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }

            void clear()
            {
                Console.Clear();
            }

            int selected = 1;

            while (true)
            {
                var clicked = 0;


                if (Console.KeyAvailable)
                {
                    var clickedKey = Console.ReadKey().Key;

                    if (clickedKey == Settings.up)
                    {
                        clicked = 1;

                        if (selected < 2)
                        {
                            selected++;
                        }

                    }

                    if (clickedKey == Settings.down)
                    {
                        clicked = 2;


                        if (selected > 1)
                        {
                            selected--;
                        }
                    }


                    if (clickedKey == Settings.left)
                    {
                        clicked = 3;
                    }

                    if (clickedKey == Settings.right)
                    {
                        clicked = 4;

                        if (selected == 2)
                        {
                            clear();
                            if(difficulty != 3)
                            {
                                difficulty++;
                            }
                            else
                            {
                                difficulty = 1;
                            }

                        }

                        if (selected == 1)
                        {
                            clear();
                            break;

                        }

                    }



                }




                Console.WriteLine("                   ");
                Console.WriteLine("      Settings      ");
                Console.WriteLine("                   ");

                if (selected == 2)
                {
                    highlight();
                }
                Console.WriteLine($"    Difficulty: {difficulty}");
                resetColor();

                if (selected == 1)
                {
                    highlight();
                }
                Console.WriteLine("                   ");
                Console.WriteLine("        Exit       ");
                resetColor();



                Console.Write("\n=======================\n");
                if (clicked == 1)
                {
                    highlight();
                }

                Console.Write("           ↑            \n");

                if (clicked == 1)
                {
                    resetColor();
                }

                if (clicked == 3)
                {
                    highlight();
                }
                Console.Write("        ← ");

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

                Console.Write(" →           \n");

                if (clicked == 4)
                {
                    resetColor();
                }

                resetColor();
                Thread.Sleep(100);

                clear();
            }


        }

        


    }



}

