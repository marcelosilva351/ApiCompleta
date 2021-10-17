using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);

        Task Create(T entityCreate);
        Task Update(T entityUpdate);
        Task Delete(T entityUpdate);
        Task<int> SaveChanges();

        void Dispose();
        

    }
}
