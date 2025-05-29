using MusicAga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga
{
    internal interface IDataFactory
    {
        AppDbContext CreateContext(string filePath);
        AppDbContext CreateContext(FileInfo file);
    }
}
