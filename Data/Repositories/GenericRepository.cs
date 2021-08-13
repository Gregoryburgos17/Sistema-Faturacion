using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#nullable enable

namespace Sistema_facturacion.Data.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        public DBFacturacionContext Context { get; }

        public GenericRepository(DBFacturacionContext context) => Context = context;

        /// <summary>
        /// Method used to get the repository table with the option of overriding it to include related tables if needed.
        /// If it's not overriden, it defaults to the table without related tables included.
        /// </summary>
        /// <remarks>
        /// This method should only be used to QUERY data.
        /// </remarks>
        public virtual IQueryable<T> Table() => Context.Set<T>().AsQueryable();

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

        public async Task<int> DeleteAsync(T obj)
        {

            Context.Set<T>().Remove(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<T?> FindAsync(Expression<Func<T, bool>> predicate) => await Table().SingleOrDefaultAsync(predicate);

        public async Task<List<T>> GetAllAsync() => await Table().ToListAsync();
    }
}
