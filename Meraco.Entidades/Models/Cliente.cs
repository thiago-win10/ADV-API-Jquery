using System;

namespace Mercado.Entidades.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public bool CartaoFidelidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool  Status { get; set; }
    }
}
