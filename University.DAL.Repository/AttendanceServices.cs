using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.IRepository;
using University.DAL.Entities;
using University.Logic.Services;
using University.Logic.Services.University.Services;
using Microsoft.EntityFrameworkCore;


namespace University.DAL.Repository
{
   public class AttendanceServices : IAttendanceServices
    {
        private readonly IAttendanceRepository _studentRepository;

        public AttendanceServices(IAttendanceRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Attendance> AddAttendanceAsync(Attendance student)
        {
            return await _studentRepository.AddAttendanceAsync(student);
        }

        public async Task<IEnumerable<Attendance>> GetAttendanceAsync()
        {
            return await _studentRepository.GetAttendanceAsync();
        }

        public async Task<Attendance> GetAttendanceAsync(int id)
        {
            return await _studentRepository.GetAttendanceAsync(id);
        }

        public async Task<Attendance> UpdateAttendanceAsync(Attendance student)
        {
            return await _studentRepository.UpdateAttendanceAsync(student);
        }

        public async Task DeleteAttendanceAsync(int id)
        {
            await _studentRepository.DeleteAttendanceAsync(id);
        }
    }
}
