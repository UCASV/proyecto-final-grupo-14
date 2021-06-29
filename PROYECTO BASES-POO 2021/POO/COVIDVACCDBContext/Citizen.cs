using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Ailments = new HashSet<Ailment>();
            CitizenPhoneNumbers = new HashSet<CitizenPhoneNumber>();
            VaccinationAppointments = new HashSet<VaccinationAppointment>();
        }

        public string Dui { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int InstitutionId { get; set; }

        public virtual City City { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<Ailment> Ailments { get; set; }
        public virtual ICollection<CitizenPhoneNumber> CitizenPhoneNumbers { get; set; }
        public virtual ICollection<VaccinationAppointment> VaccinationAppointments { get; set; }
    }
}
