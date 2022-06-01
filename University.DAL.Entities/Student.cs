using System;
using System.Collections.Generic;

#nullable disable

namespace University.DAL.Entities
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            Hometasks = new HashSet<Hometask>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Recordbook { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Hometask> Hometasks { get; set; }
    }
}
