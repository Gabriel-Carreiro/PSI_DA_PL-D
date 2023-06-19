using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    public partial class AtendimentoForm : Form
    {
        private ApplicationContext applicationContext;
        List<Filme> filmes;
        List<Sala> salas;
        List<Cliente> clientes;
        List<Sessao> sessoes;

        public AtendimentoForm()
        {
            InitializeComponent();
            applicationContext = new ApplicationContext();

            //Criar lista de filmes em exibição
            filmes = applicationContext.Filmes.ToList().FindAll(filme => filme.Estado).ToList();
            //Criar lista de salas
            salas = applicationContext.Salas.ToList();
            //Criar lista de clientes
            clientes = applicationContext.Pessoas.OfType<Cliente>().ToList();
            //Criar lista para sessões
            sessoes = applicationContext.Sessoes.ToList();

            show_films();
            //Chamar método para mostrar clientes
            show_clients();
        }

        //Método para colocar clientes na listView
        private void show_clients()
        {
            foreach(Cliente cliente in clientes)
            {
                ListViewItem item = new ListViewItem(cliente.Id.ToString());
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(cliente.Nif);
                item.SubItems.Add(cliente.Telefone);
                item.SubItems.Add(cliente.Morada);

                list_clients.Items.Add(item);
            }
        }

        // Método para colocar filmes na list_films
        private void show_films()
        {
            list_films.DisplayMember = "Nome";
            list_films.DataSource = new List<Filme>(filmes);
            list_films.SelectedIndex = -1;
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
                    button.BackgroundImage = Image.FromFile("E:\\OneDrive - IPLeiria\\1º Ano\\S2\\Desenvolvimento de Aplicações\\Projeto\\ProjetoDA\\GestorCinema\\cadeira.png");
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

        //Método para limpar listView de sessões
        private void clean_sessions()
        {
            while(list_sessions.Items.Count > 0)
            {
                list_sessions.Items.RemoveAt(0);
            }
        }

        private void list_films_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("here");
            if (list_films.SelectedIndex != -1)
            {
                clean_sessions();
                List<Sessao> sessoes_sel = sessoes.FindAll(sessao => (sessao.DataHora.Date == date.Value.Date) && (sessao.Filme.Nome == list_films.Text)).ToList();

                foreach(Sessao sessao  in sessoes_sel)
                {
                    ListViewItem item = new ListViewItem(sessao.Id.ToString());
                    item.SubItems.Add(sessao.DataHora.ToShortTimeString());
                    item.SubItems.Add(sessao.Sala.Nome.ToString());
                    item.SubItems.Add(sessao.Preco.ToString());

                    list_sessions.Items.Add(item);
                }
            }
        }
    }
}
