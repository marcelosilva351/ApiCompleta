using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public abstract class Repository<T> : IRepository<T>  where T : class
    {
        protected readonly ContextApiPires contextApiPires;
        public Repository(ContextApiPires contextApiPires)
        {
            this.contextApiPires = contextApiPires;
        }

        public async virtual Task Create(T entityCreate)
        {
            contextApiPires.Set<T>().Add(entityCreate);
            await SaveChanges();
        }

        public async virtual Task Delete(T entityDelete)
        {
            contextApiPires.Set<T>().Remove(entityDelete);
            await SaveChanges();
        }

        public async virtual Task<List<T>> Get()
        {
           return await contextApiPires.Set<T>().ToListAsync();
        }

        public async  virtual Task<T> GetById(int id)
        {
            return await contextApiPires.Set<T>().FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await contextApiPires.SaveChangesAsync();
        }

        public async virtual Task Update(T entityUpdate)
        {
            contextApiPires.Set<T>().Update(entityUpdate);
            await SaveChanges();
        }
            
        public void Dispose()
        {
            contextApiPires?.Dispose();
        }


    }
}
