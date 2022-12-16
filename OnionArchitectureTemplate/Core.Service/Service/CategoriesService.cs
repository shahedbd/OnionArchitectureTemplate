using Core.Entities.Models;
using Core.Repository.Repository;

namespace Core.Service.Service
{
    public class CategoriesService : ICategoriesService
	{
        private IRepository<Categories> _IRepository;

        public CategoriesService(IRepository<Categories> iRepository)
        {
            _IRepository = iRepository;
        }

		public IEnumerable<Categories> GetAll()
		{
			return _IRepository.GetAll();
		}

		public async Task<Categories> Get(long id)
		{
			return await _IRepository.Get(id);
		}

		public async Task Insert(Categories entity)
		{
			await _IRepository.Insert(entity);
		}
		public async Task Update(Categories entity)
		{
			await _IRepository.Update(entity);
		}

		public async Task Delete(long id)
		{
			Categories entity = await _IRepository.Get(id);
			_IRepository.Remove(entity);
			await _IRepository.SaveChanges();
		}
	}
}
