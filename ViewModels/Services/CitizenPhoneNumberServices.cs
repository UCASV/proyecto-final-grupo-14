using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class CitizenPhoneNumberServices :IRepository<CitizenPhoneNumber>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public CitizenPhoneNumberServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<CitizenPhoneNumber> GetAll()
        {
            return _context.CitizenPhoneNumbers.ToList();
        }

        public void Create(CitizenPhoneNumber item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(CitizenPhoneNumber item)
        {
        }

        public void Delete(CitizenPhoneNumber item)
        {
        }
    }
}