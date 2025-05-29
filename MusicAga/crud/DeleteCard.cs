using MusicAga.Models.SoundSources.Categories.StringsCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace MusicAga.crud
//{
//}

class DeleteCard
{
	public static void Delete()
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("DELETE MENU\n");
		Console.ResetColor();

		Console.WriteLine("1. Electro guitar");
		Console.WriteLine("2. Cello");
		Console.WriteLine("3. Violin");
		Console.WriteLine("4. Mixer");
		Console.WriteLine("5. Audio interface");
		Console.WriteLine("6. Accesories");
		Console.WriteLine("7. Headphones");
		Console.WriteLine("8. Microphones\n");

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("0. Exit\n");
		Console.ResetColor();


		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.Write("Category: ");
		Console.ResetColor();

		int UserChoice = Convert.ToInt32(Console.ReadLine());

		Console.Clear();
		Console.Write("Enter ID: ");
		int ID = Convert.ToInt32(Console.ReadLine());

		switch (UserChoice)
		{
			case 0:
				return;

			case 1:
				while (true)
				{
					Console.Clear();
					Console.WriteLine($"Card ID: {ID}\nName: \n");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Confirm deletion? [y/n] > ");
					Console.ResetColor();

					string EnterDelete = Console.ReadLine();
					Console.Clear();

					if (EnterDelete == "y")
					{
						break;
					}
					else if (EnterDelete == "n")
					{
						break;
					}
					break;
				}
				break;
            case 2:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 3:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 4:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 5:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 6:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 7:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
            case 8:
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Card ID: {ID}\nName: \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Confirm deletion? [y/n] > ");
                    Console.ResetColor();

                    string EnterDelete = Console.ReadLine();
                    Console.Clear();

                    if (EnterDelete == "y")
                    {
                        break;
                    }
                    else if (EnterDelete == "n")
                    {
                        break;
                    }
                    break;
                }
                break;
        }
    }
}