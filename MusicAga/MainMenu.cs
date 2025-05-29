using MusicAga.Services;

class MainMenu 
{
    private static EntityService _entityService = new EntityService();

    static void ShowMainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("MUSICAL EQUIPMENT DATABASE\n");
        Console.ResetColor();

        Console.WriteLine("1. Show all equipment");
        Console.WriteLine("2. Create");
        Console.WriteLine("3. Read");
        Console.WriteLine("4. Update");
        Console.WriteLine("5. Delete\n");

        Console.WriteLine("0. Exit\n");
    }

    static int UserChoice()
    {

        Console.Write("Your action: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 5)
                return choice;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error! Please enter a number from 0 to 5: ");
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

                case 1:
                    _entityService.GetAll();
                    break;

                case 2:
                    _entityService.Add();
                    break;

                case 3:
                    //Update();
                    break;

                case 4:
                    _entityService.Update();
                    break;

                case 5:
                    break;

            }
        }
    }
}