using Core.Entities.Models;

namespace Core.Service.Service
{
    public interface ICategoriesService
    {
		IEnumerable<Categories> GetAll();
		Task<Categories> Get(long id);
		Task Insert(Categories entity);
		Task Update(Categories entity);
		Task Delete(long id);
	}
}
