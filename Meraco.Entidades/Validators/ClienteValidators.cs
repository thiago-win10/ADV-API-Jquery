using FluentValidation;
using Mercado.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Entidades
{
    public class ClienteValidators : AbstractValidator<Cliente>
    {
        public ClienteValidators()
        {
            RuleFor(x => x.NomeCompleto).NotNull().NotEmpty().WithMessage("Please ensure you have entered the Name")
            .Length(2, 150).WithMessage("The Name must have between 2 and 150 characters");

            RuleFor(x => x.Bairro).NotNull().NotEmpty().WithMessage("Please ensure you have entered the Neighbor")
            .Length(4, 100).WithMessage("The Name must have between 4  and 100 characters"); ;

            RuleFor(x => x.Cep).NotEmpty().WithMessage("Please specify Cep")
            .Length(8);

            RuleFor(x => x.Numero).NotEmpty().WithMessage("Please specify Number")
           .Length(50);

            RuleFor(x => x.Rua).NotEmpty().WithMessage("Please specify CPF")
            .Length(50);


            RuleFor(x => x.Cidade).NotEmpty().WithMessage("Please specify City")
            .Length(50);

            RuleFor(x => x.Cpf).NotEmpty().WithMessage("Please specify CPF")
            .Length(11);

            RuleFor(c => c.Datanascimento)
             .NotEmpty()
                .WithMessage("The cliente must have 18 years or more");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Please specify Email")
            .Length(50);

            RuleFor(x => x.Estado).NotEmpty().WithMessage("Please specify State")
            .Length(11);

            RuleFor(x => x.Telefone).NotEmpty().WithMessage("Please specify Phone")
            .Length(50);
        }
    }
}
