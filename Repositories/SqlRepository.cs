using MotoApp.Repositories;
using Microsoft.EntityFrameworkCore;
using MotoApp.Data;
using MotoApp.Entities;

public delegate void AddBatchDelegate<T>(T[] items) where T : class, IEntity;
public delegate void itemAdded<in T>(T item);
public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly DbSet<T> _dbSet;
    private readonly DbContext _dbContext;
    private readonly itemAdded<T> _itemAddedCallback;
    private MotoAppDbContext motoAppDbContext;
    private ItemAdded itemAdded;

    public SqlRepository(DbContext dbContext, itemAdded<T> itemAddedCallback = null)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
        _itemAddedCallback = itemAddedCallback;
    }

    public SqlRepository(MotoAppDbContext motoAppDbContext, ItemAdded itemAdded)

    {
        this.motoAppDbContext = motoAppDbContext;
        this.itemAdded = itemAdded;
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T GetById(int id) => _dbSet.Find(id);
    public void Add(T item)
    {
        _dbSet.Add(item); 
        _itemAddedCallback?.Invoke(item);
    }
    public void Save() => _dbContext.SaveChanges();
    public void Remove(T item) => _dbSet.Remove(item);
    public void AddBatch(Employee[] employees) => AddBatch(employees);
    public void AddBatch(BusinessPartner[] businessPartners) => AddBatch(businessPartners);

}

