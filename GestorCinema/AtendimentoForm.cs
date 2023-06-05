using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    public partial class AtendimentoForm : Form
    {

        public AtendimentoForm()
        {
            InitializeComponent();

        }

        //Essa função vai abrir a tab2 e criar o numero de cadeiras conforme o numero salvo na sala selecionada
        private void SelecionarSala()
        {
            //Enquanto as salas nao foram criadas e nem configurada estou usando essa variavel para escolher o numero de
            //cadeiras que serao criadas
            int size = 10;

            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = size;
            tableLayoutPanel1.ColumnCount = size;
            
            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {
                    Button button = new LugarButton(i, j);
                    button.Size = new Size(70,50);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.BackgroundImage = Image.FromFile("C:\\Users\\gabri\\OneDrive\\Documentos\\GitHub\\ProjetoDA\\GestorCinema\\cadeira.png");
                    button.Click += LugarClicked;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
            tableLayoutPanel1.ResumeLayout();

            TabControl control = tabPage1.Parent as TabControl;
            control.SelectedIndex = 1;

        }

        internal TabPage getPage()
        {
            return TabAtendimento.TabPages[0];
        }

        //Captura as cordenadas do botao que foi carregado
        private void LugarClicked(Object sender, EventArgs e)
        {
            LugarButton button = (LugarButton)sender;
            MessageBox.Show("X: " + button.X + " Y: " + button.Y);
        }

        //Caso o cliente nao queira usar sua conta
        private void btClienteAnonimo_Click(object sender, EventArgs e)
        {
            //falta criar variavel que vai armazenar a sala e enviar para o bilhete

            SelecionarSala();
        }

        //Caso o cliente queira usar a conta
        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            //falta criar alguma variavel para armazenar o cliente e enviar para o bilhete
            //falta criar variavel que vai armazenar a sala e enviar para o bilhete

            SelecionarSala();
        }
    }
}
