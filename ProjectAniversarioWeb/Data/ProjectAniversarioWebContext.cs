using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectAniversarioWeb.Models;

namespace ProjectAniversarioWeb.Data
{
    public class ProjectAniversarioWebContext : DbContext
    {
        public ProjectAniversarioWebContext (DbContextOptions<ProjectAniversarioWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectAniversarioWeb.Models.Aniversariante> Aniversariante { get; set; }
    }

}
