using System;
using Snake;




void resetColor()
{
    Console.ForegroundColor = ConsoleColor.White;
}

void highlight()
{
    Console.ForegroundColor = Settings.selectedColor;

}

void clear()
{
    int numberOfLines = Console.CursorTop;

    Console.SetCursorPosition(0, Console.CursorTop - numberOfLines);
    for (int i = 0; i < numberOfLines; i++)
    {
        Console.Write(new string(' ', Console.WindowWidth));
    }
    Console.SetCursorPosition(0, Console.CursorTop - numberOfLines);
}

int selected = 3;

var selectedPrefix = Settings.mainMenuSelected;

var play = "";
var settings = "";
var exit = "";

while (true)
{
    var clicked = 0;


    if (Console.KeyAvailable)
    {
        var clickedKey = Console.ReadKey().Key;

        if (clickedKey == Settings.up)
        {
            clicked = 1;

            if (selected < 3)
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

            if (selected == 3)
            {
                clear();
                new Game();

            }

            if (selected == 2)
            {
                clear();
                new Settings();

            }

            if (selected == 1)
            {
                clear();
                break;

            }

        }



    }




    Console.WriteLine("                                     ");
    Console.WriteLine("                Snake                ");
    Console.WriteLine("                                     ");

    if (selected == 3)
    {
        highlight();
        play = selectedPrefix;
        settings = " ";
        exit = " ";
    }
    Console.WriteLine($"       {play}         Play        {play}       ");
    resetColor();

    if (selected == 2)
    {
        highlight();
        play = " ";
        settings = selectedPrefix;
        exit = " ";
    }
    Console.WriteLine($"       {settings}       Settings      {settings}       ");
    resetColor();

    if (selected == 1)
    {
        highlight();
        play = " ";
        settings = " ";
        exit = selectedPrefix;
    }
    Console.WriteLine($"       {exit}         Exit        {exit}       ");
    resetColor();



    Console.Write("\n===========================================\n");
    if (clicked == 1)
    {
        highlight();
    }

    Console.Write("                   ↑                      \n");

    if (clicked == 1)
    {
        resetColor();
    }

    if (clicked == 3)
    {
        highlight();
    }
    Console.Write("                ← ");

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

    Console.Write(" →                \n");

    if (clicked == 4)
    {
        resetColor();
    }

    resetColor();
    Thread.Sleep(100);

    clear();
}

Console.WriteLine("Thank you for playing!");