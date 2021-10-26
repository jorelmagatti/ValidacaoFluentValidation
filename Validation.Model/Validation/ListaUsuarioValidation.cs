using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Model.Model;

namespace Validation.Model.Validation
{
    public class ListaUsuarioValidation : AbstractValidator<List<Usuario>>
    {
        public ListaUsuarioValidation()
        {
            RuleForEach(x => x).SetValidator(new UsuarioValidation());
        }
    }
}
