namespace LoL.UI.ViewModels;
public class ChampionViewModel
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Hp { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Mana { get; set; }

    [Required]
    public DateTime DateOfRelease { get; set; }

    [Required]
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
        DateOfRelease = dateOfRelease;
        RoleId = roleId;
        RoleName = roleName;
    }

    public ChampionViewModel(Champion champion)
    {
        Id = champion.Id;
        Name = champion.Name;
        Hp = champion.Hp;
        Mana = champion.Mana;
        DateOfRelease = champion.DateOfRelease;
        RoleName = champion.Role.Name;
    }

    public Champion ToDbEntity()
    {
        return new Champion
        {
            Id = Id,
            Name = Name,
            Hp = Hp,
            Mana = Mana,
            DateOfRelease = DateOfRelease,
            RoleId = RoleId,
        };
    }

    public void ToDbEntity(Champion champion)
    {
        champion.Id = Id;
        champion.Name = Name;
        champion.Hp = Hp;
        champion.Mana = Mana;
        champion.DateOfRelease = DateOfRelease;
        champion.RoleId = RoleId;
    }
}
