
using COVIDVACCSYSTEM.COVIDVACCDBContext;

namespace COVIDVACCSYSTEM.ViewModels
{
    public static class COVIDVACCMapper
    {
        static AilmentVM MapAilmenttoAilmentVm(Ailment e)
        {
            return new AilmentVM
            {
                Id = e.Id,
                IllnessId = e.IllnessId,
                CitizenId = e.CitizenId
            };
        }

        static CabinVm MapCabinToCabinVm(Cabin e)
        {
            return new CabinVm
            {
                Id = e.Id,
                Email = e.Email,
                CityId = e.CityId
            };
        }

        static CitizenVm MapCitizenToCitizenVm(Citizen e)
        {
            return new CitizenVm
            {
                Dui = e.Dui,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Birthday = e.Birthday,
                Email = e.Email,
                CityId = e.CityId,
                InstitutionId = e.InstitutionId
            };
        }

        static EmployeeVm MapEmployeeToEmployeeVm(Employee e)
        {
            return new EmployeeVm
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                InstitutionalMail = e.InstitutionalMail,
                EmployeeTypeId = e.EmployeeTypeId,
                CityId = e.CityId
            };
        }

        static VaccinationAppointmentVm MapVaccApptToVaccApptVm(VaccinationAppointment e)
        {
            return new VaccinationAppointmentVm
            {
                Id = e.Id,
                AppDate = e.AppDate,
                AppTime = e.AppTime,
                CabinId = e.CabinId,
                CitizenId = e.CitizenId
            };
        }

        static VaccinationProcessVm MapVaccProcToVaccProcVm(VaccinationProcess e)
        {
            return new VaccinationProcessVm
            {
                Id = e.Id,
                ProcessDate = e.ProcessDate,
                ProcessTime = e.ProcessTime,
                VaccTime = e.VaccTime,
                VaccAppId = e.VaccAppId,
                SideEffectsId = e.SideEffectsId
            };
        }
        
        
    }
}