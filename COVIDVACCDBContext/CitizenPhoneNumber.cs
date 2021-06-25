using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class CitizenPhoneNumber
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenId { get; set; }

        public virtual Citizen Citizen { get; set; }
    }
}
