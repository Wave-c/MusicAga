using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.Accessories
{
    public class Accessory : AudioDevice
    {
        public string Material { get; set; } // e.g., PVC, Cotton
        public string AccessoryType { get; set; } // e.g., Cable, Stand

        public Accessory(string name, string brand, decimal price, string type, int year, string material, string accessoryType)
            : base(name, brand, price, type, year)
        {
            Material = material;
            AccessoryType = accessoryType;
        }

        public Accessory() { }
    }
}