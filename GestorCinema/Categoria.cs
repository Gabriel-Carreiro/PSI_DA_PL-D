using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Estado { get; set; }
    
        public Categoria(string nome) { 
            Nome = nome;
            Estado = true;
        }

        public Categoria() { }

    }

}
