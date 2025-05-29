using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace MusicAga.Models
//{
//}

class UpdateCard
{
	public static void Update()
	{
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("UPDATE MENU\n");
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

        string ChangeAgain = "y";


        switch (UserChoice)
		{
            case 0:
                return;

			case 1:
                while (ChangeAgain != "n")
				{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Neck type");
                    Console.WriteLine("2. Frets count");
                    Console.WriteLine("3. Pickup system type");
                    Console.WriteLine("4. Scale");
                    Console.WriteLine("5. Tremolo type\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new neck type: ");
                            string neckType = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter new frets count: ");
                            uint fretsCount = Convert.ToUInt32(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Enter new pickup system type: ");
                            string pickupSystemType = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("Enter new scale: ");
                            uint scale = Convert.ToUInt32(Console.ReadLine());
                            break;

                        case 5:
                            Console.Write("Enter new tremolo type: ");
                            string tremoloType = Console.ReadLine();
                            break;
                    }
					while (true) {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
							break;
                        }
                    }
                }
                break;

            case 2:

                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Massive top presence status");
                    Console.WriteLine("2. Housse presence status");
                    Console.WriteLine("3. Bow presence status\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new massive top presence status: ");
                            bool massiveTopPresence = Convert.ToBoolean(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter new housse presence status: ");
                            bool houssePresence = Convert.ToBoolean(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Enter new bow presence status: ");
                            bool celloBowPresence = Convert.ToBoolean(Console.ReadLine());
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 3:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Bow presence status");
                    Console.WriteLine("2. Tunners presence status");
                    Console.WriteLine("3. Flamed back presence status");
                    Console.WriteLine("4. Tuning screw for Estring presence status\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new bow presence status: ");
                            bool violinBowPresence = Convert.ToBoolean(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter new tunners presence status: ");
                            bool fineTunnersPresence = Convert.ToBoolean(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Enter new flamed back presence status: ");
                            bool flamedBackPresence = Convert.ToBoolean(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("Enter new tuning screw for Estring presence status: ");
                            bool fineTuningScrewForEStringPresence = Convert.ToBoolean(Console.ReadLine());
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 4:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Channels count");
                    Console.WriteLine("2. Effects presence status\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new channels count: ");
                            int channelsCount = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter new effects presence status: ");
                            bool effectsPresence = Convert.ToBoolean(Console.ReadLine());
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 5:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Input channels count");
                    Console.WriteLine("2. Output channels count");
                    Console.WriteLine("3. Connectivity type\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new input channels count: ");
                            int inputChannelsCount = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter new output channels count: ");
                            int outputChannelsCount = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Enter new connectivity type: ");
                            string connectivityType = Console.ReadLine();
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 6:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Accessory type");
                    Console.WriteLine("2. Material type\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new accessory type: ");
                            string typeOfAccessory = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter new material type: ");
                            string materialType = Console.ReadLine();
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 7:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Headphones type");
                    Console.WriteLine("2. Impedance type\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new headphones type: ");
                            string headphonesType = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter new impedance type: ");
                            string impedanceType = Console.ReadLine();
                            break;

                        case 3:

                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			case 8:
                while (ChangeAgain != "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("реализовать вывод айдишника и имя через $\"ID: {}, Name: {}\n");
                    Console.ResetColor();

                    Console.WriteLine("To change:\n");

                    Console.WriteLine("1. Frequency Response type");
                    Console.WriteLine("2. Polar Pattern type\n");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("0. Exit\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Your action: ");
                    Console.ResetColor();
                    int ChangeChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (ChangeChoice)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.Write("Enter new frequency Response type: ");
                            string frequencyResponseType = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter new polar Pattern type: ");
                            string polarPatternType = Console.ReadLine();
                            break;
                    }
                    while (true)
                    {
                        Console.Write("Wanna to change card again? [y/n] > ");
                        ChangeAgain = Console.ReadLine();
                        Console.Clear();
                        if ((ChangeAgain == "y") || (ChangeAgain == "n"))
                        {
                            break;
                        }
                    }
                }
                break;

			default:
                break;
		}
	}
}