using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCinema
{
    internal class Funcionario : Pessoa
    {
        public int Salario { get; set; }
        public string Funcao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    
        public Funcionario(string nome, string morada, int salario, string funcao, string login, string senha) { 
            
            Nome = nome;
            Morada = morada;
            Salario = salario;
            Funcao = funcao;
            Login = Login;
            Senha = senha;
        }
        public Funcionario() { }
    }
}
