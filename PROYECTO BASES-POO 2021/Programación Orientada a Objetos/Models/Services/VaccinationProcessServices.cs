using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class VaccinationProcessServices : IRepository<VaccinationProcess>
    { 
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public VaccinationProcessServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<VaccinationProcess> GetAll()
        {
            return _context.VaccinationProcesses.ToList();
        }

        public void Create(VaccinationProcess item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(VaccinationProcess item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(VaccinationProcess item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}