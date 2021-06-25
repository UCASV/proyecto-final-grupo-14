
using System;

namespace COVIDVACCSYSTEM.ViewModels
{
    public class VaccinationProcessVm
    {
        public int Id { get; set; }
        public DateTime ProcessDate { get; set; }
        public TimeSpan ProcessTime { get; set; }
        public TimeSpan VaccTime { get; set; }
        public int VaccAppId { get; set; }
        public int SideEffectsId { get; set; }
    }
}