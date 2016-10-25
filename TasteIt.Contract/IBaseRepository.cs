using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Contract
{
    public interface IBaseRepository<T> where T : class
    {
        bool Insert(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        IQueryable<T> Filter(Expression<Func<T, bool>> expression);
        T GetById(int id);
        IQueryable<T> GetAll();
    }
}
