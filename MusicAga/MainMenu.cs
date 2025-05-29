class MainMenu
{
    //static void Main()
    //{
    //    HandleMainMenu();

    //}

    static void ShowMainMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("КАРТОТЕКА МУЗЫКАЛЬНОГО ОБОРУДОВАНИЯ\n");
        Console.ResetColor();

        Console.WriteLine("1. Показать все оборудование");
        Console.WriteLine("2. Поиск по названию/бренду");
        Console.WriteLine("3. Поиск по категории\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("4. Добавить новое оборудование");
        Console.WriteLine("5. Редактировать карточку");
        Console.ResetColor();

        Console.WriteLine("0. Выход\n");

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

    static void HandleMainMenu()
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
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

            }
        }
    }
}