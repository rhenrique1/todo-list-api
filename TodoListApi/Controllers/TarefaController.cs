using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApi.Controllers
{
    public class TarefaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
