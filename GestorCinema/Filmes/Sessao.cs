using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Sessao
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public float Preco { get; set; }
        public Filme Filme { get; set; }
        public Sala Sala { get; set; }

        public Sessao(DateTime datahora, float preco, Filme filme, Sala sala) {
            
            DataHora = datahora;
            Preco = preco;
            Filme = filme;
            Sala = sala;
        }

        public Sessao() { }
    }
}
