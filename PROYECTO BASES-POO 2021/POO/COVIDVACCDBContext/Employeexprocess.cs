using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Employeexprocess
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int VaccProcessId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual VaccinationProcess VaccProcess { get; set; }
    }
}
