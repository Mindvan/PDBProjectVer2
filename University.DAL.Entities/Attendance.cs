using System;
using System.Collections.Generic;

#nullable disable

namespace University.DAL.Entities
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? LectionLectorID { get; set; }
        public int? Status { get; set; }
        public int Mark { get; set; }

        public virtual LectionLector LectionLector { get; set; }
        public virtual Student Student { get; set; }
    }
}
