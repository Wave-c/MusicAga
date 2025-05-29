using MusicAga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicAga
{
    internal class DataContextFactory : IDataFactory
    {
        public AppDbContext CreateContext(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                return CreateContext(fileInfo);
            }
            throw new FileNotFoundException();
        }

        public AppDbContext CreateContext(FileInfo file)
        {
            var context = JsonSerializer.Deserialize<AppDbContext>(File.ReadAllText(file.FullName));
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            return context;
        }
    }
}
