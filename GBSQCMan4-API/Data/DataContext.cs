using GBSQCMan4_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GBSQCMan4_API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
