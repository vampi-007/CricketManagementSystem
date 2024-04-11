using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CricketManagementSystem.Data.DTO.Map
{
    internal class PlayerMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            // Table Name
            builder.ToTable("Players");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Basic Constraints
            builder.Property(c => c.Name).HasDefaultValue("name");

            // Make Relations
            builder.HasOne(c => c.Team).WithMany(c => c.Players)
                .HasPrincipalKey(c => c.Id).HasForeignKey(e => e.TeamID);
        }
    }
}
