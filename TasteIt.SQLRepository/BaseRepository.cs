using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TasteIt.SQLDB.Model;

namespace TasteIt.SQLRepository
{
    public class BaseRepository<T> where T : class
    {
        public DbContext context = new TasteItModel();
        public DbSet<T> DbSet;

        public BaseRepository()
        {
            DbSet = context.Set<T>();
        }

        public bool Insert(T entity)
        {
            try
            {
                DbSet.Add(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public bool Delete(T entity)
        {
            try
            {
                DbSet.Remove(entity);
                context.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
            
        }

        public bool Update(T entity)
        {
            try 
            { 
                DbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
    }
}
