using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Model.Model;

namespace Validation.Model.Validation
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(customer => customer.idade)
                .NotEmpty().WithMessage("Por Favor, adicione o numero referente Idade do usuario")
                .NotNull().WithMessage("Por Favor, adicione o numero referente Idade do usuario");

            RuleFor(customer => customer.Nome)
                .NotEmpty().WithMessage("Por Favor, adicione o primeiro nome do usuario")
                .Length(2, 250).WithMessage("por favor, o tamanho do primeiro nome ultrapassa o tamanho disponvel")
                .NotNull().WithMessage("por favor, o tamanho do primeiro nome ultrapassa o tamanho disponvel");

            RuleFor(customer => customer.SobreNome)
                .NotEmpty().WithMessage("Por Favor, adicione o SobreNome do usuario")
                .NotNull().WithMessage("Por Favor, adicione o SobreNome do usuario")
                .Length(2, 250).WithMessage("por favor, o tamanho do SobreNome ultrapassa o tamanho disponvel");

            RuleFor(customer => customer.Sexo)
                .NotEmpty().WithMessage("Por Favor, adicione o valor M/H para o sexo do usuario")
                .NotNull().WithMessage("Por Favor, adicione o valor M/H para o sexo do usuario");
        }
    }
}
