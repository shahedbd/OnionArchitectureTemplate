using Core.Entities.Models;
using Core.Repository.Repository;

namespace Core.Service.Service
{
    public class BranchService : IBranchService
    {
        private IRepository<Branch> _IRepository;

        public BranchService(IRepository<Branch> iRepository)
        {
            _IRepository = iRepository;
        }

        public IEnumerable<Branch> GetAll()
        {
            return _IRepository.GetAll();
        }

        public Branch Get(long id)
        {
            return _IRepository.Get(id);
        }

        public void Insert(Branch user)
        {
            _IRepository.Insert(user);
        }
        public void Update(Branch user)
        {
            _IRepository.Update(user);
        }

        public void Delete(long id)
        {
            Branch _Branch = _IRepository.Get(id);
            _IRepository.Remove(_Branch);
            _IRepository.SaveChanges();
        }
    }
}
