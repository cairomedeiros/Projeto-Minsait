using ClinicaVeterinaria.Data;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Services
{
    public static class InitialMigration
    {
        //utilizado para executar as migrations automaticamente
        public static void RestoreMigration(this IApplicationBuilder app)
        {
            using (var escopo = app.ApplicationServices.CreateScope())
            {
                var ServiceDb = escopo.ServiceProvider.GetService<ClinicaContext>();
                ServiceDb.Database.Migrate();
            }
        }
    }
}
