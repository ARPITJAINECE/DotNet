using Microsoft.EntityFrameworkCore;
using endModuleApi.Data.Entities;

namespace endModuleApi.Data;
public class MyWorldDbContext:DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : base(context)
    { }
        public DbSet<Student> Students { get; set; }
}
