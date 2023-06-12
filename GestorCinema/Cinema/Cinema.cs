using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Cinema
    {
        [Key]
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public int Salas { get; set; }

        public Cinema() { }
        public Cinema(string nome, string morada, string email, int salas)
        {
            Nome = nome;
            Morada = morada;
            Email = email;
            Salas = salas;
        }
        public void AdicionarSala()
        {
            Salas++;
        }
    }

}
