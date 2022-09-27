using System;

namespace Mercado.Entidades.Models
{
    public class Cliente
    {
        private Guid guid;

        public Cliente(Guid guid, string nomeCompleto, Guid clienteId, string email, DateTime datanascimento, string cep)
        {
            this.guid = guid;
            NomeCompleto = nomeCompleto;
            ClienteId = clienteId;
            Email = email;
            Datanascimento = datanascimento;
            Cep = cep;
        }

        public Guid ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public bool CartaoFidelidade { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
