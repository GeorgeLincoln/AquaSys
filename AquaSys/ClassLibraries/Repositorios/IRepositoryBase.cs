using System.Collections.Generic;
using ClassLibraries.Data.Context;
using ClassLibraries.Models;

namespace ClassLibraries.Repositorios
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(long id);
        void Remove(long id);
        void Update(T entidade);
    }
}
