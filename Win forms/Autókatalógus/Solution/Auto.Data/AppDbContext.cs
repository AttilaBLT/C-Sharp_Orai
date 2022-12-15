namespace Vehicle.Data;

public class AppDbContext:DbContext
{
    public DbSet<Car> Cars { get; set; }

    public DbSet<Fuel> Fuels { get; set; }

    public DbSet<VehicleType> VehicelTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB; Database=CarDB; Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        #region Fuel

        List<Fuel> fuels = new List<Fuel>()
        {
            new Fuel{Id=1, Name="Petrol"},
            new Fuel{Id=2, Name="Diesel"},
            new Fuel{Id=3, Name="Hybrid"},
            new Fuel{Id=4, Name="Electric"}
        };
        modelbuilder.Entity<Fuel>().HasData(fuels);
        #endregion

        #region VehicleType
        List<VehicleType> VehicelTypes = new List<VehicleType>()
        {
            new VehicleType{Id=1, Name="SUV"},
            new VehicleType{Id=2, Name="Cabriolet"},
            new VehicleType{Id=3, Name="Estate Car"},
            new VehicleType{Id=4, Name="Van"},
            new VehicleType{Id=5, Name="Coupe"},
            new VehicleType{Id=6, Name="Hatchback"},
        };

        modelbuilder.Entity<VehicleType>().HasData(fuels);

        #endregion
    }
}
