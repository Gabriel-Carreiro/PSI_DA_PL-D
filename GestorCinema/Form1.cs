using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    public partial class Form1 : Form
    {
        private Funcionarios formFuncionarios;
        private Clientes formClientes;
        private Informacoes formInformacoes;
        private Atendimento formAtendimento;
        private Filmes formFilmes;
        private Sessoes formSessoes;

        
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
            if (this.formClientes == null)
            {
                this.formClientes = new Clientes();
            }

            GroupBox groupBox = this.formClientes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.formFuncionarios == null)
            {
                this.formFuncionarios = new Funcionarios();
            }

            GroupBox groupBox = this.formFuncionarios.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void informaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.formInformacoes == null)
            {
                this.formInformacoes = new Informacoes();
            }

            GroupBox groupBox = this.formInformacoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            if (this.formAtendimento == null)
            {
                this.formAtendimento = new Atendimento();
            }
            TabControl tabControl = new TabControl();
            tabControl.Size = panel1.Size;
            this.panel1.Controls.Add(tabControl);
            Atendimento atendimento = new Atendimento();
            TabPage tab = atendimento.getPage();
            tabControl.TabPages.Add(tab);

            //chamar a segunda tab
            TabPage tab2 = atendimento.TabAtendimento.TabPages[0];
            tabControl.TabPages.Add(tab2);
            

        }

        private void filmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.formFilmes == null)
            {
                this.formFilmes = new Filmes();
            }

            GroupBox groupBox = this.formFilmes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void sessõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.formSessoes == null)
            {
                this.formSessoes = new Sessoes();
            }

            GroupBox groupBox = this.formSessoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
