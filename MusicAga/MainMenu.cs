using MusicAga.Models;

class MainMenu 
{
    static void ShowMainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("MUSICAL EQUIPMENT DATABASE\n");
        Console.ResetColor();

        Console.WriteLine("1. Create");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Update");
        Console.WriteLine("4. Delete\n");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("0. Exit\n");
        Console.ResetColor();
    }

    static int UserChoice()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Your action: ");
        Console.ResetColor();

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 4)
                return choice;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error! Please enter a number from 0 to 4: ");
            Console.ResetColor();
        }
    }


    public static void HandleMainMenu()
    {
        while (true)
        {
            ShowMainMenu();
            int choice = UserChoice();

            switch (choice)
            {
                case 0:
                    return;
                //break;

                case 1:
                    CreateCards.CreateCard();
                    break;

                case 2:
                    break;

                case 3:
                    UpdateCard.Update();
                    break;

                case 4:
                    break;

                default:
                    break;
            }
        }
    }
}