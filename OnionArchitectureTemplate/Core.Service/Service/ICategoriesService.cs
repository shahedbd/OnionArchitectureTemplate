using Core.Entities.Models;

namespace Core.Service.Service
{
    public interface ICategoriesService
    {
        IEnumerable<Categories> GetAll();
        Categories Get(long id);
        void Insert(Categories entity);
        void Update(Categories entity);
        void Delete(long id);
    }
}
