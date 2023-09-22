using Application.Models;

namespace Application.Service;

public interface ICourseService
{
    IEnumerable<Course> GetAll();
    Course GetById(string id);
    void Insert(Course entity);
    void Update(Course entity);
    void Delete(string id);
}