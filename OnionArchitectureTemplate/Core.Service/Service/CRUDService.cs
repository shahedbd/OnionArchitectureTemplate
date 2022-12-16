using Core.Entities.Models;
using Core.Repository.Repository;

namespace Core.Service.Service
{
    public class CRUDService<T> : ICRUDService<T> where T : class
	{
        private IRepository<T> _IRepository;

        public CRUDService(IRepository<T> iRepository)
        {
            _IRepository = iRepository;
        }

		public IEnumerable<T> GetAll()
		{
			return _IRepository.GetAll();
		}

		public async Task<T> Get(long id)
        {
            return await _IRepository.Get(id);
        }

        public async Task Insert(T entity)
        {
            await _IRepository.Insert(entity);
        }
        public async Task Update(T entity)
        {
            await _IRepository.Update(entity);
        }

        public async Task Delete(long id)
        {
			T entity = await _IRepository.Get(id);
            _IRepository.Remove(entity);
            await _IRepository.SaveChanges();
        }
    }
}
