﻿using System;

namespace Mercado.Entidades.Models
{
    public class Funcionario
    {
        public Guid FuncionarioId { get; set; }
        public string NomeCompleto { get; set; }
        public decimal Salario { get; set; }
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
