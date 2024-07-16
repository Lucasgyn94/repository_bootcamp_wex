using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamentoTarefasEF.Models;

namespace ProjetoAgendamentoTarefasEF.Controllers
{
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context) {
            _context = context;
        }

        // TODO: Buscar o Id no banco utilizando o EF
        // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
        // caso contrário retornar OK com a tarefa encontrada
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null) {
                return NotFound();
            } else {
                return Ok(tarefa);
            }
        }
        
        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos() {
           var tarefas = _context.Tarefas.ToList();
           return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo) {
            var tarefas = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));
            return Ok(tarefas);
        }

        [HttpGet("ObterPorData")] 
        public IActionResult ObterPorData(DateTime data) {
            var tarefas = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefas);
        }
        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status) {
            var tarefas =_context.Tarefas.Where(x => x.Status == status).ToList();
            return Ok(tarefas);
        }

        [HttpPost("Tarefa")]
        public IActionResult Criar( Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa) {
            var tarefaBanco = _context.Tarefas.Find(id);
            if (tarefaBanco == null) {
                return NotFound();
            } else {
                tarefaBanco.Titulo = tarefa.Titulo;
                tarefaBanco.Descricao = tarefa.Descricao;
                tarefaBanco.Data = tarefa.Data;
                tarefaBanco.Status = tarefa.Status;

                _context.Tarefas.Update(tarefaBanco);
                _context.SaveChanges();
                return Ok(tarefaBanco);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null) {
                return NotFound();
            } else {
                _context.Tarefas.Remove(tarefaBanco);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}