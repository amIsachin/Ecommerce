using Application.Repositories.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.Classes;

public class Repository<T> : IRepository<T> where T : class
{
    #region InitializeConnection
    private readonly EcommerceDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(EcommerceDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    #endregion

    /// <summary>
    /// Get All records method.
    /// </summary>
    /// <returns></returns>
    public async Task<List<T>> GetAllAsync()
    {
        try
        {
            var allRecords = await _dbSet.ToListAsync();

            return allRecords;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Task<bool> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}