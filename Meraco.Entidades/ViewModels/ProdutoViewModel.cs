using Mercado.Entidades.Enum;
using Mercado.Entidades.Models;
using System;

namespace Mercado.Entidades.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public byte[] Imagem { get; set; }
        public int Estoque { get; set; }
        public Categoria TipoCategoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
