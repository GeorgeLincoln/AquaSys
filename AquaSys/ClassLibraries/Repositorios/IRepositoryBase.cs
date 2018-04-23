using System.Collections.Generic;
using ExemploLibrary.Entidades;

namespace ExemploLibrary.Repositorys
{
    public interface IRepositoryBase<T> where T : class, IEntidade
    {
        void Add(T entidade);
        IEnumerable<T> GetAll();
        T Find(long id);
        void Remove(long id);
        void Update(T entidade);
    }
}
