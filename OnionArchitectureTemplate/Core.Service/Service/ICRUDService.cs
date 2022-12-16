namespace Core.Service.Service
{
    public interface ICRUDService<T> where T : class
    {
		IEnumerable<T> GetAll();
		Task<T> Get(long id);
        Task Insert(T entity);
		Task Update(T entity);
		Task Delete(long id);
    }
}
