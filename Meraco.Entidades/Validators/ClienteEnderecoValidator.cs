using FluentValidation;
using Mercado.Entidades.Models;

namespace Mercado.Entidades.Validators
{
    public class ClienteEnderecoValidator : AbstractValidator<ClienteEndereco>
    {
        public ClienteEnderecoValidator()
        {
            RuleFor(x => x.Bairro).NotNull().NotEmpty().WithMessage("Please ensure you have entered the Neighbor")
            .Length(4, 100).WithMessage("The Name must have between 4  and 100 characters");

            RuleFor(x => x.Cep).NotEmpty().WithMessage("Please specify Cep")
            .Length(8);

            RuleFor(x => x.Numero).NotEmpty().WithMessage("Please specify Number")
            .Length(50);

            RuleFor(x => x.Rua).NotEmpty().WithMessage("Please specify CPF")
            .Length(50);

            RuleFor(x => x.Cidade).NotEmpty().WithMessage("Please specify City")
            .Length(50);

            RuleFor(x => x.Estado).NotEmpty().WithMessage("Please specify State")
            .Length(11);


        }
    }
}


