using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto006_Validacao.Models
{
    public class Pessoa
    {
        //Data Anotation Faz validação tanto no lado do cliente, quanto no lado do servidor

        [Required(ErrorMessage = "Campo Nome é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Sexo é Obrigatório")]
        public string Sexo { get; set; }

        //[Range(18 ,50,  ErrorMessage ="Minimo 18, máximo 50")]
        [Required(ErrorMessage = "Campo Idade é Obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Email é Obrigatório")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email Incorreto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Login é Lbrigatório")]
        [Remote("LoginUnico", "Home", ErrorMessage = "{0} ja existe")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Campo Senha é Obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage ="Campo Comfirmar Senha e Obrigatório")]
        [System.ComponentModel.DataAnnotations.Compare("Senha" , ErrorMessage ="Campos Senha e Comfirma Senha devem ser iguais")]
        public string ComfirmaSenha { get; set; }

    }
}