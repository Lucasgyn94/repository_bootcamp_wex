using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        // metodo de obter data e hora
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora() {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome) {
            var mensagem = $"Ola {nome}, seja bem-vindo ao meu sistema";
            return Ok(new {mensagem});
        }
    }
}