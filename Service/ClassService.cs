using Application.Models;
using Application.Repository;

namespace Application.Service;

public class ClassService : IClassService
{
    private readonly IRepository<Class> _classRepository;

    public ClassService()
    {
    }

    public ClassService(IRepository<Class> classRepository)
    {
        _classRepository = classRepository;
    }

    public IEnumerable<Class> GetAll()
    {
        return _classRepository.GetAll();
    }

    public Class GetById(string id)
    {
        return _classRepository.GetById(id);
    }

    public void Insert(Class entity)
    {
        _classRepository.Insert(entity);
    }

    public void Update(Class entity)
    {
        _classRepository.Update(entity);
    }

    public void Delete(string id)
    {
        _classRepository.DeleteById(id);
    }
}