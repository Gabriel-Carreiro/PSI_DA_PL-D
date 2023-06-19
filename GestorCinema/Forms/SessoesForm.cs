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
    public partial class SessoesForm : Form
    {
        public GroupBox MyGroupBox { get; internal set; }

        private ApplicationContext applicationContext;
        private List<Filme> filmes;
        private List<Categoria> categorias;
        private List<Sala> salas;
        private List<Sessao> sessoes;

        public SessoesForm()
        {
            InitializeComponent();
            //Definir data mínima para a sessão - data atual
            time.MinDate = DateTime.Now;
            //Chamar método que mostra os possíveis horários para filmes
            show_schedules();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
            applicationContext = new ApplicationContext();
            //Criar lista de salas
            salas = applicationContext.Salas.ToList();
            //Criar lista para caregorias
            categorias = applicationContext.Categorias.ToList();
            //Criar lista para filmes em exibição
            filmes = applicationContext.Filmes.ToList().FindAll(filme => filme.Estado).ToList();

            //Colocar sessões na lista através de método
            atualizar_sessoes();

            //Colocar salas na list_rooms
            list_rooms.DisplayMember = ("Id");
            list_rooms.DataSource = new List<Sala>(salas);
            list_rooms.SelectedIndex = -1;
        }

        //Método para atualizar lista de sessões
        private void atualizar_sessoes()
        {
            limparSessoes();
            //Criar lista para sessões
            sessoes = applicationContext.Sessoes.ToList();
            //Colocar sessões na ListView
            foreach(Sessao sessao in sessoes)
            {
                ListViewItem item = new ListViewItem(sessao.Id.ToString());
                item.SubItems.Add(sessao.DataHora.ToShortDateString());
                item.SubItems.Add(sessao.DataHora.ToShortTimeString());
                item.SubItems.Add(sessao.Filme.Estado.ToString());
                item.SubItems.Add(sessao.Filme.Nome.ToString());
                item.SubItems.Add(sessao.Sala.ToString());

                list_sessions.Items.Add(item);
            }
        }

        //Método para limpar lista de sessões
        private void limparSessoes()
        {
            while(list_sessions.Items.Count > 0)
            {
                list_sessions.Items.RemoveAt(0);
            }
        }

        //Método para mostrar possíveis horários das sessões
        private void show_schedules()
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            TimeSpan inc = new TimeSpan(1, 0, 0);

            do {
                horarios.Items.Add(timeSpan.ToString().Substring(0, 5));
                timeSpan += inc;

            } while (timeSpan < TimeSpan.FromHours(24));
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            //Limpar listView
            LimparListView();

            //Colocar filmes ativos na listView
            insert_films(filmes);
        }

        //Método para limpar ListView de filmes
        private void LimparListView()
        {
            while (list_films.Items.Count > 0)
            {
                list_films.Items.RemoveAt(0);
            }
        }

        //Converter estado para string
        private string converter_estado(Boolean estado)
        {
            switch (estado)
            {
                case true:
                    return "Ativo";
                    break;
                case false:
                    return "Desativo";
                    break;
                default:
                    MessageBox.Show("Estado inválido!");
                    return null;
                    break;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LimparListView();

            string search = search_by.SelectedItem.ToString();
            string search_for = txt_search.Text;
            List<Filme> found_films = new List<Filme>();

            switch (search)
            {
                case "Id do Filme":
                    try
                    {
                        found_films = filmes.FindAll(filme => filme.Id == int.Parse(search_for));
                    }
                    catch
                    {
                        MessageBox.Show("ERRO ao buacar id");
                    }
                    break;
                case "Nome":
                    try
                    {
                        search_for = search_for.ToUpper();
                        found_films = filmes.FindAll(filme => filme.Nome.ToUpper().Contains(search_for));
                        if(found_films.Count < 1)
                        {
                            MessageBox.Show("Nome nao encontrado");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ERRO ao buacar nome");
                    }
                    break;
                case "Categoria":
                    try
                    {
                        search_for = search_for.ToUpper();
                        found_films = filmes.FindAll(filme => filme.Categoria.Nome.ToUpper().Contains(search_for));
                        if (found_films.Count < 1)
                        {
                            MessageBox.Show("Categoria nao encontrada");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ERRO ao buacar categoria");
                    }
                    break;
                default:
                    MessageBox.Show("Opção inválida!");
                    LimparListView();
                    break;
            }

            insert_films(found_films);
        }

        //Método para adicionar filmes à listView
        private void insert_films(List<Filme> films_insert)
        {
            //Colocar filmes ativos na listView
            foreach (Filme filme in films_insert)
            {
                ListViewItem item = new ListViewItem(filme.Id.ToString());
                item.SubItems.Add(filme.Nome);
                item.SubItems.Add(filme.Duracao);
                item.SubItems.Add(filme.Categoria.Nome);
                item.SubItems.Add(converter_estado(filme.Estado));

                //Adicionar filme da listView
                //id, nome, duração e categoria são subitems do item filme
                list_films.Items.Add(item);
            }
        }

        //Método para criar sessão
        private void btn_create_Click(object sender, EventArgs e)
        {
            /* Para criar uma sessão é necessário:
             * - Filme
             * - Sala
             * - Preço
             * - Data
             * - Hora
            */
            if(
                (list_films.SelectedItems.Count == 1) &&
                (!string.IsNullOrEmpty(list_rooms.Text)) &&
                (!string.IsNullOrEmpty(txt_preco.Text)) &&
                (time.Value != null) &&
                (!string.IsNullOrEmpty(horarios.Text))
                )
            {
                //Instanciar filme através do Id que foi selecionado na lista
                Filme filme = filmes.Find(film => film.Id == int.Parse(list_films.SelectedItems[0].Text));
                //Instanciar sala através do Id que foi selecionado na lista
                Sala sala = salas.Find(room => room.Id == int.Parse(list_rooms.Text));
                //Ir buscar a data e hora para a sessão
                //string data = time.Value.ToString().Substring(0, 10) + " " + horarios.Text;
                DateTime dataHora = DateTime.Parse(time.Value.ToString().Substring(0, 10) + " " + horarios.Text.TrimStart());

                /* Criar sessão apenas se não existir uma sessão
                 * à mesma hora e na mesma sala.
                */
                if(sessoes.FindAll(section => (section.Sala.Id == sala.Id) && (section.DataHora == dataHora)).Count > 0)
                {
                    MessageBox.Show("Já existe uma sessão nesta sala à hora que pretende");
                }
                else
                {
                    //Criar sessão
                    Sessao sessao = new Sessao(dataHora, float.Parse(txt_preco.Text), filme, sala);
                    applicationContext.Sessoes.Add(sessao);
                    applicationContext.SaveChanges();

                    MessageBox.Show("Sessão criada!");
                }
            }
            else
            {
                MessageBox.Show("Faltam informações!");
            }
            atualizar_sessoes();
            list_rooms.Text = null;
            list_films.Items.Clear();
        }
    }
}
