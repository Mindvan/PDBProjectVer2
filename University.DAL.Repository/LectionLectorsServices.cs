﻿using System;
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
    public class LectionLectorsServices : ILectionLectorsServices
    {
        public LectionLectorsServices() { }

        // возвращение лекцию по id
        public async Task<LectionLector> GetLectionAsync(int id)
        {
            LectionLector result = null;

            using (var UniversityContext = new UniversityContext())
            {
                result = await UniversityContext.LectionLectors.FirstOrDefaultAsync(f => f.Id == id);
            }
            return result;
        }

        // Добавление лекции
        public async Task<LectionLector> AddLectionAsync(LectionLector lection)
        {
            //Student result = null;

            using (var UniversityContext = new UniversityContext())
            {
                UniversityContext.LectionLectors.Add(lection);
                //result = UniversityContext.Students.Add(student);
                await UniversityContext.SaveChangesAsync();
            }
            //return result;
            return lection;
        }

        // возвращение списка лекций
        public async Task<IEnumerable<LectionLector>> GetLectionsAsync()
        {
            var result = new List<LectionLector>();

            using (var UniversityContext = new UniversityContext())
            {
                result = await UniversityContext.LectionLectors.ToListAsync();
            }
            return result;
        }

        // удаление лекции по id
        public async Task DeleteLectionAsync(int id)
        {
            using (var UniversityContext = new UniversityContext())
            {
                var lection = await UniversityContext.LectionLectors.FirstOrDefaultAsync(f => f.Id == id);
                UniversityContext.Entry(lection).State = EntityState.Deleted;
                await UniversityContext.SaveChangesAsync();
            }
        }

        // обновление данных о лекции
        public async Task<LectionLector> UpdateLectionAsync(LectionLector lection)
        {
            using (var UniversityContext = new UniversityContext())
            {
                UniversityContext.Entry(lection).State = EntityState.Modified;
                await UniversityContext.SaveChangesAsync();
            }
            return lection;
        }
    }
}
