using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models
{
    public abstract class AudioDevice : Entity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }

        protected AudioDevice(string name, string brand, decimal price, string type, int year)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Type = type;
            Year = year;
        }

        public AudioDevice() { }
    }
}