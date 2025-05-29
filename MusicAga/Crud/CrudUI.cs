using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Crud
{
    internal class CrudUI : ICrudUI
    {
        public void Create()
        {
            Console.WriteLine("Enter model name: ");
            string userSubjectName = Console.ReadLine();

            Console.WriteLine("Enter model brand: ");
            string userSubjectBrand = Console.ReadLine();

            Console.WriteLine("Enter model price: ");
            decimal userSubjectPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year of model issue: ");
            int userSubjectCreationYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter type: ");
            Console.WriteLine("1. Electro guitar\n2. Cello\n3. Violin\n4. Mixer\n5. Audio interface\n6. Accesories\n7. Headphones\n8. Microphones\n");
            int userSubjectType = Convert.ToInt32(Console.ReadLine());

            switch (userSubjectType)
            {
                case 1:
                    Console.WriteLine("Enter neck type: ");
                    string neckType = Console.ReadLine();

                    Console.WriteLine("Enter frets count: ");
                    uint fretsCount = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Enter pickup system type: ");
                    string pickupSystemType = Console.ReadLine();

                    Console.WriteLine("Enter scale: ");
                    uint scale = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Enter tremolo type: ");
                    string tremoloType = Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("Enter massive top presence status: ");
                    bool massiveTopPresence = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter housse presence status: ");
                    bool houssePresence = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter bow presence status: ");
                    bool celloBowPresence = Convert.ToBoolean(Console.ReadLine());

                    break;

                case 3:
                    Console.WriteLine("Enter bow presence status: ");
                    bool violinBowPresence = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter tunners presence status: ");
                    bool fineTunnersPresence = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter flamed back presence status: ");
                    bool flamedBackPresence = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter tuning screw for Estring presence status: ");
                    bool fineTuningScrewForEStringPresence = Convert.ToBoolean(Console.ReadLine());

                    break;

                case 4:
                    Console.WriteLine("Enter channels count: ");
                    int channelsCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter effects presence status: ");
                    bool effectsPresence = Convert.ToBoolean(Console.ReadLine());

                    break;

                case 5:
                    Console.WriteLine("Enter input channels count: ");
                    int inputChannelsCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter output channels count: ");
                    int outputChannelsCount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter connectivity type: ");
                    string connectivityType = Console.ReadLine();

                    break;

                case 6:
                    Console.WriteLine("Enter accessory type: ");
                    string typeOfAccessory = Console.ReadLine();

                    Console.WriteLine("Enter material type: ");
                    string materialType = Console.ReadLine();

                    break;

                case 7:
                    Console.WriteLine("Enterheadphones type: ");
                    string headphonesType = Console.ReadLine();

                    Console.WriteLine("Enter impedance type: ");
                    string impedanceType = Console.ReadLine();

                    break;

                case 8:
                    Console.WriteLine("Enter frequency Response type: ");
                    string frequencyResponseType = Console.ReadLine();

                    Console.WriteLine("Enter polar Pattern type: ");
                    string polarPatternType = Console.ReadLine();

                    break;

                default:
                    break;
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            Console.WriteLine("Do you want to check the inner fileds of one of the classes?");
            bool userChoice = Convert.ToBoolean(Console.ReadLine());
            if (userChoice == true)
            {
                Console.WriteLine("Enter card id that you intrested in: ");
                Guid userCardId = new Guid(Console.ReadLine());
            }
        }

        public void Update()
        {
            Console.WriteLine("1. Аксессуары");
            Console.WriteLine("2. Оборудование");
            Console.WriteLine("3. Вывод-Ввод звука");
            Console.WriteLine("4. Источники звука");

            Console.WriteLine("Укажите нужную категорию карты: ");
        }
    }
}
