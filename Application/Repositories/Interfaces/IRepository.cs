namespace Application.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();

    Task<T> GetByIdAsync(int id);

    Task<bool> UpdateAsync(T entity);

    Task<bool> DeleteAsync(T entity);
}
