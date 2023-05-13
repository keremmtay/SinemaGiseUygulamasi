using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();

        DbSet<T> _dbSet;

        public GenericRepository() 
        {
            _dbSet = context.Set<T>();
        }

        public void Delete(int id)
        {
            try
            {
                var result = _dbSet.Find(id);
                _dbSet.Remove(result);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Silme hatası...: " + ex.Message);
            }

        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            T result = _dbSet.Where(filter).FirstOrDefault();
            return result;
        }

        public T GetById(int id)
        {
            T result = _dbSet.Find(id);
            return result;
        }

        public void Insert(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kaydetme hatası...: " + ex.Message);
            }
        }

        public List<T> List()
        {
            return _dbSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public void Update(T entity, int id)
        {
            T guncellenecekKayıt = _dbSet.Find(id);

            var tumPropertyler = typeof(T).GetProperties();

            foreach (var property in tumPropertyler) 
            {
                if (property.Name != "Id")
                {
                    property.SetValue(guncellenecekKayıt, property.GetValue(entity));
                }
            }

            context.SaveChanges();
        }
    }
}
