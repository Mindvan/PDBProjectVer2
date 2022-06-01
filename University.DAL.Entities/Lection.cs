using System;
using System.Collections.Generic;

#nullable disable

namespace University.DAL.Entities
{
    public partial class Lection
    {
        public Lection()
        {
            LectionLectors = new HashSet<LectionLector>();
        }

        public int Id { get; set; }
        public string NameSubj { get; set; }

        public virtual ICollection<LectionLector> LectionLectors { get; set; }
    }
}
