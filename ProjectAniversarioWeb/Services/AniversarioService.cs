using ProjectAniversarioWeb.Data;
using ProjectAniversarioWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAniversarioWeb.Services
{
    public class AniversarioService
    {
        private readonly ProjectAniversarioWebContext _context;

        public AniversarioService(ProjectAniversarioWebContext context)
        {
            _context = context;
        }
        public List<Aniversariante> FindAll()
        {
            return _context.Aniversariante.ToList();
        }
    }
}
