using System;

namespace Mercado.Entidades.Models
{
    public class ClienteEndereco
    {
        public Guid ClienteEnderecoId { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int EnderecoClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
