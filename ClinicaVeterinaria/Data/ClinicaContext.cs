using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Data {
    public class ClinicaContext : DbContext {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options) {
            
        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            Guid T1 = Guid.Parse("ea249baac22a495f981bed6d7c9ea029");
            Guid T2 = Guid.Parse("40213770be5a4c209a3b31e405378768");
            Guid P1 = Guid.Parse("368a40873de74bc8921eaa6a5a9be54a");
            Guid P2 = Guid.Parse("234eea2a034845b599a144b20f010e03");
            

            modelBuilder.Entity<Tutor>().HasData(
            new Tutor { Id = T1, Nome = "Cairo", CPF = "12312332124", Endereco = "Cabedelo", Telefone = "99999999", DataNascimento = new DateOnly(2000, 05, 07) },
            new Tutor { Id = T2, Nome = "Rita", CPF = "12312332124", Endereco = "JP", Telefone = "99999999", DataNascimento = new DateOnly(2002, 05, 02) }
            );

            modelBuilder.Entity<Paciente>().HasData(
            new Paciente { Id = P1, Nome = "Nymeria", Especie = "Cachorro", Raca = "Pastor Alemão", Idade = 4, Peso = 22, Cor = "Preta", EDirecaoEspecialidade = Enum.EDirecaoEspecialidade.Odontologia, TutorId = T1},
            new Paciente { Id = P2, Nome = "Mel", Especie = "Cachorro", Raca = "Shitzu", Idade = 7, Peso = 10, Cor = "Marrom",EDirecaoEspecialidade = Enum.EDirecaoEspecialidade.Cardiologia, TutorId = T2}
            
            );

            
            
        }
    }
}
