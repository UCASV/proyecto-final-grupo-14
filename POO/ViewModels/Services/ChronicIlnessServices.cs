using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class ChronicIlnessServices : IRepository<ChronicIllness>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public ChronicIlnessServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<ChronicIllness> GetAll()
        {
            return _context.ChronicIllnesses.ToList();
        }

        public void Create(ChronicIllness item)
        {
        }

        public void Update(ChronicIllness item)
        {
        }

        public void Delete(ChronicIllness item)
        {
        }
    }
}