using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.SoundSources.Categories.StringsCategory
{
    internal class Cello : Strings
    {
        public bool MassiveTop { get; set; }
        public bool HousseInclude { get; set; }
        public bool IncludeBow { get; set; }

        public Cello(bool massiveTop, bool housseInclude, bool includeBow, string body, string fretbboard, string name, string brand, decimal price, string type, int year, string sourceType, string pickupType) : base(body, fretbboard, name, brand, price, type, year, sourceType, pickupType)
        {
            MassiveTop = massiveTop;
            HousseInclude = housseInclude;
            IncludeBow = includeBow;
        }

        public override string ToString()
        {
            return "Cello: " + MassiveTop + " " + HousseInclude + " " + IncludeBow;
        } 
    }
}
