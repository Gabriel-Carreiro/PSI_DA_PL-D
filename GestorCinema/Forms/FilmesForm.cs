using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorCinema
{
    public partial class FilmesForm : Form
    {
        public GroupBox MyGroupBox { get; set; }
        ApplicationContext applicationContext;
        List<Filme> filmes;
        List<Categoria> categorias;
        public FilmesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);

            //Ligação a base de dados
            applicationContext = new ApplicationContext();
            //Criar lista de filmes
            filmes = new List<Filme>();
            //Criar lista de categorias
            categorias = new List<Categoria>();
            //Pegar da base de dados na tabela Filmes adicionar a lista
            filmes = applicationContext.Filmes.ToList();
            //Colocar categorias que estão em BD na lista
            categorias = applicationContext.Categorias.ToList();


            //Pegar as categorias existentes e inserir nas ComboBox do formulario
            comboBox1.DisplayMember = "Nome";
            comboBox1.DataSource = new List<Categoria>(categorias);
            comboBox1.SelectedIndex = -1;
            cbCategoriaFilme.DisplayMember = "Nome";
            cbCategoriaFilme.DataSource = new List<Categoria>(categorias);
            cbCategoriaFilme.SelectedIndex = -1;
            btAlterarFilme.Visible = false;

        }

        private void btAdicionarFilme_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Nome = tbNomeFilme.Text;
            filme.Duracao = tbDuracaoFilme.Text;
            
            string estado = cbEstadoFilme.SelectedItem as string;
            if (estado == "Ativo")
            {
                filme.Estado = true;
            }
            else
            {
                filme.Estado = false;
            }

            filme.Categoria = categorias[cbCategoriaFilme.SelectedIndex];
            
            MessageBox.Show("Filme registado!");

            //adiciona o filme a lista filmes
            filmes.Add(filme);
            //adiciona o filme a base de dados
            applicationContext.Filmes.Add(filme);
            applicationContext.SaveChanges();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1) { return; }
            if (categorias[comboBox1.SelectedIndex].Estado == true)
            {
                btAlterarEstadoCategoria.Text = "Desativar";
            }
            else
            {
                btAlterarEstadoCategoria.Text = "Ativar";
            }
            
        }

        private void btAlterarEstadoCategoria_Click(object sender, EventArgs e)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Equals(categorias[comboBox1.SelectedIndex]))
                {
                    if (categoria.Estado == true)
                    {
                        categoria.Estado = false;
                        btAlterarEstadoCategoria.Text = "Ativar";
                    }
                    else
                    {
                        categoria.Estado = false;
                        btAlterarEstadoCategoria.Text = "Desativar";
                    }
                }
            }
            applicationContext.SaveChanges();
        }

        private void btMostarTodosFilmes_Click(object sender, EventArgs e)
        {
            LimparListView();
            foreach (Filme item in filmes)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Duracao);
                listViewItem.SubItems.Add(item.Categoria.Nome);
                listViewItem.SubItems.Add(item.Estado.ToString());

                listViewFilmes.Items.Add(listViewItem);
            }
        }

        private void btBuscarFilme_Click(object sender, EventArgs e)
        {
            string busca = tbBusca.Text.ToUpper();

            //Comparar a busca com os filmes e retornar uma lista com as respostas
            List<Filme> filmesEncontrados = filmes.FindAll(filme =>
                filme.Nome.ToUpper().Contains(busca) ||
                filme.Categoria.Nome.ToUpper().Equals(busca) ||
                filme.Estado.ToString().ToUpper().Equals(busca) ||
                filme.Id.ToString().Contains(busca)
            );
            LimparListView();

            //adicionar os filmes encontrados na listView
            foreach (Filme item in filmesEncontrados)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Duracao);
                listViewItem.SubItems.Add(item.Categoria.Nome);
                listViewItem.SubItems.Add(item.Estado.ToString());

                listViewFilmes.Items.Add(listViewItem);
            }
        }
        private void LimparListView()
        {
            while (listViewFilmes.Items.Count > 0)
            {
                listViewFilmes.Items.RemoveAt(0);
            }
        }

        private void listViewFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se existe algum item selecionado
            if (listViewFilmes.SelectedItems.Count > 0)
            {
                btAdicionarFilme.Visible = false;
                btAlterarFilme.Visible = true;
                //acessar o item selecionado
                ListViewItem selectedItem = listViewFilmes.SelectedItems[0];

                tbIdFilme.Text = selectedItem.SubItems[0].Text;
                tbNomeFilme.Text = selectedItem.SubItems[1].Text;
                tbDuracaoFilme.Text = selectedItem.SubItems[2].Text;
                cbCategoriaFilme.Text = selectedItem.SubItems[3].Text;
                cbEstadoFilme.Text = selectedItem.SubItems[4].Text;
            }
            else
            {
                // Limpa a label se nenhum item estiver selecionado
                tbIdFilme.Text = string.Empty;
                tbNomeFilme.Text = string.Empty; 
                tbDuracaoFilme.Text = string.Empty;
                cbCategoriaFilme.Text = string.Empty;
                cbEstadoFilme.Text = string.Empty;
                btAdicionarFilme.Visible = true;
                btAlterarFilme.Visible = false;
            }
        }

        private void btAlterarFilme_Click(object sender, EventArgs e)
        {

            //Busca o filme selecionado na lista de filmes
            Filme filmeEncontrado = filmes.Find(filme =>
                filme.Id.ToString().Equals(tbIdFilme.Text)
            );

            filmeEncontrado.Nome = tbNomeFilme.Text;
            filmeEncontrado.Duracao = tbDuracaoFilme.Text;

            string estado = cbEstadoFilme.SelectedItem as string;
            if (estado == "Ativo")
            {
                filmeEncontrado.Estado = true;
            }
            else
            {
                filmeEncontrado.Estado = false;
            }

            filmeEncontrado.Categoria = categorias[cbCategoriaFilme.SelectedIndex];

            MessageBox.Show("Filme alterado!");

            //adiciona o filme a base de dados
            applicationContext.SaveChanges();
        }
    }
}
