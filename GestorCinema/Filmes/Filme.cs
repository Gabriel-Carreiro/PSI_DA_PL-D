using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Filme
    {
        [Key]
        public int Id { get; set; }
        public string Nome {get; set;}
        public string Duracao { get; set;}
        public bool Estado { get; set;}
        public Categoria Categoria { get; set;}

        public Filme(string nome, string duracao, Categoria categoria)
        {
            Nome = nome;
            Duracao = duracao;
            Categoria = categoria;
            Estado = false;
        }

        public Filme() { }
    }
}
