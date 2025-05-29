using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicAga.Models.SoundSources.Categories;

namespace MusicAga.Models.SoundSources.Categories.StringsCategory
{
    internal class ElectricGuitar : Strings
    {
        public ElectricGuitar(string neck, uint frets, uint scaleMM, string tremolo, string body, string fretbboard, string name, string brand, decimal price, string type, int year, string pickupType) : base(body, fretbboard, name, brand, price, type, year, "Electric", pickupType)
        {
            Neck = neck;
            Frets = frets;
            ScaleMM = scaleMM;
            Tremolo = tremolo;
        }

        public string Neck { get; set; }
        public uint Frets { get; set; }
        public uint ScaleMM { get; set; }
        public string Tremolo { get; set; }

        public override string ToString()
        {
            return "Electro guitar: " + Neck + " " + Frets + " " + ScaleMM + " " + Tremolo;
        }  

    }
}
