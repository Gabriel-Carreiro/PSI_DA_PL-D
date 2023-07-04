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
    public partial class PrincipalForm : Form
    {
        private FuncionariosForm formFuncionarios;
        private ClientesForm formClientes;
        private InformacoesForm formInformacoes;
        private AtendimentoForm formAtendimento;
        private FilmesForm formFilmes;
        private SessoesForm formSessoes;
        private List<Sessao> sessoes;
        private List<Filme> filmes;
        private List<Categoria> categorias;
        private List<Sala> salas;
        private List<Funcionario> funcionarios;
        private ApplicationContext applicationContext;
        private Funcionario FuncionarioLogado;


        public PrincipalForm()
        {
            InitializeComponent();

            //Form do Login
            /*   this.Hide();
               LoginForm login = new LoginForm();
               login.ShowDialog();
               this.Show();*/

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
            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formAtendimento?.Close();

            this.formAtendimento = new AtendimentoForm();

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

            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formClientes?.Close();

            //Instanciar o formulário de clientes
            this.formClientes = new ClientesForm();
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
            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formFuncionarios?.Close();

            this.formFuncionarios = new FuncionariosForm();

            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formFuncionarios.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            clearPanel();
            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formFilmes?.Close();
           
            this.formFilmes = new FilmesForm();


            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formFilmes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btSessoes_Click(object sender, EventArgs e)
        {
            clearPanel();
            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formSessoes?.Close();

            this.formSessoes = new SessoesForm();


            groupBoxSessoesDia.Visible = false;
            GroupBox groupBox = this.formSessoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void btInformacoes_Click(object sender, EventArgs e)
        {
            clearPanel();
            //Se o formulário já existe fecha para que nao mantenha dados desatualizados e para nao criar forms repetidos
            this.formInformacoes?.Close();

            this.formInformacoes = new InformacoesForm();

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

        private void listViewFilmes_VisibleChanged(object sender, EventArgs e)
        {
            //limpar sessoes
            while (listViewFilmes.Items.Count > 0)
            {
                listViewFilmes.Items.RemoveAt(0);
            }
            //Iniciar o applicationContext e criar lista para sessões
            applicationContext = new ApplicationContext();
            sessoes = applicationContext.Sessoes.ToList();
            //Criar lista para filmes em exibição, categorias e salas
            filmes = applicationContext.Filmes.ToList().FindAll(filme => filme.Estado).ToList();
            categorias = applicationContext.Categorias.ToList();
            salas = applicationContext.Salas.ToList();


            //Colocar sessões na ListView
            foreach (Sessao sessao in sessoes)
            {
                if (sessao.DataHora.Date == DateTime.Now.Date){
                    ListViewItem item = new ListViewItem(sessao.Id.ToString());
                    item.SubItems.Add(sessao.Filme.Nome.ToString());
                    item.SubItems.Add(sessao.Filme.Duracao);
                    item.SubItems.Add(sessao.Filme.Categoria.Nome.ToString());
                    item.SubItems.Add(sessao.Filme.Estado.ToString());
                    item.SubItems.Add(sessao.Sala.ToString());
                    item.SubItems.Add(sessao.DataHora.ToShortTimeString());

                    listViewFilmes.Items.Add(item);
                }
            }
        }

        private void btComprarBilhete_Click(object sender, EventArgs e)
        {
            btAtendimento_Click(sender, e);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            // Limpar a ToolStripDropDownButton
            toolStripDropDownButton1.DropDownItems.Clear();

            //Iniciar o applicationContext e criar lista de funcionarios
            applicationContext = new ApplicationContext();
            funcionarios = applicationContext.Pessoas.OfType<Funcionario>().ToList();

            // Adicionar cada funcionário como uma opção
            foreach (Funcionario funcionario in funcionarios)
            {
                // Criar um item ToolStripMenuItem com o nome do funcionário
                ToolStripMenuItem item = new ToolStripMenuItem(funcionario.Nome);
                
                funcionario.Logado = false;
                
                // Alterar o usuario
                item.Click += (menuItemSender, menuItemEvent) =>
                {
                    toolStripStatusLabelUsuario.Text = funcionario.Nome;
                    funcionario.Logado = true;
                    MessageBox.Show($"Utilizador alterado para: {funcionario.Nome}");
                    
                };

                toolStripDropDownButton1.DropDownItems.Add(item);
            }
        }
    }
}
