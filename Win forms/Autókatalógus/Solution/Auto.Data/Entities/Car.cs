namespace Vehicle.Data.Entities;

[Table("Vehicle")]
public class Car
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Manufacturer { get; set; }

    [Required]
    [MaxLength(30)]
    public string Model { get; set; }

    [Required]
    public DateTime DateOfRelease { get; set; }

    [Required]
    [ForeignKey("Fuel")]
    public int FuelId { get; set; }

    public virtual Fuel Fuel { get; set; }

    [Required]
    [ForeignKey("VehicleType")]
    public int VehicleTypeId { get; set; }

    public virtual VehicleType VehicleType { get; set; }
}
