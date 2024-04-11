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
    internal class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            // Table Name
            builder.ToTable("Teams");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Basic Constraints
            builder.Property(c => c.Name).HasDefaultValue("name");

            // Make Relations
            builder.HasMany(c => c.Players).WithOne(c => c.Team)
                .HasPrincipalKey(c => c.Id).HasForeignKey(e => e.TeamID);
        }
    }
}
