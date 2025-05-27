using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.SoundSources.Categories
{
    public abstract class Strings : AudioDevice
    {
        protected Strings(string body, string fretbboard, string name, string brand, decimal price, string type, int year) : base(name, brand, price, type, year)
        {
            Body = body;
            Fretbboard = fretbboard;
        }

        public Strings() { }

        public string Body { get; set; }
        public string Fretbboard { get; set; }
    }
}
