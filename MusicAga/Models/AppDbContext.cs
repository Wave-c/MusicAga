using Microsoft.EntityFrameworkCore;
using MusicAga.Models.Accessories;
using MusicAga.Models.Equipment;
using MusicAga.Models.IOSound;
using MusicAga.Models.SoundSources.Categories.StringsCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<ElectricGuitar> electricGuitars { get; set; }
        public DbSet<Cello> cellos { get; set; }
        public DbSet<Violin> violins { get; set; }
        public DbSet<Mixer> mixers { get; set; }
        public DbSet<AudioInterface> audioInterfaces { get; set; }
        public DbSet<Accessory> accessories { get; set; }
        public DbSet<Headphone> headphones { get; set; }
        public DbSet<Microphone> microphones { get; set; }


        public AppDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=musical_equipment.db");
        }
    }
}
