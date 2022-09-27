using Mercado.Entidades.Models;
using System;

namespace Mercado.Entidades.ViewModels
{
    public class ClienteViewModel
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
