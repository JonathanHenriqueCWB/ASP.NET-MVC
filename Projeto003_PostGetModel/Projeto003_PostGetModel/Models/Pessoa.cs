using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto003_PostGetModel.Models {

    //Model de representação de uma pessoa 
    public class Pessoa {

        public int PessoaId { get; set; }
        public string Nome { get; set; } 
        public string Email { get; set; }

    }
}