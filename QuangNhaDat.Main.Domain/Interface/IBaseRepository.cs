using System;
using System.Collections.Generic;
using System.Text;

namespace QuangNhaDat.Main.Domain.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public TEntity GetByID(int ID);
        public IEnumerable<TEntity> getAll();
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(int ID);
    }
}
