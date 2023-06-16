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

        public SessoesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
            applicationContext = new ApplicationContext();
            //Criar lista para categorias
            categorias = applicationContext.Categorias.ToList();
            //Criar lista para filmes em exibição
            filmes = applicationContext.Filmes.ToList().FindAll(filme => filme.Estado).ToList();

        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            //Limpar listView
            LimparListView();

            //Colocar filmes ativos na listView
            foreach(Filme filme in filmes)
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
    }
}
