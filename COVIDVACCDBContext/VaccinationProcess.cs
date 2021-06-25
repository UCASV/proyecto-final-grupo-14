using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            Employeexprocesses = new HashSet<Employeexprocess>();
        }

        public int Id { get; set; }
        public DateTime ProcessDate { get; set; }
        public TimeSpan ProcessTime { get; set; }
        public TimeSpan VaccTime { get; set; }
        public int VaccAppId { get; set; }
        public int SideEffectsId { get; set; }

        public virtual SideEffect SideEffects { get; set; }
        public virtual ICollection<Employeexprocess> Employeexprocesses { get; set; }
    }
}
