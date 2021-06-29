using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class City
    {
        public City()
        {
            Cabins = new HashSet<Cabin>();
            Citizens = new HashSet<Citizen>();
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
