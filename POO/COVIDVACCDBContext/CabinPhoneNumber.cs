using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class CabinPhoneNumber
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public int CabinId { get; set; }

        public virtual Cabin Cabin { get; set; }
    }
}
