using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicAga.Models
{
    [PrimaryKey(nameof(Id))]
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity() 
        {
            Id = Guid.NewGuid();
        }
    }
}
