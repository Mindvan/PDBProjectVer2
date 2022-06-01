using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DAL.Entities;

namespace University.DAL.IRepository
{
    public interface IStudentRepository 
    {
       
            Task<Student> GetStudentAsync(int id);

            Task<Student> AddStudentAsync(Student student);

            Task<IEnumerable<Student>> GetStudentsAsync();

            Task DeleteStudentAsync(int id);

            Task<Student> UpdateStudentAsync(Student student);

        

    }
}
