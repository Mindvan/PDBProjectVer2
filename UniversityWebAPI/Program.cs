using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.DAL.Entities;
using University.DAL.Repository;

namespace UniversityWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Добавление
            using (UniversityContext db = new UniversityContext())
            {
                if (!db.Students.Any() && !db.Lections.Any() && !db.Lectors.Any())
                {
                    var stud1 = new Student
                    {
                        Id = 1,
                        Name = "Иванов Иван Иванович",
                        Recordbook = "111",
                        Group = "001",
                        Email = "Ivanov@mail.ru",
                        Phone = "89134567819"
                    };
                    var stud2 = new Student
                    {
                        Id = 2,
                        Name = "Петров Петр Петрович",
                        Recordbook = "112",
                        Group = "001",
                        Email = "Petrov@mail.ru",
                        Phone = "8374829743"
                    };
                    var lec1 = new Lection
                    {
                        Id = 1,
                        NameSubj = "ТеорВер"
                    };



                    var lect1 = new Lector
                    {
                        Id = 2,
                        Name = "Хахина Анна Михайловна",
                        Degree = "Преподаватель",
                        Email = "hahina@mail.ru",
                        Phone = "8912345678"
                    }; db.Lectors.Add(lect1);


                    db.Students.Add(stud1);
                    db.Students.Add(stud2);
                    db.Lections.Add(lec1);
                }
                db.SaveChanges();
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

