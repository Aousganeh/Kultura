using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kultura.Domain.Constants;

namespace Kultura.Persistence.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string> { UserId = "1", RoleId = RoleConstants.ProjectOwner },
            new IdentityUserRole<string> { UserId = "2", RoleId = RoleConstants.Admin },
            new IdentityUserRole<string> { UserId = "3", RoleId = RoleConstants.Chef },
            new IdentityUserRole<string> { UserId = "4", RoleId = RoleConstants.Waiter },
            new IdentityUserRole<string> { UserId = "5", RoleId = RoleConstants.Host }
        );
    }
}