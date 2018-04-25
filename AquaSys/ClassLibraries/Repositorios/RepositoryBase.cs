using System.Collections.Generic;
using System.Linq;
using ClassLibraries.Data.Context;
using ClassLibraries.Models;

namespace ClassLibraries.Repositorios
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context, bool saveChanges = true)
        {
            this._context = context;
        }

        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual void Add(T entidade)
        {
            _context.Set<T>().Add(entidade);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Find(int id)
        {
            return _context.Set<T>().FirstOrDefault(c => c.Id == id);
        }

        public virtual void Remove(int id)
        {
            var entidade = _context.Set<T>().First(c => c.Id == id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }

        public virtual void Update(T entidade, int id)
        {
            _context.Set<T>().Update(entidade);
        }
    }
}
