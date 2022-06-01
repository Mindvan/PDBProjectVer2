using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Entities;

namespace University.Logic.Services
{
    public interface ILectionServices
    {
        Task<Lection> AddLectionAsync(Lection lection);

        Task<IEnumerable<Lection>> GetLectionsAsync();

        Task<Lection> GetLectionAsync(int id);

        Task<Lection> UpdateLectionAsync(Lection lection);

        Task DeleteLectionAsync(int id);

    }
}
