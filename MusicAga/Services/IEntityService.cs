using MusicAga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Services
{
    internal interface IEntityService<T> where T : Entity
    {
        delegate void AddEntityHandler(T entity);
        delegate void DeleteByIdHandler(Guid id);
        delegate T GetByIdHandler(Guid id);

        event AddEntityHandler? AddEntity;
        event DeleteByIdHandler? DeleteById;
        event GetByIdHandler? GetById;
    }
}
