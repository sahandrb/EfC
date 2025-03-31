using EFCore.DataAccess.Data;
using EFCore.DataAccess.Repositpory.IRepositpry;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataAccess.Repositpory
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public AppDbContext _db { get; set; }
        public DbSet<T> Dbset { get; set; }
        public Repository(AppDbContext _db) {
        this._db = _db;
            Dbset = _db.Set<T>();

        }
        public void Add(T entity)
        {
            //
            Dbset.Add(entity);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            //
            IQueryable<T> query = Dbset;
            //Add if  for tracked
            if (tracked)
            {
                query = query.AsNoTracking();
            }
            //Add if for includeProperties
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault(filter);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<T> query = Dbset;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
            //
            Dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            //
            Dbset.RemoveRange(entity);
        }

        public void Update(T entity)
        {
            //
            Dbset.Update(entity);
        }
    }
}
