using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public DateTime ProcessDate { get; set; }
        public TimeSpan ProcessTime { get; set; }
        public TimeSpan VaccTime { get; set; }
        public int VaccAppId { get; set; }

        public virtual VaccinationAppointment VaccApp { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
