using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto007_RotasMVC.Models {
    public class Noticia {

        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        //Cria um metodo IEnumerable, com uma collection dentro
        //Collection retorna uma lista de objetos da classe Noticia
        public IEnumerable <Noticia> TodasAsNoticias() {

            var retorno = new Collection<Noticia> {

                new Noticia {
                    NoticiaId = 1,
                    Categoria ="Esportes",
                    Titulo = "Felipe Massa ganha a F1",
                    Conteudo = "Em uma tarde chuvosa Felipe Massa ganha a F1...",
                    Data = new DateTime(2012,7,5)
                },

                new Noticia {
                    NoticiaId = 2,
                    Categoria ="Politica",
                    Titulo = "Presidente assina convênios",
                    Conteudo = "Durante a reunião Presidente Esmael Freitas assina os convênios...",
                    Data = new DateTime(2012,7,3)
                },

                new Noticia {
                    NoticiaId = 3,
                    Categoria ="Politica",
                    Titulo = "Vereador e eleito pela quarta vez",
                    Conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                    Data = new DateTime(2012,7,20)
                },

                new Noticia {
                    NoticiaId = 4,
                    Categoria = "Esportes",
                    Titulo = "O tão sonhado título chegou...",
                    Conteudo = "Em um jogo que levou os torcedores ao delirio...",
                    Data = new DateTime(2012,7,18)
                },

                new Noticia {
                    NoticiaId = 5,
                    Categoria = "Humor",
                    Titulo = "O comediante Anderson Renato fará um show hoje",
                    Conteudo = "O comediante mais engraçado dos comentários do YouTube fará um show",
                    Data = new DateTime(2012, 7,14)
                },

                new Noticia {
                    NoticiaId = 6,
                    Categoria = "Policial",
                    Titulo = "Tenente Lucas Farias Santos assume o controle",
                    Conteudo = "Durante a retomada do morro o Tenente Lucas Farias Santos disse...",
                    Data = new DateTime(2012, 7, 19)
                },

                new Noticia {
                    NoticiaId = 7,
                    Categoria = "Esportes",
                    Titulo = "Atacante do Barcelona faz 4 gols",
                    Conteudo = "Atacante Leonel Messi faz 4 gols e decide o título...",
                    Data = new DateTime(2012,7,8)
                }
            };

            return retorno;
        }

    }
}