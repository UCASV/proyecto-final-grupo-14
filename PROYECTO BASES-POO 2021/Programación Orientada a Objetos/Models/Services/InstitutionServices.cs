using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class InstitutionServices : IRepository<Institution>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public InstitutionServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }

        public List<Institution> GetAll()
        {
            return _context.Institutions.ToList();
        }

        public void Create(Institution item)
        {
        }

        public void Update(Institution item)
        {
        }

        public void Delete(Institution item)
        {
        }
    }
}