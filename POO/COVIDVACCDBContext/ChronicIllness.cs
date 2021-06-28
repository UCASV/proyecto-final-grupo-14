using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class ChronicIllness
    {
        public ChronicIllness()
        {
            Ailments = new HashSet<Ailment>();
        }

        public int Id { get; set; }
        public string Illness { get; set; }

        public virtual ICollection<Ailment> Ailments { get; set; }
    }
}
