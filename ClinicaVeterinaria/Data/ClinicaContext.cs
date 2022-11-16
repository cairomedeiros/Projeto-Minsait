using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<LogErro> LogErros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid T1 = Guid.Parse("ea249baac22a495f981bed6d7c9ea029");
            Guid T2 = Guid.Parse("40213770be5a4c209a3b31e405378768");
            Guid T3 = Guid.Parse("6abd8cf347504cac925f8eaaea34234e");
            Guid P1 = Guid.Parse("368a40873de74bc8921eaa6a5a9be54a");
            Guid P2 = Guid.Parse("234eea2a034845b599a144b20f010e03");
            Guid P3 = Guid.Parse("59045bc12b6c4f5aa01d79f5190a28e3");
            Guid P4 = Guid.Parse("3abe35e4ec6442268ec7f2d4fe942177");
            Guid P5 = Guid.Parse("eaa6291d849a471dbc0b2be7bcc3c696");
            Guid P6 = Guid.Parse("9bac6f15a352481cb06e3e0d82f18ff4");
            Guid P7 = Guid.Parse("0628d87663b34b5e923e0678941494e5");
            Guid P8 = Guid.Parse("2694f3ac9c2046129179d888a1a0f696");

            modelBuilder.Entity<Paciente>()
                .Property(p => p.EResultadoTriagem)
                  .HasConversion(typeof(string));

            modelBuilder.Entity<Tutor>().HasData(
            new Tutor { Id = T1, Nome = "Naruto", CPF = "12312332124", Email = "narutouzumaki9@yahoo.com", Telefone = "99999999", DataNascimento = "16/10/1997", Ativo = true},
            new Tutor { Id = T2, Nome = "Luffy", CPF = "12312332124", Email = "monkeyd.luffy@pirate.com", Telefone = "99999999", DataNascimento = "03/05/1990", Ativo = true},
            new Tutor { Id = T3, Nome = "Jiraya", CPF = "12312332124", Email = "jirayaninja@gmail.com", Telefone = "99999999", DataNascimento = "06/05/1987", Ativo = false }
            );

            modelBuilder.Entity<Paciente>().HasData(
            new Paciente { Id = P1, Nome = "Nymeria", Especie = "Cachorro", Raca = "Pastor Alemão", Idade = 4, Peso = 22, Cor = "Preta", EResultadoTriagem = Enum.EResultadoTriagem.Odontologia, TutorId = T1 },
            new Paciente { Id = P2, Nome = "Mel", Especie = "Cachorro", Raca = "Shitzu", Idade = 7, Peso = 10, Cor = "Marrom", EResultadoTriagem = Enum.EResultadoTriagem.Cardiologia, TutorId = T2 },
            new Paciente { Id = P3, Nome = "Nemo", Especie = "Peixe", Raca = "Peixe Palhaço", Idade = 30, Peso = 1, Cor = "Laranja", EResultadoTriagem = Enum.EResultadoTriagem.Cardiologia, TutorId = T1 },
            new Paciente { Id = P4, Nome = "Maya", Especie = "Cachorro", Raca = "Shitzu", Idade = 4, Peso = 10, Cor = "Preta e branca", EResultadoTriagem = Enum.EResultadoTriagem.Endocrinologia, TutorId = T2 },
            new Paciente { Id = P5, Nome = "Giga", Especie = "Pokemón Tartaruga", Raca = "Blastoise", Idade = 12, Peso = 700, Cor = "Azul", EResultadoTriagem = Enum.EResultadoTriagem.Nutrologia, TutorId = T2 },
            new Paciente { Id = P6, Nome = "Snorlax", Especie = "Pokemón Gato", Raca = "Snorlax", Idade = 5, Peso = 1000, Cor = "Verde e branca", EResultadoTriagem = Enum.EResultadoTriagem.Oftalmologia, TutorId = T1 },
            new Paciente { Id = P7, Nome = "Dragaozinho", Especie = "Dragão", Raca = "Charmander", Idade = 3, Peso = 40, Cor = "Laranja", EResultadoTriagem = Enum.EResultadoTriagem.Hematologia, TutorId = T1 },
            new Paciente { Id = P8, Nome = "Gamabunta", Especie = "Sapo", Raca = "Sapo gigante", Idade = 50, Peso = 1000, Cor = "Laranja", EResultadoTriagem = Enum.EResultadoTriagem.Nefrologia, TutorId = T3 }
            );



        }
    }
}
