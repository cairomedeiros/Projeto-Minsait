﻿using ClinicaVeterinaria.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class Paciente {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(100)]
        public string Especie { get; set; }
        [Required]
        [MaxLength(150)]
        public string Raca { get; set; }
        [Required]
        [MaxLength(2)]
        public double Idade { get; set; }
        [Required]
        [MaxLength(4)]
        public double Peso { get; set; }
        [MaxLength(80)]
        [Required]
        public string Cor { get; set; }
        [Required]
        public Guid TutorId { get; set; }
        [Required]
        public EDirecaoEspecialidade EDirecaoEspecialidade { get; set; }

        public Paciente(Guid id, string nome, string especie, string raca, double idade, double peso, string cor, EDirecaoEspecialidade eDirecaoEspecialidade, Guid tutorId) {
            Id = id;
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Cor = cor;
            EDirecaoEspecialidade = eDirecaoEspecialidade;
            TutorId = tutorId;
        }

        public Paciente() {

        }
    }
}
