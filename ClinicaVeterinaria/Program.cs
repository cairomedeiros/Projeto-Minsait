using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Repository;
using ClinicaVeterinaria.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
            builder.Services.AddDbContext<ClinicaContext>(options =>
                options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
            builder.Services.AddScoped<ITutorRepository, TutorRepository>();
            builder.Services.AddScoped<SeedingService>();

            var app = builder.Build();

            

            void SeedData(IHost app) {
                var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

                using (var scope = scopedFactory.CreateScope())
                {
                    var service = scope.ServiceProvider.GetService<SeedingService>();
                    service.Seed();
                }
            }

            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
                SeedData(app);
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}