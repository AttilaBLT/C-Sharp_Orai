namespace Vehicle.Data.Entities;

public class Fuel
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
}