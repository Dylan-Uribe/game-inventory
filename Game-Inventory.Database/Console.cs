using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database
{
    public class Console
    {
        public int ID { get; set; } 

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool State { get; set; }

        public int CompanyID { get; set; }

        public required virtual Company Company { get; set; }
    }
}
