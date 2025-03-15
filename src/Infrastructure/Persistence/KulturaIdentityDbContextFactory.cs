using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Kultura.Persistence;

public class KulturaIdentityDbContextFactory : IDesignTimeDbContextFactory<KulturaIdentityDbContext>
{
    public KulturaIdentityDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "Presentation", "WebAPI");
        IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfigurationRoot configuration = builder.Build();
        
        string connectionString = configuration.GetConnectionString("KulturaIdentityDbConnectionString");
        
        DbContextOptionsBuilder<KulturaIdentityDbContext> optionsBuilder =
            new DbContextOptionsBuilder<KulturaIdentityDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new KulturaIdentityDbContext(optionsBuilder.Options);
    }
}