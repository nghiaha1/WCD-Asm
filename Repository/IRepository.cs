using Application.Models;

namespace Application.Repository;

public interface IRepository<T> where T : class
{   
    List<T> GetAll();
    T GetById(string id);
    void Insert(T entity);
    void InsertAll(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(T entity);
    void DeleteById(string id);
    void Save();
}