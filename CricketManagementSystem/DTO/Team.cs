using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketManagementSystem.Data.DTO
{
    public class Team : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}
