using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicaVeterinaria.Data.Map {
    public class MedicoResponsavelMap : IEntityTypeConfiguration<MedicoResponsavel> {

        public void Configure(EntityTypeBuilder<MedicoResponsavel> builder) {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
        }
    }
}
