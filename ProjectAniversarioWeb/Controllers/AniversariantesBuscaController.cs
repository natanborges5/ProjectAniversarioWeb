using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectAniversarioWeb.Services;
using ProjectAniversarioWeb.Data;
using ProjectAniversarioWeb.Models;

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
                string var = "a";
                nome = var;
            }
            var result = await _AniversariantesBuscaService.buscarPorNomeAsync(nome);
            return View(result);
        }
        public async Task<IActionResult> PesquisaData(DateTime data)
        {
            if (data == null)
            {
                var datahoje = DateTime.Today;
                data = datahoje;
            }
            var result = await _AniversariantesBuscaService.buscarPorDataAsync(data);
            return View(result);
        }
        ///////////////////////////////////////////////////////////////////////////////////
        ///
    }
}