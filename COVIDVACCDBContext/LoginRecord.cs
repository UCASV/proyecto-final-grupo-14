using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class LoginRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CabinId { get; set; }
        public DateTime LoginTime { get; set; }

        public virtual Cabin Cabin { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
