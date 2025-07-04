﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Models.SoundSources.Categories
{
    public abstract class Strings : SoundSource
    {
        protected Strings(string body, string fretbboard, string name, string brand, decimal price, string type, int year, string sourceType, string pickupType) : base(name, brand, price, type, year, sourceType, pickupType)
        {
            Body = body;
            Fretbboard = fretbboard;
        }

        public string Body { get; set; }
        public string Fretbboard { get; set; }

        public override string ToString()
        {
            return base.ToString();
        } 
    }
}
