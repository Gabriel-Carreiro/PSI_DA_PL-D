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
    public partial class ClientesForm : Form
    {
        public GroupBox MyGroupBox { get; private set; }
        ApplicationContext applicationContext;

        //Lista de clientes
        List<Cliente> clientes;

        public ClientesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);

            //Ligação a base de dados
            applicationContext = new ApplicationContext();
            //Criar lista de clientes
            clientes = new List<Cliente>();
            //Pegar da base de dados na tabela Pessoas somente os que forem type Cliente e adicionar a lista
            clientes = applicationContext.Pessoas.OfType<Cliente>().ToList();
            
        }

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = tbNome.Text;
            cliente.Morada = tbMorada.Text;
            cliente.Telefone = tbTelefone.Text;
            cliente.Nif = tbNif.Text;

            //adiciona o cliente a lista clientes
            clientes.Add(cliente);
            //adiciona o cliente a base de dados
            applicationContext.Pessoas.Add(cliente);
            applicationContext.SaveChanges();
            MessageBox.Show("cliente salvo");
            LimparFormulario();
        }

        //Mostra os clientes na listView
        private void btMostrarTodosClientes_Click(object sender, EventArgs e)
        {
            LimparListView();
            foreach (Cliente item in clientes)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Nif);
                listViewItem.SubItems.Add(item.Telefone);
                listViewItem.SubItems.Add(item.Morada);
                listViewItem.SubItems.Add(item.BilhetesAdiquiridos.ToString());
                listViewItem.SubItems.Add(item.TotalGasto.ToString());

                listViewClientes.Items.Add(listViewItem);
            }
        }

        //Busca o cliente por nome ou telefone ou nif ou id
        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            string busca = tbBuscaCliente.Text.ToUpper();
            
            //Comparar a busca com os clientes e retornar uma lista com as respostas
            List<Cliente> clientesEncontrados = clientes.FindAll(cliente =>
                cliente.Nome.ToUpper().Contains(busca) ||
                cliente.Telefone.Equals(busca) ||
                cliente.Nif.Equals(busca) ||
                cliente.Id.ToString().Contains(busca)
            );
            LimparListView();

            //adicionar os clientes encontrados na listView
            foreach (Cliente item in clientesEncontrados)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Nif);
                listViewItem.SubItems.Add(item.Telefone);
                listViewItem.SubItems.Add(item.Morada);
                listViewItem.SubItems.Add(item.BilhetesAdiquiridos.ToString());
                listViewItem.SubItems.Add(item.TotalGasto.ToString());

                listViewClientes.Items.Add(listViewItem);
            }
        }

        //Método para limpar o formulário de clientes
        private void LimparFormulario()
        {
            tbId.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbMorada.Text = string.Empty;
            tbNif.Text = string.Empty;
            tbTelefone.Text = string.Empty;
        }
        //Método para limpar a lista de Clientes
        private void LimparListView()
        {
            while (listViewClientes.Items.Count > 0)
            {
                listViewClientes.Items.RemoveAt(0);
            }
        }

    }
}
