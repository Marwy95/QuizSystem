﻿using ExaminationSystem.Models;
using System.Linq;
using System.Linq.Expressions;

namespace ExaminationSystem.Repositories
{
    public interface IRepository<T> 
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T,bool>>predicate);
        T GetByID(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void SaveChanges();
        T First(Expression<Func<T, bool>> predicate);
    }
}
