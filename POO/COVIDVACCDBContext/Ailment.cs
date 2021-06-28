using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Ailment
    {
        public int Id { get; set; }
        public int IllnessId { get; set; }
        public string CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
        public virtual ChronicIllness Illness { get; set; }
    }
}
