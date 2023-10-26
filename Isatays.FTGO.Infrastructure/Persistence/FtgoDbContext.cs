using Microsoft.EntityFrameworkCore;

namespace Isatays.FTGO.Infrastructure.Persistence;

public class FtgoDbContext : DbContext
{
    public FtgoDbContext(DbContextOptions<FtgoDbContext> options) : base(options) { }


}
