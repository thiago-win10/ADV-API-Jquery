using System.ComponentModel.DataAnnotations;

namespace Mercado.Entidades.ViewModels
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }

        [Display(Name = "Cartão Fidelidade")]
        public bool CartaoFidelidade { get; set; }
        
        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Cep { get; set; }
        
        [Required]
        public string Rua { get; set; }
        
        [Required]
        public string Numero { get; set; }
        
        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }
    }
}
