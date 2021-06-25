

using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class CitizenServices : IRepository<Citizen>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public CitizenServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        
        public List<Citizen> GetAll()
        {
            return _context.Citizens.ToList();
        }

        public void Create(Citizen item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(Citizen item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Citizen item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}
