using Application.Repositories.Interfaces;

namespace Application.Repositories.Classes;

public class Repository<T> : IRepository<T> where T : class
{
    public Task<bool> Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }
}