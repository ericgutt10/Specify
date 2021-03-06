using System.Collections.Generic;
using ContosoUniversity.Domain.Model;
using PagedList;

namespace ContosoUniversity.Infrastructure.DAL.Repositories
{
    public interface IStudentRepository
    {
        IPagedList<Student> Get(string sortOrder, string searchString, int pageNumber, int pageSize);
        List<Student> Get();
        Student FindById(int id);
        void Create(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}