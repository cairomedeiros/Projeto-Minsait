using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicaVeterinaria.Data.Map {
    public class TutorMap : IEntityTypeConfiguration<Tutor> {
        public void Configure(EntityTypeBuilder<Tutor> builder) {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(128);
        }
    }
}
