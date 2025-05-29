using MusicAga.Models;

class MainMenu 
{
    private static EntityService _entityService = new EntityService();
    private static IDataFactory _dataFactory = new DataContextFactory();
    private static CrudUI _crudUI = new CrudUI();

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
            var a = AppDbContext.GetContext();
            ShowMainMenu();
            int choice;
            Console.Write("Your action: ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 0:
                    return;

                case 1:
                    _crudUI.Create();
                    break;
                case 2:
                    _crudUI.Read();
                    break;

                case 3:
                    _crudUI.Update();
                    break;

                case 4:
                    _crudUI.Delete();
                    break;

                default:
                    break;

            }
        }
    }
}