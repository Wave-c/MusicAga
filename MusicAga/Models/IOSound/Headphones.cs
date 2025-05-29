using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.IOSound
{
    public class Headphone : AudioDevice
    {
        public string Impedance { get; set; } // e.g., 32 Ohms
        public string HeadphoneType { get; set; } // e.g., Over-ear, In-ear

        public Headphone(string name, string brand, decimal price, string type, int year, string impedance, string headphoneType)
            : base(name, brand, price, type, year)
        {
            Impedance = impedance;
            HeadphoneType = headphoneType;
        }

        public Headphone() { }

        public override string ToString()
        {
            return "Headphone: " + base.ToString() + " " + Impedance + " " + HeadphoneType;
        }
    }
}