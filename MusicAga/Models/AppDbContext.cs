using MusicAga.Models.Accessories;
using MusicAga.Models.Equipment;
using MusicAga.Models.IOSound;
using MusicAga.Models.SoundSources.Categories.StringsCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicAga.Models
{
    internal class AppDbContext
    {
        //когда-то тут были DbSet'ы
        public List<ElectricGuitar> electricGuitars { get; private set; }
        public List<Cello> cellos { get; private set; }
        public List<Violin> violins { get; private set; }
        public List<Mixer> mixers { get; private set; }
        public List<AudioInterface> audioInterfaces { get; private set; }
        public List<Accessory> accessories { get; private set; }
        public List<Headphone> headphones { get; private set; }
        public List<Microphone> microphones { get; private set; }

        //pattern singleton
        protected static AppDbContext instance;

        protected AppDbContext() 
        {
            electricGuitars = new List<ElectricGuitar>();
            cellos = new List<Cello>();
            violins = new List<Violin>();
            mixers = new List<Mixer>();
            audioInterfaces = new List<AudioInterface>();
            accessories = new List<Accessory>();
            headphones = new List<Headphone>();
            microphones = new List<Microphone>();
        }
        [JsonConstructorAttribute]
        protected AppDbContext(List<ElectricGuitar> electricGuitars, List<Cello> cellos, List<Violin> violins, List<Mixer> mixers, List<AudioInterface> audioInterfaces, List<Accessory> accessories, List<Headphone> headphones, List<Microphone> microphones)
        {
            this.electricGuitars = electricGuitars;
            this.cellos = cellos;
            this.violins = violins;
            this.mixers = mixers;
            this.audioInterfaces = audioInterfaces;
            this.accessories = accessories;
            this.headphones = headphones;
            this.microphones = microphones;
        }

        public static AppDbContext GetContext()
        {
            if(instance == null)
            {
                instance = new AppDbContext();
            }
            return instance;
        }

        public static AppDbContext LoadContext(List<ElectricGuitar> electricGuitars, List<Cello> cellos, List<Violin> violins, List<Mixer> mixers, List<AudioInterface> audioInterfaces, List<Accessory> accessories, List<Headphone> headphones, List<Microphone> microphones)
        {
            instance = new AppDbContext(electricGuitars, cellos, violins, mixers, audioInterfaces, accessories, headphones, microphones);
            return instance;
        }

        public static AppDbContext LoadContext(AppDbContext context)
        {
            instance = context;
            return instance;
        }

        public void SaveContext()
        {
            File.WriteAllText("data.json", JsonSerializer.Serialize(instance));
        }
    }
}
