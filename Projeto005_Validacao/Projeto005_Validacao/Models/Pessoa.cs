using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Projeto005_Validacao.Models
{
    public class Pessoa
    {   
        [Required(ErrorMessage = "ERRO Campo Nome Obrigatorio")] 
        public string Nome { get; set; }

        [Required(ErrorMessage ="ERRO Campo Observação Obrigatório")]
        [StringLength(50, MinimumLength =5, ErrorMessage ="ERRO Minimo 5, Máximo 50 char")]
        public string Observacao { get; set; }

        [Required(ErrorMessage ="ERRO Campo Idade Obrigatório")]
        [Range (18, 50, ErrorMessage ="ERRO Idade minima 18 máximo 50")]
        public int Idade { get; set; }

        [Required(ErrorMessage ="ERRO Campo Email Obrigatório")]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage ="ERRO Email invalido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="ERRO Somente letras de 5 a 10 caracteres")]
        [Required(ErrorMessage ="ERRO Campo Login Obrigatório")]
        [Remote("LoginUnico" , "Pessoa", ErrorMessage ="Login já existe")]
        public string Login { get; set; }
        
        [Required(ErrorMessage ="ERRO Campo Senha Obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage ="ERRO Campo Comfirmar Senha Obrigatório")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="ERRO Senhas devem ser iguais")]
        public string ComfirmaSenha { get; set; }
    }
}