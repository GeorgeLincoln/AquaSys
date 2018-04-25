using ClassLibraries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraries.Services
{
    public interface IServiceBase<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T Find(int id);
        void Add(T etity);
        void Update(T entity, int id);
        void Remove(int id);
    }
}