using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.IOSound
{
    public class Microphone : AudioDevice
    {
        public string FrequencyResponse { get; set; } // e.g., 20 Hz - 20 kHz
        public string PolarPattern { get; set; } // e.g., Cardioid, Omnidirectional

        public Microphone(string name, string brand, decimal price, string type, int year, string frequencyResponse, string polarPattern)
            : base(name, brand, price, type, year)
        {
            FrequencyResponse = frequencyResponse;
            PolarPattern = polarPattern;
        }

        public Microphone() { }

        public override string ToString()
        {
            return "Microphone: " + base.ToString() + " " + FrequencyResponse + " " + PolarPattern;
        }
    }
}