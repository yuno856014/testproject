using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Entities
{
    public partial class UserSchoolYear
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? ScholYearId { get; set; }

        public virtual SchoolYear ScholYear { get; set; }
        public virtual User User { get; set; }
    }
}
