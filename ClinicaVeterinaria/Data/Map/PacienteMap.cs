using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicaVeterinaria.Data.Map {
    public class PacienteMap : IEntityTypeConfiguration<Paciente>  {
        public void Configure(EntityTypeBuilder<Paciente> builder) {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(128);
        }
    }
}
