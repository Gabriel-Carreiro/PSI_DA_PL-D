using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Bilhete
    {
        [Key]
        public int Id { get; set; }
        public Sessao Sessao { get; set; }
        public string Lugar { get; set; }
        public Cliente Cliente { get; set; }
        public StatusValidade Estado { get; set; }

        public enum StatusValidade
        {
            Inativo,
            Ativo
        }
        public Bilhete(Sessao sessao, string lugar)
        {
            Sessao = sessao;
            Lugar = lugar;
            Estado = StatusValidade.Ativo;
        }
        public Bilhete(Sessao sessao, string lugar, Cliente cliente)
        {
            Cliente = cliente;
            Sessao = sessao;
            Lugar = lugar;
            Estado = StatusValidade.Ativo;
        }

        public Bilhete() { }
    }

}
