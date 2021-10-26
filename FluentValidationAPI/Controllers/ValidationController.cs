using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validation.Model.Model;

namespace FluentValidationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [HttpPost]
        [Route("/v1/ValidaUsuario/")]
        public ActionResult ValidaUsuario(Usuario usuario)
        => Ok("Valido");

        [HttpPost]
        [Route("/v1/ValidaListaUsuario/")]
        public ActionResult ValidaListaUsuario(List<Usuario> usuarios)
        => Ok("Valido");
    }
}
