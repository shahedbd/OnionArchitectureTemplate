using System.Collections.Generic;
using Core.Entities.Models;

namespace Core.Repository.Repository
{
    public interface IRepository<T> where T : class
    {
		IEnumerable<T> GetAll();
		Task<T> Get(long id);
		Task Insert(T entity);
		Task Update(T entity);
		Task Delete(T entity);
		void Remove(T entity);
		Task SaveChanges();
    }
}
