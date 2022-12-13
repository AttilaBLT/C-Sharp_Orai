namespace LoL.UI.ViewModels;
public class ChampionViewModel
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [Range(0, 1000)]
    public int? Hp { get; set; }

    [Required]
    [Range(0, 1000)]
    public int? Mana { get; set; }

    [Required]
    public DateTime DateOfRelease { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Please select a role!")]
    public int RoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }

    public ChampionViewModel()
    {
    }

    public ChampionViewModel(int id, string name, int hp, int mana, DateTime dateOfRelease, int roleId, string roleName)
    {
        Id = id;
        Name = name;
        Hp = hp;
        Mana = mana;
        DateOfRelease = dateOfRelease.Date;
        RoleId = roleId;
        RoleName = roleName;
    }

    public ChampionViewModel(Champion champion)
    {
        Id = champion.Id;
        Name = champion.Name;
        Hp = champion.Hp;
        Mana = champion.Mana;
        DateOfRelease = champion.DateOfRelease.Date;
        RoleName = champion.Role.Name;
        RoleId = champion.Role.Id;
    }

    public Champion ToDbEntity()
    {
        return new Champion
        {
            Id = Id,
            Name = Name,
            Hp = Hp.Value,
            Mana = Mana.Value,
            DateOfRelease = DateOfRelease.Date,
            RoleId = RoleId,
        };
    }

    public void ToDbEntity(Champion champion)
    {
        champion.Name = Name;
        champion.Hp = Hp.Value;
        champion.Mana = Mana.Value;
        champion.DateOfRelease = DateOfRelease.Date;
        champion.RoleId = RoleId;
    }
}
