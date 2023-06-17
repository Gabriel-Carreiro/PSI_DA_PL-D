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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public int numSalas {get; set;}

        public Cinema() { }
        public Cinema(string nome, string morada, string email, int num_salas)
        {
            Nome = nome;
            Morada = morada;
            Email = email;
            numSalas = num_salas;
        }
        public void AdicionarSala()
        {
            numSalas++;
        }
        public void ExcluirSala()
        {
            numSalas--;
        }
    }

}
