namespace Application.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll();

    Task<T> GetById(int id);

    Task<bool> Update(T entity);

    Task<bool> Delete(T entity);
}
