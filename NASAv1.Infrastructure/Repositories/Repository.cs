using Microsoft.EntityFrameworkCore;
using NASAv1.Domain.Interfaces;
using NASAv1.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NASAv1.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private NASADbContext _context;
        public Repository(NASADbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add<T>(entity);
            _context.SaveChanges();
        }

        public T Find(int id)
        {
            return _context.Find<T>(id);
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
