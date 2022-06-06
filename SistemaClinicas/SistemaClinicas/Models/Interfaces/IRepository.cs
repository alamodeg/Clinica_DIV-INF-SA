using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetEntity(int id);
        List<T> GetEntities();
        void AddEntity(T entity);
        void DeleteEntity(int id);
        void EditEntity(T entity);
    }
}
