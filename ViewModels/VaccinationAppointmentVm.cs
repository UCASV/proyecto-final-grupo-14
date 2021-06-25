
using System;

namespace COVIDVACCSYSTEM.ViewModels
{
    public class VaccinationAppointmentVm
    {
        public int Id { get; set; }
        public DateTime AppDate { get; set; }
        public TimeSpan AppTime { get; set; }
        public int CabinId { get; set; }
        public string CitizenId { get; set; }
    }
}