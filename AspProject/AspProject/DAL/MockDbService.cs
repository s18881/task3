using System.Collections.Generic;
using AspProject.Models;

namespace AspProject.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent = 1, FirstName = "Monkey\'D", LastName = "Luffy", IndexNumber = "s327"},
                new Student{IdStudent = 2, FirstName = "Roronoa", LastName = "Zoro", IndexNumber = "s328"},
                new Student{IdStudent = 3, FirstName = "Vindsmoke", LastName = "Sanji", IndexNumber = "s329"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}