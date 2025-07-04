﻿using MusicAga.Models;
using MusicAga.Models.Accessories;
using MusicAga.Models.Equipment;
using MusicAga.Models.IOSound;
using MusicAga.Models.SoundSources.Categories.StringsCategory;
using MusicAga.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Crud
{
	internal class CrudUI : ICrudUI
	{
		private EntityService _entityService = new EntityService();

        private void printCategory(short userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    foreach (var e in AppDbContext.GetContext().electricGuitars) { Console.WriteLine(e.ToString()); }
                    break;
                case 2:
                    foreach (var e in AppDbContext.GetContext().cellos) { Console.WriteLine(e.ToString()); }
                    break;
                case 3:
                    foreach (var e in AppDbContext.GetContext().violins) { Console.WriteLine(e.ToString()); }
                    break;
                case 4:
                    foreach (var e in AppDbContext.GetContext().mixers) { Console.WriteLine(e.ToString()); }
                    break;
                case 5:
                    foreach (var e in AppDbContext.GetContext().audioInterfaces) { Console.WriteLine(e.ToString()); }
                    break;
                case 6:
                    foreach (var e in AppDbContext.GetContext().accessories) { Console.WriteLine(e.ToString()); }
                    break;
                case 7:
                    foreach (var e in AppDbContext.GetContext().headphones) { Console.WriteLine(e.ToString()); }
                    break;
                case 8:
                    foreach (var e in AppDbContext.GetContext().microphones) { Console.WriteLine(e.ToString()); }
                    break;
                default:
                    return;
            }
        }

		public void Create()
		{
            while(true)
            {
                try
                {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("CREATE MENU\n");
            Console.ResetColor();

            string body; string fretbboard; string pickupType;

			Console.Write("Enter model name: ");
			string userSubjectName = Console.ReadLine();

			Console.Write("\nEnter model brand: ");
			string userSubjectBrand = Console.ReadLine();

			Console.Write("\nEnter model price: ");
			decimal userSubjectPrice = Convert.ToDecimal(Console.ReadLine());

			Console.Write("\nEnter year of model issue: ");
			int userSubjectCreationYear = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nCategory: ");

			Console.Write("1. Electro guitar\n2. Cello\n3. Violin\n4. Mixer\n5. Audio interface\n6. Accesories\n7. Headphones\n8. Microphones\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nEnter type: ");
            Console.ResetColor();

            int userSubjectType = Convert.ToInt32(Console.ReadLine());

			switch (userSubjectType)
			{
                case 0:
                    return;
				case 1:

                    Console.Clear();
					Console.Write("Enter neck type: ");
					string neckType = Console.ReadLine();

					Console.Write("\nEnter frets count: ");
					uint fretsCount = Convert.ToUInt32(Console.ReadLine());

					Console.Write("\nEnter pickup system type: ");
					string pickupSystemType = Console.ReadLine();

					Console.Write("\nEnter scale: ");
					uint scale = Convert.ToUInt32(Console.ReadLine());

					Console.Write("\nEnter tremolo type: ");
					string tremoloType = Console.ReadLine();

					Console.Write("\nEnter body material: ");
					body = Console.ReadLine();

					Console.Write("\nEnter fretbboard type: ");
					fretbboard = Console.ReadLine();

					Console.Write("\nEnter pickup type: ");
					pickupType = Console.ReadLine();

                            _entityService.Add(new ElectricGuitar(neckType, fretsCount, scale, tremoloType, body, fretbboard, userSubjectName, userSubjectBrand, userSubjectPrice, "ElectricGuitar", userSubjectCreationYear, pickupSystemType));
                            return;

				case 2:
					Console.Write("\nEnter body material: ");
					body = Console.ReadLine();

					Console.Write("\nEnter fretbboard type: ");
					fretbboard = Console.ReadLine();

					Console.Write("\nEnter pickup type: ");
					pickupType = Console.ReadLine();

					Console.Write("\nEnter massive top presence status: ");
					bool massiveTopPresence = Convert.ToBoolean(Console.ReadLine());

					Console.Write("\nEnter housse presence status: ");
					bool houssePresence = Convert.ToBoolean(Console.ReadLine());

					Console.Write("\nEnter bow presence status: ");
					bool celloBowPresence = Convert.ToBoolean(Console.ReadLine());

                            _entityService.Add(new Cello(massiveTopPresence, houssePresence, celloBowPresence, body, fretbboard, userSubjectName, userSubjectBrand, userSubjectPrice, "Cello", userSubjectCreationYear, pickupType));
                            return;

				case 3:
					Console.Write("\nEnter body material: ");
					body = Console.ReadLine();

					Console.Write("\nEnter fretbboard type: ");
					fretbboard = Console.ReadLine();

					Console.Write("\nEnter pickup type: ");
					pickupType = Console.ReadLine();

					Console.Write("\nEnter bow presence status: ");
					bool violinBowPresence = Convert.ToBoolean(Console.ReadLine());

					Console.Write("\nEnter tunners presence status: ");
					bool fineTunnersPresence = Convert.ToBoolean(Console.ReadLine());

					Console.Write("\nEnter flamed back presence status: ");
					bool flamedBackPresence = Convert.ToBoolean(Console.ReadLine());

					Console.Write("\nEnter tuning screw for Estring presence status: ");
					bool fineTuningScrewForEStringPresence = Convert.ToBoolean(Console.ReadLine());

                            _entityService.Add(new Violin(violinBowPresence, fineTunnersPresence, flamedBackPresence, fineTuningScrewForEStringPresence, body, fretbboard, userSubjectName, userSubjectBrand, userSubjectPrice, "Violin", userSubjectCreationYear, pickupType));
                            return;

				case 4:
					Console.Write("\nEnter channels count: ");
					int channelsCount = Convert.ToInt32(Console.ReadLine());

					Console.Write("\nEnter effects presence status: ");
					bool effectsPresence = Convert.ToBoolean(Console.ReadLine());

                            _entityService.Add(new Mixer(userSubjectName, userSubjectBrand, userSubjectPrice, "Mixer", userSubjectCreationYear, channelsCount, effectsPresence));
                            return;

				case 5:
					Console.Write("\nEnter input channels count: ");
					int inputChannelsCount = Convert.ToInt32(Console.ReadLine());

					Console.Write("\nEnter output channels count: ");
					int outputChannelsCount = Convert.ToInt32(Console.ReadLine());

					Console.Write("\nEnter connectivity type: ");
					string connectivityType = Console.ReadLine();

                            _entityService.Add(new AudioInterface(userSubjectName, userSubjectBrand, userSubjectPrice, "AudioInterface", userSubjectCreationYear, inputChannelsCount, outputChannelsCount, connectivityType));
                            return;

				case 6:
					Console.Write("\nEnter accessory type: ");
					string typeOfAccessory = Console.ReadLine();

					Console.Write("\nEnter material type: ");
					string materialType = Console.ReadLine();

                            _entityService.Add(new Accessory(userSubjectName, userSubjectBrand, userSubjectPrice, "Accessory", userSubjectCreationYear, materialType, typeOfAccessory));
                            return;

				case 7:
					Console.Write("\nEnterheadphones type: ");
					string headphonesType = Console.ReadLine();

					Console.Write("\nEnter impedance type: ");
					string impedanceType = Console.ReadLine();

                            _entityService.Add(new Headphone(userSubjectName, userSubjectBrand, userSubjectPrice, "Headphone", userSubjectCreationYear, impedanceType, headphonesType));
                            return;

				case 8:
					Console.Write("\nEnter frequency Response type: ");
					string frequencyResponseType = Console.ReadLine();

					Console.Write("\nEnter polar Pattern type: ");
					string polarPatternType = Console.ReadLine();

                            _entityService.Add(new Microphone(userSubjectName, userSubjectBrand, userSubjectPrice, "Microphone", userSubjectCreationYear, frequencyResponseType, polarPatternType));
                            return;

                        default:
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
		}

        public void Delete()
		{
            while (true)
            {
                try
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

                    short userChoice = Convert.ToInt16(Console.ReadLine());

                    printCategory(userChoice);


                    Console.Write("Enter ID: ");
                    Guid id = new Guid(Console.ReadLine());

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Card ID: {id}\nName: {_entityService.GetById(id).Name}\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Confirm deletion? [y/n] > ");
                        Console.ResetColor();

                        string EnterDelete = Console.ReadLine();
                        Console.Clear();

                        if (EnterDelete == "y")
                        {
                            _entityService.DeleteById(id);
                            break;
                        }
                        else if (EnterDelete == "n")
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
            }

		public void Read()
		{

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("READ MENU\n");
            Console.ResetColor();
            var all = _entityService.GetAll();
			foreach (var entity in all)
			{
				Console.WriteLine(entity.ToString());
			}

            while (true)
            {
                Console.Write("\nDo you want to check the inner fileds of one of the classes? [y/n] > ");
                string userChoice = Console.ReadLine();

                if (userChoice == "y")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\nEnter card ID that you intrested in: ");
                    Console.ResetColor();

                    Guid userCardId;

                    while (true)
                    {
                        try
                        {
                            userCardId = new Guid(Console.ReadLine());
                            Console.WriteLine();
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e);
                            continue;
                        }
                    }

                    var gettedDevice = _entityService.GetById(userCardId);
                    switch (gettedDevice.Type)
                    {
                        case "ElectricGuitar":
                            Console.Write((gettedDevice as ElectricGuitar).ToString());
                            break;
                        case "Cello":
                            Console.Write((gettedDevice as Cello).ToString());
                            break;
                        case "Violin":
                            Console.Write((gettedDevice as Violin).ToString());
                            break;
                        case "Mixer":
                            Console.Write((gettedDevice as Mixer).ToString());
                            break;
                        case "AudioInterface":
                            Console.Write((gettedDevice as AudioInterface).ToString());
                            break;
                        case "Accessory":
                            Console.Write((gettedDevice as Accessory).ToString());
                            break;
                        case "Headphone":
                            Console.Write((gettedDevice as Headphone).ToString());
                            break;
                        case "Microphone":
                            Console.Write((gettedDevice as Microphone).ToString());
                            break;
                    }
                    Console.ReadKey();
                }
                //else if (userChoice == "n")
                //{
                //    break;
                //}
                break;
            }
		}

		public void Update()
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

            short userChoice = Convert.ToInt16(Console.ReadLine());

            if(userChoice == 0)
            {
                return;
            }

            printCategory(userChoice);

            Guid id;

            while (true)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    id = new Guid(Console.ReadLine());
                    
                



                string changeAgain = "y";

            switch (userChoice)
            {
                case 0:
                    return;

                case 1:
                    var updatedElectricGuitar = (_entityService.GetById(id) as ElectricGuitar);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedElectricGuitar.Name}\n");
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
                        short changeChoice = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine();


                        switch (changeChoice)
                        {
                            case 0:
                                return;

                            case 1:
                                Console.Write("Enter new neck type: ");
                                string neckType = Console.ReadLine();
                                updatedElectricGuitar.Neck = neckType;
                                break;
                            case 2:
                                Console.Write("Enter new frets count: ");
                                uint fretsCount = Convert.ToUInt32(Console.ReadLine());
                                updatedElectricGuitar.Frets = fretsCount;
                                break;

                            case 3:
                                Console.Write("Enter new pickup system type: ");
                                string pickupSystemType = Console.ReadLine();
                                updatedElectricGuitar.PickupType = pickupSystemType;
                                break;

                            case 4:
                                Console.Write("Enter new scale: ");
                                uint scale = Convert.ToUInt32(Console.ReadLine());
                                updatedElectricGuitar.ScaleMM = scale;
                                break;

                            case 5:
                                Console.Write("Enter new tremolo type: ");
                                string tremoloType = Console.ReadLine();
                                updatedElectricGuitar.Tremolo = tremoloType;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 2:
                    var updatedCello = (_entityService.GetById(id) as Cello);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedCello.Name}\n");
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
                                updatedCello.MassiveTop = massiveTopPresence;
                                break;
                            case 2:
                                Console.Write("Enter new housse presence status: ");
                                bool houssePresence = Convert.ToBoolean(Console.ReadLine());
                                updatedCello.HousseInclude = houssePresence;
                                break;

                            case 3:
                                Console.Write("Enter new bow presence status: ");
                                bool celloBowPresence = Convert.ToBoolean(Console.ReadLine());
                                updatedCello.IncludeBow = celloBowPresence;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 3:
                    var updatedViolin = (_entityService.GetById(id) as Violin);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedViolin.Name}\n");
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
                                updatedViolin.IncludeBow = violinBowPresence;
                                break;
                            case 2:
                                Console.Write("Enter new tunners presence status: ");
                                bool fineTunnersPresence = Convert.ToBoolean(Console.ReadLine());
                                updatedViolin.FineTuners = fineTunnersPresence;
                                break;

                            case 3:
                                Console.Write("Enter new flamed back presence status: ");
                                bool flamedBackPresence = Convert.ToBoolean(Console.ReadLine());
                                updatedViolin.FlamedBack = flamedBackPresence;
                                break;

                            case 4:
                                Console.Write("Enter new tuning screw for Estring presence status: ");
                                bool fineTuningScrewForEStringPresence = Convert.ToBoolean(Console.ReadLine());
                                updatedViolin.FineTuningScrewForEString = fineTuningScrewForEStringPresence;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 4:
                    var updatedMixer = (_entityService.GetById(id) as Mixer);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedMixer.Name}\n");
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
                                updatedMixer.Channels = channelsCount;
                                break;
                            case 2:
                                Console.Write("Enter new effects presence status: ");
                                bool effectsPresence = Convert.ToBoolean(Console.ReadLine());
                                updatedMixer.HasEffects = effectsPresence;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 5:
                    var updatedAudioInterface = (_entityService.GetById(id) as AudioInterface);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedAudioInterface.Name}\n");
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
                                updatedAudioInterface.InputChannels = inputChannelsCount;
                                break;
                            case 2:
                                Console.Write("Enter new output channels count: ");
                                int outputChannelsCount = Convert.ToInt32(Console.ReadLine());
                                updatedAudioInterface.OutputChannels = outputChannelsCount;
                                break;

                            case 3:
                                Console.Write("Enter new connectivity type: ");
                                string connectivityType = Console.ReadLine();
                                updatedAudioInterface.Connectivity = connectivityType;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 6:
                    var updatedAccessory = (_entityService.GetById(id) as Accessory);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedAccessory.Name}\n");
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
                                updatedAccessory.AccessoryType = typeOfAccessory;
                                break;
                            case 2:
                                Console.Write("Enter new material type: ");
                                string materialType = Console.ReadLine();
                                updatedAccessory.Material = materialType;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 7:
                    var updatedHeadphone = (_entityService.GetById(id) as Headphone);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedHeadphone.Name}\n");
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
                                updatedHeadphone.HeadphoneType = headphonesType;
                                break;
                            case 2:
                                Console.Write("Enter new impedance type: ");
                                string impedanceType = Console.ReadLine();
                                updatedHeadphone.Impedance = impedanceType;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                case 8:
                    var updatedMicrophone = (_entityService.GetById(id) as Microphone);
                    while (changeAgain != "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Card ID: {id}\nName: {updatedMicrophone.Name}\n");
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
                                updatedMicrophone.FrequencyResponse = frequencyResponseType;
                                break;
                            case 2:
                                Console.Write("Enter new polar Pattern type: ");
                                string polarPatternType = Console.ReadLine();
                                updatedMicrophone.PolarPattern = polarPatternType;
                                break;
                        }
                        while (true)
                        {
                            Console.Write("Wanna to change card again? [y/n] > ");
                            changeAgain = Console.ReadLine();
                            Console.Clear();
                            if ((changeAgain == "y") || (changeAgain == "n"))
                            {
                                break;
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
        }

	}
}
