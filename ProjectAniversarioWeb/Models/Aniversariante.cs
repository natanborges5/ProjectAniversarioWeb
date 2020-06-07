using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAniversarioWeb.Models
{
    public class Aniversariante
    {
        [Key]
        public string primeiroNome { get; set; }
        public string segundoNome { get; set; }
        public DateTime dataAniversario { get; set; }
        public string nomeCompleto { get { return $"{primeiroNome} {segundoNome}"; } }
    }
}
