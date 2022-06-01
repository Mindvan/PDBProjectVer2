using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Entities;

namespace University.Logic.Services
{
   
    namespace University.Services
    {
        public interface IStudentServices
        {
            Task<Student> AddStudentAsync(Student student);

            Task<IEnumerable<Student>> GetStudentsAsync();

            Task<Student> GetStudentAsync(int id);

            Task<Student> UpdateStudentAsync(Student student);

            Task DeleteStudentAsync(int id);

        }
    }
}
