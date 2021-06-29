// WORKING ON IT

using System;
using System.Collections.Generic;

namespace COVIDVACCSYSTEM.ViewModels.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T item);
        void Update(T item);
        void Delete(T item);

    }
}