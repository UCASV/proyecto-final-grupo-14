using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class SideEffect
    {
        public int Id { get; set; }
        public int SymptomId { get; set; }
        public TimeSpan SymptomTime { get; set; }
        public int? VaccProcess { get; set; }

        public virtual Symptom Symptom { get; set; }
        public virtual VaccinationProcess VaccProcessNavigation { get; set; }
    }
}
