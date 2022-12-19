namespace Vehicle.Ui.ViewModels;

public class CarViewModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Manufacturer { get; set; }

    [Required]
    [MaxLength(30)]
    public string Model { get; set; }

    [Required]
    [Range(1908, 2023)]
    public int? ProductionYear { get; set; }

    [Required]
    [Range(0, 13000)]
    public int? CubicCapacity { get; set; }

    [Required]
    [Range(1, 4, ErrorMessage = "Fuel type is required")]
    public int FuelId { get; set; }

    [Required]
    [MaxLength(30)]
    public string FuelName { get; set; } 

    [Required]
    [Range(1, 6, ErrorMessage = "Vehicle type is required")]
    public int VehicleTypeId { get; set; }

    [Required]
    [MaxLength(30)]
    public string VehicleTypeName { get; set; }

    public CarViewModel()
    {
    }

    public CarViewModel(int id, string manufacturer, string model, int productionYear, int cubicCapacity, int fuelId, string fuelName, int vehicleTypeId, string vehicleTypeName)
    {
        Id = id;
        Manufacturer = manufacturer;
        Model = model;
        ProductionYear = productionYear;
        CubicCapacity = cubicCapacity;
        FuelId = fuelId;
        FuelName = fuelName;
        VehicleTypeId = vehicleTypeId;
        VehicleTypeName = vehicleTypeName;
    }

    public CarViewModel(Car car)
    {
        Id = car.Id;
        Manufacturer = car.Manufacturer;
        Model = car.Model;
        ProductionYear = car.ProductionYear;
        CubicCapacity = car.CubicCapacity;
        FuelId = car.Fuel.Id;
        FuelName = car.Fuel.Name;
        VehicleTypeId = car.VehicleType.Id;
        VehicleTypeName = car.VehicleType.Name;
    }

    public Car ToDbEntity()
    {
        return new Car
        {
            Id = Id,
            Manufacturer = Manufacturer,
            Model = Model,
            ProductionYear = ProductionYear.Value,
            CubicCapacity = CubicCapacity.Value,
            FuelId = FuelId,
            VehicleTypeId = VehicleTypeId,
        };
    }

    public void ToDbEntity(Car car)
    {
        car.Manufacturer = Manufacturer;
        car.Model = Model;
        car.ProductionYear = ProductionYear.Value;
        car.CubicCapacity = CubicCapacity.Value;
        car.FuelId = FuelId;
        car.VehicleTypeId = VehicleTypeId;
    }
}
