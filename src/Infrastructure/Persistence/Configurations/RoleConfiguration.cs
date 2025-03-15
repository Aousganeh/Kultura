using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kultura.Domain.Constants;

namespace Kultura.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = RoleConstants.ProjectOwner,
                Name = "ProjectOwner",
                NormalizedName = "PROJECTOWNER"
            },
            new IdentityRole
            {
                Id = RoleConstants.Admin,
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = RoleConstants.Chef,
                Name = "Chef",
                NormalizedName = "CHEF"
            },
            new IdentityRole
            {
                Id = RoleConstants.Waiter,
                Name = "Waiter",
                NormalizedName = "WAITER"
            },
            new IdentityRole
            {
                Id = RoleConstants.Host,
                Name = "Host",
                NormalizedName = "HOST"
            }
        );
    }
}