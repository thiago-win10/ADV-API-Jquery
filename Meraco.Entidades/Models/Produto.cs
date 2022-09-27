using Mercado.Entidades.Enum;
using System;
using System.Collections.Generic;

namespace Mercado.Entidades.Models
{
    public class Produto
    {
        public Produto()
        {
            Fornecedores = new List<Fornecedor>();
        }
        public Guid ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public byte[] Imagem { get; set; }
        public int Estoque { get; set; }
        public Categoria TipoCategoria { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
