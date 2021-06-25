using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class VaccinationAppointment
    {
        public int Id { get; set; }
        public DateTime AppDate { get; set; }
        public TimeSpan AppTime { get; set; }
        public int CabinId { get; set; }
        public string CitizenId { get; set; }

        public virtual Cabin Cabin { get; set; }
        public virtual Citizen Citizen { get; set; }
    }
}
