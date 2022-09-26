using Mercado.Entidades.Models;
using System;

namespace Mercado.Entidades.ViewModels
{
    public class FornecedorViewModel
    {
        public Guid FornecedorId { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public FornecedorEndereco FornecedorEndereco { get; set; }
    }
}
