using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.SoundSources
{
    public class SoundSource : AudioDevice
    {
        public string SourceType { get; set; } // Electric, Acoustic, etc.
        public string PickupType { get; set; } // e.g., Single Coil, Humbucker

        public SoundSource(string name, string brand, decimal price, string type, int year, string sourceType, string pickupType)
            : base(name, brand, price, type, year)
        {
            SourceType = sourceType;
            PickupType = pickupType;
        }
    }
}
