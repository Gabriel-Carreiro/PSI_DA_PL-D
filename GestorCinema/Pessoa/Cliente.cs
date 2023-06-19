using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Cliente : Pessoa
    {
        public int BilhetesAdiquiridos { get; set; }
        public float TotalGasto { get; set; }

        public Cliente(string nome, string morada, string nif, string telefone) { 

            Nome = nome;
            Morada = morada;
            Nif = nif;
            Telefone = telefone;
        }
        public Cliente() { }

        public void AdicionarBilhete(Sessao sessao)
        {
            BilhetesAdiquiridos++;
            TotalGasto += sessao.Preco;
        }

    }
}
