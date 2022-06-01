using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Entities;
using University.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using University.Logic.Services.University.Services;
using University.DAL.IRepository;

namespace University.DAL.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository() { }

        // возвращение студента по его id
        public async Task<Student> GetStudentAsync(int id)
        {
            Student result = null;

            using (var UniversityContext = new UniversityContext())
            {
                result = await UniversityContext.Students.FirstOrDefaultAsync(f => f.Id == id);
            }
            return result;
        }


        // Добавление студентов
        public async Task<Student> AddStudentAsync(Student student)
        {
            //Student result = null;

            using (var UniversityContext = new UniversityContext())
            {
                UniversityContext.Students.Add(student);
                //result = UniversityContext.Students.Add(student);
                await UniversityContext.SaveChangesAsync();
            }
            //return result;
            return student;
        }

        // возвращение списка студентов
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            var result = new List<Student>();

            using (var UniversityContext = new UniversityContext())
            {
                result = await UniversityContext.Students.ToListAsync();
            }
            return result;
        }

        // удаление студента по id
        public async Task DeleteStudentAsync(int id)
        {
            using (var UniversityContext = new UniversityContext())
            {
                var student = await UniversityContext.Students.FirstOrDefaultAsync(f => f.Id == id);
                UniversityContext.Entry(student).State = EntityState.Deleted;
                await UniversityContext.SaveChangesAsync();
            }
        }

        // обновление данных о студенте
        public async Task<Student> UpdateStudentAsync(Student student)
        {
            using (var UniversityContext = new UniversityContext())
            {
                UniversityContext.Entry(student).State = EntityState.Modified;
                await UniversityContext.SaveChangesAsync();
            }
            return student;
        }
    }
}
