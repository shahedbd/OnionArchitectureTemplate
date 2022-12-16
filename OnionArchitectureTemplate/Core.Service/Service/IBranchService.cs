using Core.Entities.Models;

namespace Core.Service.Service
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetAll();
        Branch Get(long id);
        void Insert(Branch entity);
        void Update(Branch entity);
        void Delete(long id);
    }
}
