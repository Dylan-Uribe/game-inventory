using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database;

public class Console
{
    public int Id { get; set; } 

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public bool State { get; set; }

    public int CompanyId { get; set; }

    public required virtual Company Company { get; set; }

    public virtual ICollection<GameConsole> GameConsoles { get; } = new List<GameConsole>();
}