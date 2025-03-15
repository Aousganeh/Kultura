using MassTransit;
using Microsoft.OpenApi.Models;

namespace Kultura.WebAPI;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        AddSwaggerDoc(services);


        services.AddControllers();

        services.AddCors(o =>
        {
            o.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }


        app.UseAuthentication();

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v0.1/swagger.json", "Kultura.WebAPI v0.1"));

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseCors("CorsPolicy");

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }

    private void AddSwaggerDoc(IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = @"JWT Authorization header using the Bearer scheme. 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      Example: 'Bearer 12345abcdef'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "Bearer",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                    },
                    new List<string>()
                }
            });

            c.SwaggerDoc("v0.1", new OpenApiInfo
            {
                Version = "v0.1",
                Title = "Kultura WebAPI",
            });
        });
    }
}