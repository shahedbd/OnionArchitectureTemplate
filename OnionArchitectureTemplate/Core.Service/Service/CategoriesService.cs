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

        public Categories Get(long id)
        {
            return _IRepository.Get(id);
        }

        public void Insert(Categories user)
        {
            _IRepository.Insert(user);
        }
        public void Update(Categories user)
        {
            _IRepository.Update(user);
        }

        public void Delete(long id)
        {
            Categories _Categories = _IRepository.Get(id);
            _IRepository.Remove(_Categories);
            _IRepository.SaveChanges();
        }
    }
}
