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
        private Cinema cinema;
        private List<Filme> filmes;
        private List<Categoria> categorias;
        private List<Sala> salas;

        public SessoesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
            applicationContext = new ApplicationContext();
            //Criar lista de salas
            salas = applicationContext.Salas.ToList();
            //Criar lista de salas do cinema em utilização
            cinema = applicationContext.Cinema.First();
            salas = cinema.Salas;
            //Criar lista para caregorias
            categorias = applicationContext.Categorias.ToList();
            //Criar lista para filmes em exibição
            filmes = applicationContext.Filmes.ToList().FindAll(filme => filme.Estado).ToList();       

            //Colocar salas na list_rooms
            list_rooms.DisplayMember = ("Nome");
            list_rooms.DataSource = new List<Sala>(salas);
            list_rooms.SelectedIndex = -1;
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
                    found_films = filmes.FindAll(filme => filme.Id == int.Parse(search_for));
                    break;
                case "Nome":
                    found_films = filmes.FindAll(filme => filme.Nome == search_for);
                    break;
                case "Categoria":
                    found_films = filmes.FindAll(filme => filme.Categoria.Nome == search_for);
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
    }
}
