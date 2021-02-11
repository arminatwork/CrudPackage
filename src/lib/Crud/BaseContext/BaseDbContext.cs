using Microsoft.EntityFrameworkCore;

namespace Crud.BaseContext
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}