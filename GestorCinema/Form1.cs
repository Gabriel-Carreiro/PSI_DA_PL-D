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
    public partial class Form1 : Form
    {
        private Funcionarios funcionarios;
        private Clientes clientes;
        private Informacoes informacoes;
        private Atendimento atendimento;
        private Filmes filmes;
        private Sessoes sessoes;

        public Form1()
        {
            InitializeComponent();
            
            //temos que fazer com que caso nao esteja logado entre em loop
            /*this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();*/
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.clientes == null)
            {
                this.clientes = new Clientes();
            }

            GroupBox groupBox = this.clientes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.funcionarios == null)
            {
                this.funcionarios = new Funcionarios();
            }

            GroupBox groupBox = this.funcionarios.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void informaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.informacoes == null)
            {
                this.informacoes = new Informacoes();
            }

            GroupBox groupBox = this.informacoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            if (this.informacoes == null)
            {
                this.atendimento = new Atendimento();
            }
            TabControl tabControl = new TabControl();
            tabControl.Size = panel1.Size;
            this.panel1.Controls.Add(tabControl);
            TabPage tab = new Atendimento().getPage();
            tabControl.TabPages.Add(tab);

            //chamar a segunda tab
            TabPage tab2 = new Atendimento().TabAtendimento.TabPages[1];
            tabControl.TabPages.Add(tab2);



        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.filmes == null)
            {
                this.filmes = new Filmes();
            }

            GroupBox groupBox = this.filmes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void sessõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.sessoes == null)
            {
                this.sessoes = new Sessoes();
            }

            GroupBox groupBox = this.sessoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
