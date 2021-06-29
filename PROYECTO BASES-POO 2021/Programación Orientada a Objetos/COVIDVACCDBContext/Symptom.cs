using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class Symptom
    {
        public Symptom()
        {
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string Symptom1 { get; set; }

        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
