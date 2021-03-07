using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApi.Db;
using TodoListApi.Models;

namespace TodoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : Controller
    {
        private readonly DataContext Db;
        public TarefaController(DataContext db)
        {
            this.Db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tarefas = await Db.Tarefas.ToListAsync();

            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tarefa = await Db.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(Tarefa tarefa)
        {
            await Db.Tarefas.AddAsync(tarefa);

            await Db.SaveChangesAsync();

            return Ok(tarefa);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTask(Tarefa tarefa)
        {
            Db.Tarefas.Update(tarefa);

            await Db.SaveChangesAsync();

            return Ok(tarefa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var tarefa = await Db.Tarefas.FindAsync(id);

            Db.Tarefas.Remove(tarefa);

            await Db.SaveChangesAsync();

            return Ok();
        }
    }
}
