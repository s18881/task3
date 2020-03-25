using System.Collections.Generic;
using AspProject.Models;

namespace AspProject.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}