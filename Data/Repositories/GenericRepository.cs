using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        public DBFacturacionContext Context { get; set; }

        public GenericRepository(DBFacturacionContext context)
        {
            Context = context;
        }

        public async Task<int> CreateAsync(T obj)
        {
            Context.Set<T>().Add(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Update(T obj)
        {
            Context.Set<T>().Update(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Delete(T obj) { 

            Context.Set<T>().Update(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> GetSingle(T obj) { 

            Context.Set<T>().Remove(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll() => await Context.Set<T>().ToListAsync();
    }
}
