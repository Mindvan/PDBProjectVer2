using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using University.DAL.Entities;

namespace University.DAL.IRepository
{
   public interface ILectionLectorsRepository
    {
        Task<LectionLector> GetLectionLectorsAsync(int id);

        Task<LectionLector> AddLectionLectorsAsync(LectionLector lectionlector);

        Task<IEnumerable<LectionLector>> GetLectionLectorsAsync();

        Task DeleteLectionLectorsAsync(int id);

        Task<LectionLector> UpdateLectionLectorsAsync(LectionLector lectionlector);
    }
}
