using System.Collections.Generic;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Repository;

namespace COVIDVACCSYSTEM.ViewModels.Services
{
    public class StateServices : IRepository<State>
    {
        private COVIDVACCDBContext.COVIDVACCDBContext _context;

        public StateServices()
        {
            _context = new COVIDVACCDBContext.COVIDVACCDBContext();
        }
        public List<State> GetAll()
        { 
            return _context.States.ToList();
        }

        public void Create(State item)
        {
        }

        public void Update(State item)
        {
            
        }

        public void Delete(State item)
        {
            
        }
    }
}