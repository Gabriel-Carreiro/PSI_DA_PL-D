using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Sala
    {
        [Key]
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }

        public Sala(int nome ,int colunas, int filas) 
        {
            Nome = nome;
            Colunas = colunas;
            Filas = filas;
        }

        public Sala() { }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
