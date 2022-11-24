namespace LoL.Data;

public class AppDbContext:DbContext
{
    public DbSet<Champion> Champions { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=LoLDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Role> roles = new List<Role>()
        {
            new Role{Id=1, Name="Top"},
            new Role{Id=2, Name="Mid"},
            new Role{Id=3, Name="Support"},
            new Role{Id=4, Name="Adc"},
            new Role{Id=5, Name="Jungle"},
        };

        modelBuilder.Entity<Role>().HasData(roles);
    }
}
//adatbázisnál migrálás kell
//add-migration "initial"
//update-database
//6 entity framework kell első 4 aztán sqlserver és tool,
