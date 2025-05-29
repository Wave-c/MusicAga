using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Crud
{
    internal interface ICrudUI
    {
        void Create();
        void Update();
        void Read();
        void Delete();
    }
}
