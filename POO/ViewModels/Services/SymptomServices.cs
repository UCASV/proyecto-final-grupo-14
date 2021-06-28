using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class SymptomServices : IRepository<Symptom>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public SymptomServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<Symptom> GetAll()
        {
            return _context.Symptoms.ToList();
        }

        public void Create(Symptom item)
        {
        }

        public void Update(Symptom item)
        {
        }

        public void Delete(Symptom item)
        {
        }
    }
}