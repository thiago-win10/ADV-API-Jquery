using System;

namespace Mercado.Entidades.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public bool CartaoFidelidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public ClienteEndereco ClienteEndereco { get; set; }

    }
}
