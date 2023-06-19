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
        private List<Filme> filmes;
        private List<Sala> salas;
        private List<Cliente> clientes;
        private List<Sessao> sessoes;
        private List<Bilhete> bilhetes;
        private TabControl control;

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

            //Chamar método para atualizar bilhetes
            atualizar_bilhetes();
            //Chamar método para mostrar filmes
            show_films();
            //Chamar método para mostrar clientes
            show_clients(clientes);
        }

        //Método para colocar clientes na listView
        private void show_clients(List<Cliente> clientes_esc)
        {
            foreach(Cliente cliente in clientes_esc)
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
        private void SelecionarSala(Sessao sessao, Cliente cliente)
        {

            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = sessao.Sala.Filas;
            tableLayoutPanel1.ColumnCount = sessao.Sala.Colunas;
            
            for (int i = 0; i < sessao.Sala.Colunas; i++)
            {

                for (int j = 0; j < sessao.Sala.Filas; j++)
                {
                    Button button = new LugarButton(i, j);
                    button.Size = new Size(70,50);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.BackgroundImage = Image.FromFile("E:\\OneDrive - IPLeiria\\1º Ano\\S2\\Desenvolvimento de Aplicações\\Projeto\\ProjetoDA\\GestorCinema\\cadeira.png");
                    button.Click += delegate(object sender, EventArgs e) { LugarClicked(sender, e, sessao, cliente); };
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
            tableLayoutPanel1.ResumeLayout();

            control = tabPage1.Parent as TabControl;
            control.SelectedIndex = 1;

        }

        internal TabPage getPage()
        {
            return TabAtendimento.TabPages[0];
        }

        //Captura as cordenadas do botao que foi carregado
        private void LugarClicked(Object sender, EventArgs e, Sessao session, Cliente client)
        {
            LugarButton button = (LugarButton)sender;
            MessageBox.Show("X: " + button.X + " Y: " + button.Y);
            string lugar = (char)(button.X + 65) + "" + (button.Y + 1);

            //Se o lugar estiver ocupado por alguém não poderá criar o bilhete
            if (bilhetes.FindAll(bilhete => bilhete.Sessao == session).ToList().Count > 0)
            {
                MessageBox.Show("Este lugar já está ocupado!");
            }
            else
            {
                Bilhete bilhete = new Bilhete(session, lugar, client);

                applicationContext.Bilhetes.Add(bilhete);
                applicationContext.SaveChanges();
                MessageBox.Show("Bilhete Criado");
                atualizar_bilhetes();
            }
            //Volta para a TabPage1
            control.SelectedIndex = 0;
        }

        //Método para atualizar lista de bilhetes
        private void atualizar_bilhetes()
        {
            //Criar lista para bilhetes
            bilhetes = applicationContext.Bilhetes.ToList();
        }

        //Caso o cliente nao queira usar sua conta
        private void btClienteAnonimo_Click(object sender, EventArgs e)
        {
            //Cliente anonimo apenas é necessário haver uma sessão selecionada
            if(list_sessions.SelectedItems.Count == 1)
            {
                Sessao sessao = sessoes.Find(session => session.Id == int.Parse(list_sessions.SelectedItems[0].Text));
                SelecionarSala(sessao,new Cliente());
            }
        }

        //Caso o cliente queira usar a conta
        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            //Para selecionar o cliente é necessário ter o cliente da lista selecionado e a sessão
            if(
                (list_sessions.SelectedItems.Count == 1) &&
                (list_clients.SelectedItems.Count == 1)
            )
            {
                Sessao sessao = sessoes.Find(session => session.Id == int.Parse(list_sessions.SelectedItems[0].Text));
                Cliente cliente = clientes.Find(client => client.Id == int.Parse(list_clients.SelectedItems[0].Text));
                SelecionarSala(sessao, cliente);
            }

        }

        //Método para limpar listView de sessões
        private void clean_sessions()
        {
            while(list_sessions.Items.Count > 0)
            {
                list_sessions.Items.RemoveAt(0);
            }
        }

        //Método para limpar listView de clientes
        private void clean_clients()
        {
            while (list_clients.Items.Count > 0)
            {
                list_clients.Items.RemoveAt(0);
            }
        }

        //Quando for selecionado um filme, mostrar a lista de sessões para esse filme na data escolhida
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

        //Pesquisar por clientes
        private void search_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(search_for.Text))
            {
                List<Cliente> clientesEncontrados = clientes.FindAll(cliente =>
                cliente.Id.ToString().Contains(search_for.Text) ||
                cliente.Nome.ToLower().Equals(search_for.Text) ||
                cliente.Nif.Equals(search_for.Text) ||
                cliente.Telefone.Equals(search_for.Text) ||
                cliente.Morada.ToLower().Equals(search_for.Text)
                );

                clean_clients();

                show_clients(clientesEncontrados);
            }
            else
            {
                MessageBox.Show("Nada para pesquisar.");
            }
        }
    }
}
