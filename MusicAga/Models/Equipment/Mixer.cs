using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.Equipment
{
    public class Mixer : AudioDevice
    {
        public int Channels { get; set; }
        public bool HasEffects { get; set; } // true if it has built-in effects

        public Mixer(string name, string brand, decimal price, string type, int year, int channels, bool hasEffects)
            : base(name, brand, price, type, year)
        {
            Channels = channels;
            HasEffects = hasEffects;
        }

        public override string ToString()
        {
            return "Mixer: " + base.ToString() + Channels + " " + HasEffects;
        }
    }
}