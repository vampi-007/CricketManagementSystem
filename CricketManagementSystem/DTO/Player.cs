using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketManagementSystem.Data.DTO
{
    public class Player : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public Guid TeamID {  get; set; }
        public virtual Team Team { get; set; }
        public Player() { }
    }
}
