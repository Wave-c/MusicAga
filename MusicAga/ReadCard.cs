using System;


namespace MusicAga.Models
{
    internal class ReadCards
    {
        public void ReadCard()
        {
            

            Console.WriteLine("Do you want to check the inner fileds of one of the classes?");
            bool userChoice = Convert.ToBoolean(Console.ReadLine());
            if (userChoice == true)
            {
                Console.WriteLine("Enter card id that you intrested in: ");
                Guid userCardId = new Guid(Console.ReadLine());
            }
        }
    }
}
