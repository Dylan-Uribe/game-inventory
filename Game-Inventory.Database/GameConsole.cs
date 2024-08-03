using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database;

public class GameConsole
{
    public int GameId { get; set; }

    public int ConsoleId { get; set; }

    public DateOnly ReleaseDate {  get; set; }

    public decimal Price { get; set; } = decimal.Zero;

    public required virtual Game Game { get; set; }

    public required virtual Console Console { get; set; }
}
