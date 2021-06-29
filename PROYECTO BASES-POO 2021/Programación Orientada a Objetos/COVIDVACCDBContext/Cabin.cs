using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            CabinPhoneNumbers = new HashSet<CabinPhoneNumber>();
            LoginRecords = new HashSet<LoginRecord>();
            VaccinationAppointments = new HashSet<VaccinationAppointment>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<CabinPhoneNumber> CabinPhoneNumbers { get; set; }
        public virtual ICollection<LoginRecord> LoginRecords { get; set; }
        public virtual ICollection<VaccinationAppointment> VaccinationAppointments { get; set; }
    }
}
