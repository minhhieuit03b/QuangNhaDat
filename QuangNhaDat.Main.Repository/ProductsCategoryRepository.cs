using Dapper;
using QuangNhaDat.Core.DAL;
using QuangNhaDat.Main.Domain;
using QuangNhaDat.Main.Domain.Interface;
using QuangNhaDat.Main.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuangNhaDat.Main.Repository
{
    public class ProductsCategoryRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> getAll()
        {
            return DALHelpers.Gets<TEntity>(Enums.GetsProductsCategory, null);
        }

        public TEntity GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
