using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.IRepository;
using University.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using University.Logic.Services;

namespace University.DAL.Repository
{
    public class LectorServices : ILectorServices
    {
        private readonly ILectorRepository _lectorRepository;

        public LectorServices(ILectorRepository lectorRepository)
        {
            _lectorRepository = lectorRepository;
        }

        public async Task<Lector> AddLectorAsync(Lector lector)
        {
            return await _lectorRepository.AddLectorAsync(lector);
        }

        public async Task<IEnumerable<Lector>> GetLectorsAsync()
        {
            return await _lectorRepository.GetLectorsAsync();
        }

        public async Task<Lector> GetLectorAsync(int id)
        {
            return await _lectorRepository.GetLectorAsync(id);
        }

        public async Task<Lector> UpdateLectorAsync(Lector lector)
        {
            return await _lectorRepository.UpdateLectorAsync(lector);
        }

        public async Task DeleteLectorAsync(int id)
        {
            await _lectorRepository.DeleteLectorAsync(id);
        }
    }
}
