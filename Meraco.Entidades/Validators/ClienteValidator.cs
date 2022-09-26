using FluentValidation;
using Mercado.Entidades.Models;

namespace Mercado.Entidades
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.NomeCompleto).NotNull().NotEmpty().WithMessage("Please ensure you have entered the Name")
            .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");

            RuleFor(x => x.Cpf).NotEmpty().WithMessage("Please specify CPF")
            .Length(11);

            RuleFor(c => c.DataNascimento)
             .NotEmpty()
                .WithMessage("The cliente must have 18 years or more");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Please specify Email")
            .Length(50);

            RuleFor(x => x.Telefone).NotEmpty().WithMessage("Please specify Phone")
            .Length(50);
        }
    }
}
