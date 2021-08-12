using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace Sistema_facturacion.Data.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        public DBFacturacionContext Context { get; set; }

        public GenericRepository(DBFacturacionContext context) => Context = context;

        public async Task<int> CreateAsync(T obj)
        {
            await Context.Set<T>().AddAsync(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T obj)
        {
            Context.Set<T>().Update(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(T obj) { 

            Context.Set<T>().Remove(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<T?> FindAsync(int id) => await Context.Set<T>().FindAsync(id);

        public async Task<List<T>> GetAllAsync() => await Context.Set<T>().ToListAsync();
    }
}
