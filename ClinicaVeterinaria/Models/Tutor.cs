﻿using ClinicaVeterinaria.Models.Dtos;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaVeterinaria.Models {
    public class Tutor {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNascimento { get; set; }
        [ForeignKey("TutorId")]
        public List<Paciente> PacienteList { get; set; }

        public Tutor(Guid id, string nome, string cPF, string endereco, string telefone, DateOnly dataNascimento) {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public Tutor() {
        }
    }
}
