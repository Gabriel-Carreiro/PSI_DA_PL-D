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
        public List<Sala> Salas { get; set; }

        private int num_salas = 0;

        public Cinema() { }
        public Cinema(string nome, string morada, string email, int num_salas)
        {
            Nome = nome;
            Morada = morada;
            Email = email;
            this.num_salas = num_salas;
        }
        public void AdicionarSala(Sala sala)
        {
            Salas.Add(sala);
            this.num_salas++;
        }
    }

}
