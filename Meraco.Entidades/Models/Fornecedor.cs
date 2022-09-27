using System;

namespace Mercado.Entidades.Models
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public FornecedorEndereco FornecedorEndereco { get; set; }
        public int FornecedorProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
