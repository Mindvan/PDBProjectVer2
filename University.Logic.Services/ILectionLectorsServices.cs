using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Entities;


namespace University.Logic.Services
{
   public interface ILectionLectorsServices
    {
        Task<LectionLector> AddLectionAsync(LectionLector lection);

        Task<IEnumerable<LectionLector>> GetLectionsAsync();

        Task<LectionLector> GetLectionAsync(int id);

        Task<LectionLector> UpdateLectionAsync(LectionLector lection);

        Task DeleteLectionAsync(int id);
    }
}
