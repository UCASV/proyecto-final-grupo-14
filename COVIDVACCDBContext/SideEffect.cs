using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Id { get; set; }
        public int SymptomId { get; set; }
        public TimeSpan SymptomTime { get; set; }

        public virtual Symptom Symptom { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
