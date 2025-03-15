using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kultura.Domain.Entities;
using Kultura.Domain.Constants;

namespace Kultura.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.HasData(
            new ApplicationUser
            {
                Id = "1",
                UserName = "admin@kultura.com",
                NormalizedUserName = "ADMIN@KULTURA.COM",
                Email = "admin@kultura.com",
                NormalizedEmail = "ADMIN@KULTURA.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin123!"),
                BranchId = 1 // ✅ Assign branch
            },
            new ApplicationUser
            {
                Id = "2",
                UserName = "waiter@kultura.com",
                NormalizedUserName = "WAITER@KULTURA.COM",
                Email = "waiter@kultura.com",
                NormalizedEmail = "WAITER@KULTURA.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Waiter123!"),
                BranchId = 1
            },
            new ApplicationUser
            {
                Id = "3",
                UserName = "chef@kultura.com",
                NormalizedUserName = "CHEF@KULTURA.COM",
                Email = "chef@kultura.com",
                NormalizedEmail = "CHEF@KULTURA.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Chef123!"),
                BranchId = 1
            },
            new ApplicationUser
            {
                Id = "4",
                UserName = "host@kultura.com",
                NormalizedUserName = "HOST@KULTURA.COM",
                Email = "host@kultura.com",
                NormalizedEmail = "HOST@KULTURA.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Host123!"),
                BranchId = 1
            }
        );
    }
}