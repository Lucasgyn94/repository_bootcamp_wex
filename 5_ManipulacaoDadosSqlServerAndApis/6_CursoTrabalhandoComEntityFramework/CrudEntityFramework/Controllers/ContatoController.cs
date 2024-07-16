using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.Context;
using CrudEntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrudEntityFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {   
        // recebendo via contrutor _context (injeç]ao de dependência)
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato) {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }

        // Obter lista contato
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) {
            var contato = _context.Contatos.Find(id);
            if (contato == null) {
                return NotFound();
            } else {
                return Ok(contato);
            }
        }

        // obter contatos por nome
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome) {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }
        // criando metodo de atualizar
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) {
                return NotFound();
            } else {
                contatoBanco.Nome = contato.Nome;
                contatoBanco.Telefone = contato.Telefone;
                contatoBanco.Ativo = contato.Ativo;

                _context.Contatos.Update(contatoBanco);
                _context.SaveChanges();

                return Ok(contatoBanco);
            }
        }
        
        // deletando registro no banco
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) {
            var contaBanco = _context.Contatos.Find(id);
            if (contaBanco == null) {
                return NotFound();
            } else {
                _context.Contatos.Remove(contaBanco);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}