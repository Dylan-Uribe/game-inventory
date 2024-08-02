using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Inventory.Database;

public class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string CEO { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool State { get; set; }

    public virtual ICollection<Console> Consoles { get; } = new List<Console>();
}
