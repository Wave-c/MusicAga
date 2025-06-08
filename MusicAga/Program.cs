using MusicAga.Logger;
using MusicAga.Models;

namespace MusicAga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomFileLogger.GetLogger().Log("App start", LogLevel.Info);
            MainMenu.HandleMainMenu();
        }
    }
}
