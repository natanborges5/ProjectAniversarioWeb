using ProjectAniversarioWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAniversarioWeb.Models;

namespace ProjectAniversarioWeb.Services
{
    public class AniversariantesBuscaService
    {
        private readonly ProjectAniversarioWebContext _context;


        public AniversariantesBuscaService(ProjectAniversarioWebContext context)
        {
            _context = context;
        }
        public async Task<List<Aniversariante>> buscarPorNomeAsync(string nome)
        {
            var result = from obj in _context.Aniversariante select obj;
            result = result.Where(x => x.nomeCompleto.Contains(nome));
            return await result
                .OrderByDescending(x => x.primeiroNome)
                .ToListAsync();
        }
        public async Task<List<Aniversariante>> buscarPorDataAsync(DateTime data)
        {
            var result = from obj in _context.Aniversariante select obj;
            result = result.Where(x => x.dataAniversario == data);
            return await result
                .OrderByDescending(x => x.dataAniversario)
                .ToListAsync();
        }
    }
}
