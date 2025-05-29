using MusicAga.Services;

class MainMenu
{
    private static EntityService _entityService = new EntityService();

    static void ShowMainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("КАРТОТЕКА МУЗЫКАЛЬНОГО ОБОРУДОВАНИЯ\n");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Показать все оборудование");
        Console.WriteLine("2. Добавить оборудование");
        Console.WriteLine("3. Удалить оборудование");
        Console.WriteLine("4. Редактировать оборудование");

        Console.WriteLine("0. Выход\n");
        Console.ResetColor();
    }

    static int UserChoice()
    {
        Console.Write("Действие: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 5)
                return choice;

            Console.Write("Ошибка! Введите число от 0 до 5: ");
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
                    _entityService.Delete();
                    break;

                case 4:
                    _entityService.Update();
                    break;

            }
        }
    }
}