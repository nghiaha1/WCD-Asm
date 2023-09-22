using Application.Models;

namespace Application.Service;

public interface IClassService
{
    IEnumerable<Class> GetAll();
    Class GetById(string id);
    void Insert(Class entity);
    void Update(Class entity);
    void Delete(string id);
}