using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepositoryBase<T> where T : class, IEntity, new()

    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //ID ye göre getir
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
