using System;

namespace Mercado.Entidades.Models
{
    public class FornecedorEndereco
    {
        public Guid FornecedorEnderecoId { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int EnderecoFornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
