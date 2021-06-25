// WORKING ON IT

using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class CityServices : IRepository<City>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public CityServices()
        { 
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public void Create(City item)
        {
            
        }

        public void Update(City item)
        {
            
        }

        public void Delete(City item)
        {
            
        }
    }
}