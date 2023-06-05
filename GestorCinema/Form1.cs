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
        private FuncionariosForm formFuncionarios;
        private ClientesForm formClientes;
        private InformacoesForm formInformacoes;
        private AtendimentoForm formAtendimento;
        private FilmesForm formFilmes;
        private SessoesForm formSessoes;

        
        public Form1()
        {
            InitializeComponent();

            //temos que fazer com que caso nao esteja logado entre em loop
            /* this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show(); */
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.formClientes == null)
            {
                this.formClientes = new ClientesForm();
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
                this.formFuncionarios = new FuncionariosForm();
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
                this.formInformacoes = new InformacoesForm();
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
                this.formAtendimento = new AtendimentoForm();
            }
            TabControl tabControl = new TabControl();
            tabControl.Size = panel1.Size;
            this.panel1.Controls.Add(tabControl);
            AtendimentoForm atendimento = new AtendimentoForm();
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
                this.formFilmes = new FilmesForm();
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
                this.formSessoes = new SessoesForm();
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
