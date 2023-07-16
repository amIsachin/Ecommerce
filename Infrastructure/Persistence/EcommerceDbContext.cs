using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class EcommerceDbContext : DbContext
{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }

    public DbSet<ProductEntity> Products { get; set; }

    public DbSet<BookedProductEntity> Booking { get; set; }

}
