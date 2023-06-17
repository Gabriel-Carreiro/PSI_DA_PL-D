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
    public partial class InformacoesForm : Form
    {
        public GroupBox MyGroupBox { get; set; }
        ApplicationContext applicationContext;
        Cinema cinemaDB;
        Cinema cinema;
        public InformacoesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);

            //Se a base de dados existe, busca o cinema e mostra suas informaçoes
            if (DatabaseExists())
            {
                //Ligação a base de dados
                applicationContext = new ApplicationContext();

                //mostra a area de criação e edição de salas
                tabControlSalas.Visible = true;
                
                atualizarForm();
            }

        }

        private void atualizarForm()
        {
            //Pegar da base de dados na tabela Cinema
            cinemaDB = applicationContext.Cinema.First();
            //Pegar da base de dados a lista de salas
            List<Sala> salas = new List<Sala>();
            salas = applicationContext.Salas.ToList();

            //Mostrar as informaçoes atuais sobre o cinema
            tBNomeCinema.Text = cinemaDB.Nome;
            tBMoradaCinema.Text = cinemaDB.Morada;
            tBEmailCinema.Text = cinemaDB.Email;
            numeroSalas.Text = cinemaDB.numSalas.ToString();

            numeroSala.DataSource = salas;
            numeroSala.DisplayMember = "Nome";

            //Pega a ultima sala da lista e adiciona 1 para ser o Id da nova sala que sera criada
            novaSala.Text = (int.Parse(salas.Last().ToString()) + 1).ToString();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(DatabaseExists())
            {
                //Ligação a base de dados
                applicationContext = new ApplicationContext();

                //Pegar da base de dados na tabela Cinema
                cinemaDB = applicationContext.Cinema.First();

                cinemaDB.Nome = tBNomeCinema.Text;
                cinemaDB.Morada = tBMoradaCinema.Text;
                cinemaDB.Email = tBEmailCinema.Text;

                applicationContext.SaveChanges();
                MessageBox.Show("Alterações salvas com sucesso");
                atualizarForm();
            }
            else
            {
                //Ligação a base de dados
                applicationContext = new ApplicationContext();
                cinema = new Cinema();

                Sala sala = new Sala(1, 5, 5);
                applicationContext.Salas.Add(sala);

                cinema.Nome = tBNomeCinema.Text;
                cinema.Morada = tBMoradaCinema.Text;
                cinema.Email = tBEmailCinema.Text;
                cinema.AdicionarSala();
                applicationContext.Cinema.Add(cinema);
                applicationContext.SaveChanges();
                MessageBox.Show("O cinema foi criado com uma sala padrao de 5x5");
            }

            this.DialogResult = DialogResult.OK;
        }
        private bool DatabaseExists()
        {
            using (var context = new ApplicationContext())
            {
                return context.Database.Exists();
            }
        }

        private void buttonCriarSala_Click(object sender, EventArgs e)
        {
            cinemaDB = applicationContext.Cinema.First();
            Sala sala = new Sala();
            
            sala.Nome = int.Parse(novaSala.Text);
            sala.Colunas = Convert.ToInt32(numeroColunaCriar.Value);
            sala.Filas = Convert.ToInt32(numeroFilaCriar.Value);
            
            //Chama a funçao para adicionar a sala no cinema
            cinemaDB.AdicionarSala();

            applicationContext.Salas.Add(sala);
            applicationContext.SaveChanges();
            MessageBox.Show("Sala criada");
            atualizarForm();
        }

        private void numeroSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sala sala = (Sala)numeroSala.SelectedItem;
            numeroFilaEditar.Value = sala.Filas;
            numeroColunaEditar.Value = sala.Colunas;
        }

        private void buttonEditarSala_Click(object sender, EventArgs e)
        {
            Sala sala = (Sala)numeroSala.SelectedItem;
            sala.Filas = Convert.ToInt32(numeroFilaEditar.Value);
            sala.Colunas = Convert.ToInt32(numeroColunaEditar.Value);
            applicationContext.SaveChanges();
            MessageBox.Show("Sala editada com sucesso");
            atualizarForm();
        }

        private void buttonExcluirSala_Click(object sender, EventArgs e)
        {
            Sala sala = (Sala)numeroSala.SelectedItem;
            cinemaDB = applicationContext.Cinema.First();

            DialogResult resultado = MessageBox.Show("Deseja excluir essa sala?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                applicationContext.Salas.Remove(sala);
                cinemaDB.ExcluirSala();
                applicationContext.SaveChanges();
                MessageBox.Show("Sala excluida com sucesso");
                atualizarForm();
            }
        }
    }
}
