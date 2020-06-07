using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectAniversarioWeb.Services;

namespace ProjectAniversarioWeb.Controllers
{
    public class AniversariantesBuscaController : Controller
    {
        private readonly AniversariantesBuscaService _AniversariantesBuscaService;

        public AniversariantesBuscaController(AniversariantesBuscaService aniversariantesBuscaService)
        {
            _AniversariantesBuscaService = aniversariantesBuscaService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> PesquisaNome(string nome)
        {
            if(nome == null)
            {
                string var = "victor";
                nome = var;
            }
            var result = await _AniversariantesBuscaService.buscarPorNomeAsync(nome);
            return View(result);
        }
        public IActionResult PesquisaData()
        {
            return View();
        }
    }
}