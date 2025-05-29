using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.Equipment
{
    public class AudioInterface : AudioDevice
    {
        public int InputChannels { get; set; }
        public int OutputChannels { get; set; }
        public string Connectivity { get; set; } // USB, Firewire, etc.

        public AudioInterface(string name, string brand, decimal price, string type, int year, int inputChannels, int outputChannels, string connectivity)
            : base(name, brand, price, type, year)
        {
            InputChannels = inputChannels;
            OutputChannels = outputChannels;
            Connectivity = connectivity;
        }

        public override string ToString()
        {
            return "AudioInterface: " + base.ToString() + InputChannels + " " + OutputChannels + " " + Connectivity;
        }
    }
}