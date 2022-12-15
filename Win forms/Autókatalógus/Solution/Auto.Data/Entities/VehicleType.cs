namespace Vehicle.Data.Entities;

public class VehicleType
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
}