using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Inventory.Database
{
    public class Company
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string CEO { get; set; }

        public string Description { get; set; }

        public bool State { get; set; }
    }
}
