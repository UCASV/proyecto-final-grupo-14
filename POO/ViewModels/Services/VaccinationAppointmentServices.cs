
using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class VaccinationAppointmentServices : IRepository<VaccinationAppointment>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public VaccinationAppointmentServices()
        { 
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<VaccinationAppointment> GetAll()
        {
            return _context.VaccinationAppointments.ToList();
        }

        public void Create(VaccinationAppointment item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(VaccinationAppointment item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(VaccinationAppointment item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}