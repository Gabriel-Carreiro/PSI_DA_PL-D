﻿using System;
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
    public partial class PrincipalForm : Form
    {
        private FuncionariosForm formFuncionarios;
        private ClientesForm formClientes;
        private InformacoesForm formInformacoes;
        private AtendimentoForm formAtendimento;
        private FilmesForm formFilmes;
        private SessoesForm formSessoes;

        
        public PrincipalForm()
        {
            InitializeComponent();

            //temos que fazer com que caso nao esteja logado entre em loop
            /* this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show(); */

        }

        /* Método para limpar os controlos do painel 1 */
        private void clearPanel()
        {
            panel1.Controls.Clear();
        }

        /* Fazemos isto para utilizar sempre a janela do Form1.
         * Ou seja, quando carregarmos na opção Clientes
         * Estaremos a colocar o formulário Clientes na GroupBox
         * Que por sua vez será apresentada na janela do Form1.
        */
        private void btAtendimento_Click(object sender, EventArgs e)
        {
            clearPanel();

            if (this.formAtendimento == null)
            {
                this.formAtendimento = new AtendimentoForm();
            }
            groupBoxSessoesDia.Visible = false;
            //Criar um controlodador Tab
            TabControl tabControl = new TabControl();

            //Definir o tamanho da tab - igual ao tamanho do panel1
            tabControl.Size = panel1.Size;

            //Adicionar controlador ao container - o tab
            this.panel1.Controls.Add(tabControl);

            //Abrir formulário de atendimento
            AtendimentoForm atendimento = new AtendimentoForm();

            //Definir página da tab - pela página do formulário
            TabPage tab = atendimento.getPage();

            //Adicionar a tab do formulário de atendimento no controlador Tab
            tabControl.TabPages.Add(tab);
            
            //chamar a segunda tab
            TabPage tab2 = atendimento.TabAtendimento.TabPages[0];
            tabControl.TabPages.Add(tab2);

        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            //Limpar painel
            clearPanel();

            //Se o formulário clientes ainda não foi aberto
            if (this.formClientes == null)
            {
                //Instanciar o formulário de clientes
                this.formClientes = new ClientesForm();
            }

            groupBoxSessoesDia.Visible = false;
            //Instancia GroupBox que irá corresponder ao GroupBox do formulário Clientes
            GroupBox groupBox = this.formClientes.MyGroupBox;

            //Definir o "Parent Container" da GroupBox - corresponde ao panel1
            groupBox.Parent = this.panel1;

            //Tornar a GroupBox visível
            groupBox.Visible = true;
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            clearPanel();
            if (this.formFuncionarios == null)
            {
                this.formFuncionarios = new FuncionariosForm();
            }

            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formFuncionarios.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            clearPanel();
            if (this.formFilmes == null)
            {
                this.formFilmes = new FilmesForm();
            }

            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formFilmes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btSessoes_Click(object sender, EventArgs e)
        {
            clearPanel();
            if (this.formSessoes == null)
            {
                this.formSessoes = new SessoesForm();
            }

            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formSessoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btInformacoes_Click(object sender, EventArgs e)
        {
            clearPanel();
            if (this.formInformacoes == null)
            {
                this.formInformacoes = new InformacoesForm();
            }

            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formInformacoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btPrincipal_Click(object sender, EventArgs e)
        {
            //Limpar painel
            clearPanel();
            groupBoxSessoesDia.Visible = true;
        }
    }
}
