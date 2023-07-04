using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Funcionario : Pessoa
    {
        public string Salario { get; set; }
        public string Funcao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Logado { get; set; }
        public DateTime DataContratacao { get; set; }
    
        public Funcionario(string nome, string nif, string morada, string telefone, string salario, string funcao, string login, string senha) { 
            
            Nome = nome;
            Nif = nif;
            Morada = morada;
            Telefone = telefone;
            Salario = salario;
            Funcao = funcao;
            DataContratacao = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            Login = login;
            Senha = senha;
            Logado = false;

        }
        public Funcionario() { }
    }
}
