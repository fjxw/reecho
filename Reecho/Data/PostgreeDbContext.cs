
public class PostgreeDbContext(DbContextOptions<PostgreeDbContext> options) : DbContext(options)
{
    public DbSet<Vynil> Vynils { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreeDbContext).Assembly);
    }
}