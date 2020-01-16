using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteMVC.Models
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool ManterLogado { get; set; }
    }
}