using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms.VisualStyles;

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
        private ClientesForm cadastro;
        private List<Bilhete> lugaresEscolhidos;

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
                item.SubItems.Add(cliente.BilhetesAdiquiridos.ToString());
                item.SubItems.Add(cliente.TotalGasto.ToString());

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
        private void SelecionarSala(Sessao sessao, Cliente cliente = null)
        {
            lugaresEscolhidos = new List<Bilhete>();
            labelTotal.Text = lugaresEscolhidos.Count.ToString();

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
                    string lugar = (char)(i + 65) + "" + (j + 1);
                    //Se lugar não estiver ocupado mostra a cadeira verde
                    if (bilhetes.FindAll(bilhete => bilhete.Lugar == lugar && bilhete.Sessao.Id == sessao.Id).Count == 0)
                    {
                        button.BackgroundImage = Image.FromFile("C:\\Users\\gabri\\OneDrive\\Documentos\\GitHub\\ProjetoDA\\GestorCinema\\cadeiraVerde.png");
                    }
                    //Se lugar estiver ocupado mostra a cadeira vermelha
                    else
                    {
                        button.BackgroundImage = Image.FromFile("C:\\Users\\gabri\\OneDrive\\Documentos\\GitHub\\ProjetoDA\\GestorCinema\\cadeira.png");
                    }
                    button.Click += delegate(object sender, EventArgs e) { LugarClicked(sender, e, sessao, cliente, lugaresEscolhidos); };
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
        private void LugarClicked(Object sender, EventArgs e, Sessao session, Cliente client, List<Bilhete> lugaresEscolhidos)
        {
            LugarButton button = (LugarButton)sender;
            string lugar = (char)(button.X + 65) + "" + (button.Y + 1);

            //Se o lugar estiver ocupado por alguém não poderá criar o bilhete
            if (bilhetes.FindAll(bilhete => bilhete.Lugar == lugar && bilhete.Sessao.Id == session.Id).Count > 0)
            {
                MessageBox.Show("Este lugar já está ocupado!");
            }
            else
            {
                // Se o cliente for anonimo
                if (client == null)
                {
                    //Pergunta se deseja criar um cadastro
                    DialogResult result = MessageBox.Show("Deseja criar um cadastro?", "Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cadastrarCliente();
                        clientes = applicationContext.Pessoas.OfType<Cliente>().ToList();
                        client = clientes.Last();
                    }
                    //Se nao quiser se cadastrar cria um bilhete sem cliente
                    else
                    {
                        Bilhete bilhete = new Bilhete(session, lugar);
                        if (!lugaresEscolhidos.Any(lugarEsc => lugarEsc.Lugar == lugar))
                        {
                            applicationContext.Bilhetes.Add(bilhete);
                            lugaresEscolhidos.Add(bilhete);
                            labelTotal.Text = "Total lugares: " + lugaresEscolhidos.Count.ToString();
                            labelLugares.Text += bilhete.Lugar + " ";
                        }
                        
                    }
                }
                //Se cliente nao for nulo cria um bilhete passando o cliente como parametro
                if (client != null)
                {
                    Bilhete bilhete = new Bilhete(session, lugar, client);

                    if (!lugaresEscolhidos.Any(lugarEsc => lugarEsc.Lugar == lugar))
                    {
                        applicationContext.Bilhetes.Add(bilhete);
                        lugaresEscolhidos.Add(bilhete);
                        labelTotal.Text = "Total lugares: " + lugaresEscolhidos.Count.ToString();
                        labelLugares.Text += bilhete.Lugar + " ";
                    }
                }

                atualizar_bilhetes();
                applicationContext.Pessoas.Load();

            }
        }

        private void cadastrarCliente()
        {
            this.cadastro = new ClientesForm();
            cadastro.ShowDialog();

        }

        //Método para exportar informação de bilhete para txt
        private void export_to_txt(List<Bilhete> bilhetes)
        {
            foreach(Bilhete bilhete in bilhetes)
            {
                if (bilhete.Cliente != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    // Define as opções do diálogo
                    saveFileDialog.FileName = "bilhete_" + bilhete.Cliente.Nome + ".txt";
                    saveFileDialog.Filter = "Arquivo de Texto|*.txt";

                    // Exibe o diálogo e verifica se o usuário pressionou o botão "Salvar"
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string information = "Cliente["
                            + bilhete.Cliente.Id.ToString()
                            + "]: "
                            + bilhete.Cliente.Nome
                            + "\tFilme["
                            + bilhete.Sessao.Filme.Id.ToString()
                            + "]: "
                            + bilhete.Sessao.Filme.Nome
                            + Environment.NewLine
                            + "Data: "
                            + bilhete.Sessao.DataHora.ToShortDateString()
                            + "\tHora: "
                            + bilhete.Sessao.DataHora.ToShortTimeString()
                            + Environment.NewLine
                            + "Sala["
                            + bilhete.Sessao.Sala.Id.ToString()
                            + "]: "
                            + bilhete.Sessao.Sala.Nome
                            + "\t\tLugar: "
                            + bilhete.Lugar
                            + Environment.NewLine
                            + "Funcionário[1]: Admin";

                        File.WriteAllText(filePath, information);
                        MessageBox.Show("Bilhete salvo com sucesso");
                    }
                }
                else
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    // Define as opções do diálogo
                    saveFileDialog.FileName = "bilhete_" + ".txt";
                    saveFileDialog.Filter = "Arquivo de Texto|*.txt";

                    // Exibe o diálogo e verifica se o usuário pressionou o botão "Salvar"
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string information = "Cliente[0]: Anonimo"
                            + "\tFilme["
                            + bilhete.Sessao.Filme.Id.ToString()
                            + "]: "
                            + bilhete.Sessao.Filme.Nome
                            + Environment.NewLine
                            + "Data: "
                            + bilhete.Sessao.DataHora.ToShortDateString()
                            + "\tHora: "
                            + bilhete.Sessao.DataHora.ToShortTimeString()
                            + Environment.NewLine
                            + "Sala["
                            + bilhete.Sessao.Sala.Id.ToString()
                            + "]: "
                            + bilhete.Sessao.Sala.Nome
                            + "\t\tLugar: "
                            + bilhete.Lugar
                            + Environment.NewLine
                            + "Funcionário[1]: Admin";

                        File.WriteAllText(filePath, information);
                        MessageBox.Show("Bilhete salvo com sucesso");
                    }
                }
            }
            
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
                SelecionarSala(sessao);
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

        private void list_clients_VisibleChanged(object sender, EventArgs e)
        {
            clean_clients();
            show_clients(clientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            applicationContext.SaveChanges();
            export_to_txt(lugaresEscolhidos);
            atualizar_bilhetes();
            applicationContext.Pessoas.Load();
            MessageBox.Show("Compra realizada");
            //Volta para a TabPage1
            control.SelectedIndex = 0;
        }
    }
}
