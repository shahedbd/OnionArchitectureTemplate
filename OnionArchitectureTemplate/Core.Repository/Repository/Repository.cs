using System.Collections.Generic;
using System.Linq;
using Core.Entities.Models;
using Core.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
		public IEnumerable<T> GetAll()
		{
			return entities.AsEnumerable();
		}

		public async Task<T> Get(long id)
        {
            return await entities.SingleOrDefaultAsync(x => x.Id == id);
        }
        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
