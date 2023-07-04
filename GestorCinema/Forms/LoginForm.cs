using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    public partial class LoginForm : Form
    {
        private ApplicationContext applicationContext;
        private List<Funcionario> funcionarios;


        public LoginForm()
        {
            InitializeComponent();

            // Definir as opções da combobox

            //Iniciar o applicationContext e criar lista de funcionarios
            applicationContext = new ApplicationContext();
            funcionarios = applicationContext.Pessoas.OfType<Funcionario>().ToList();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }
    }
}
