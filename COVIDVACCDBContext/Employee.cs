using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Employee
    {
        public Employee()
        {
            Employeexprocesses = new HashSet<Employeexprocess>();
            LoginInfos = new HashSet<LoginInfo>();
            LoginRecords = new HashSet<LoginRecord>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InstitutionalMail { get; set; }
        public int EmployeeTypeId { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual ICollection<Employeexprocess> Employeexprocesses { get; set; }
        public virtual ICollection<LoginInfo> LoginInfos { get; set; }
        public virtual ICollection<LoginRecord> LoginRecords { get; set; }
    }
}
