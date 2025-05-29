using MusicAga.Models;
using MusicAga.Models.Accessories;
using MusicAga.Models.Equipment;
using MusicAga.Models.IOSound;
using MusicAga.Models.SoundSources.Categories.StringsCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Services
{
    internal class EntityService
    {
        public void Add(AudioDevice entity)
        {
            switch (entity.Type)
            {
                case "ElectricGuitar":
                    AppDbContext.GetContext().electricGuitars.Add((ElectricGuitar)entity);
                    break;
                case "Cello":
                    AppDbContext.GetContext().cellos.Add((Cello)entity);
                    break;
                case "Violin":
                    AppDbContext.GetContext().violins.Add((Violin)entity);
                    break;
                case "Mixer":
                    AppDbContext.GetContext().mixers.Add((Mixer)entity);
                    break;
                case "AudioInterface":
                    AppDbContext.GetContext().audioInterfaces.Add((AudioInterface)entity);
                    break;
                case "Accessory":
                    AppDbContext.GetContext().accessories.Add((Accessory)entity);
                    break;
                case "Headphone":
                    AppDbContext.GetContext().headphones.Add((Headphone)entity);
                    break;
                case "Microphone":
                    AppDbContext.GetContext().microphones.Add((Microphone)entity);
                    break;
            }
        }

        public void Delete()
        {

        }

        public void Update()
        {

        }

        public void GetAll()
        {

        }
    }
}
