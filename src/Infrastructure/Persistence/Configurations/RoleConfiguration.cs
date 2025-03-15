using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kultura.Domain.Constants;  // ✅ Moved Roles to a separate file

namespace Kultura.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),  // ✅ Generate GUID dynamically
                Name = RoleConstants.Chef,
                NormalizedName = RoleConstants.Chef.ToUpper()
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),  // ✅ Generate GUID dynamically
                Name = RoleConstants.Admin,
                NormalizedName = RoleConstants.Admin.ToUpper()
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),  // ✅ Generate GUID dynamically
                Name = RoleConstants.Waiter,
                NormalizedName = RoleConstants.Waiter.ToUpper()
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),  // ✅ Generate GUID dynamically
                Name = RoleConstants.Host,
                NormalizedName = RoleConstants.Host.ToUpper()
            }
        );
    }
}