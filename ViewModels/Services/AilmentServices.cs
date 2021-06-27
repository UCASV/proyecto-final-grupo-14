using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    
    public class AilmentServices : IRepository<Ailment>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public AilmentServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        
        public List<Ailment> GetAll()
        {
            return _context.Ailments.ToList();
        }

        public void Create(Ailment item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(Ailment item)
        {
        }

        public void Delete(Ailment item)
        {
        }
    }
}