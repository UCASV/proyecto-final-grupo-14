
using System;

namespace COVIDVACCSYSTEM.ViewModels
{
    public class CitizenVm
    {
        public string Dui { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public int InstitutionId { get; set; }
    }
}