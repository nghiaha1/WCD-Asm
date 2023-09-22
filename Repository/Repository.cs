using Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DatabaseContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DatabaseContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(string id)
    {
        return _dbSet.Find(id) ?? throw new InvalidOperationException();
    }

    public void Insert(T entity)
    {
        _dbSet.Add(entity);
    }

    public void InsertAll(IEnumerable<T> entities)
    {
        _dbSet.AddRange(entities);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void DeleteById(string id)
    { 
        _dbSet.Remove(_dbSet.Find(id)!);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}