﻿namespace MotoApp.Repositories;

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;


internal class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly DbSet<T> _dbSet;
    private readonly DbContext _dbContext;
    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        //return _dbSet.OrderBy(item => item.Id).ToList();
        return _dbSet.ToList();

    }
    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Add(T item)
    {
        _dbSet.Add(item);
    }

    public void Remove(T item) 
    {
        _dbSet.Remove(item);
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

}

