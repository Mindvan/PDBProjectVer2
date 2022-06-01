using System;
using System.Collections.Generic;

#nullable disable

namespace University.DAL.Entities
{
    public partial class Homework
    {
        public Homework()
        {
            Hometasks = new HashSet<Hometask>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int? LectionLectorID { get; set; }

        public virtual LectionLector LectionLector { get; set; }
        public virtual ICollection<Hometask> Hometasks { get; set; }
    }
}
