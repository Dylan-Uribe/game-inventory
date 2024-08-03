
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database;

public class Game
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Genre {  get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool State { get; set; }

    public virtual ICollection<GameConsole> GameConsoles { get; } = new List<GameConsole>();

}
