using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.SoundSources.Categories.StringsCategory
{
    internal class Violin : Strings
    {
        public bool IncludeBow { get; set; }
        public bool FineTuners { get; set; }
        public bool FlamedBack { get; set; }
        public bool FineTuningScrewForEString { get; set; }
        public Violin(bool includeBow, bool fineTuners, bool flamedBack, bool fineTuningScreForEString, string body, string fretbboard, string name, string brand, decimal price, string type, int year, string pickupType) : base(body, fretbboard, name, brand, price, type, year, "Acoustic", pickupType)
        {
            IncludeBow = includeBow;
            FineTuners = fineTuners;
            FlamedBack = flamedBack;
            FineTuningScrewForEString = fineTuningScreForEString;
        }


        public override string ToString()
        {
            return "Violin: " + IncludeBow + " " + FineTuners + " " + FlamedBack + " " + FineTuningScrewForEString + " " + Body + " " + Fretbboard + " " + SourceType + " " + PickupType;
        } 
    }
}
