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
        public int Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }

        public Sala(int colunas, int filas) 
        {
            Colunas = colunas;
            Filas = filas;
        }

    }
}
