using CrowdSup.Domain.Entities.Usuarios;
using CrowdSup.Domain.Interfaces.DomainServices.Token;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrowdSup.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public LoginController(ITokenService tokenService)
        { 
            _tokenService = tokenService;
        }

        // [HttpPost]
        // public async Task<ActionResult<dynamic>> AutenticarAsync()
        // {
        //     //receber login request
        //     //buscar usuario do banco

        //     var usuario = new Usuario();

        //     if (usuario is null)
        //         return NotFound(new { message = "Usuário ou senha inválidos" });

        //     var token = _tokenService.GerarToken(usuario);

        //     return token;
        // }

        // [HttpGet]
        // [Authorize]
        // public async Task<ActionResult<dynamic>> TesteAsync()
        // {
        //     return "deu bom";
        // }


    }
}