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
    public partial class Clientes : Form
    {
        public GroupBox MyGroupBox { get; private set; }
        ApplicationContext applicationContext;
        List<Cliente> clientes;

        public Clientes()
        {
            InitializeComponent();
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
            applicationContext = new ApplicationContext();
            clientes = new List<Cliente>();
            clientes = applicationContext.Pessoas.OfType<Cliente>().ToList();
            
        }

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = tbNome.Text;
            cliente.Morada = tbMorada.Text;
            cliente.Telefone = tbTelefone.Text;
            cliente.Nif = tbNif.Text;
            clientes.Add(cliente);
            applicationContext.Pessoas.Add(cliente);
            applicationContext.SaveChanges();
            MessageBox.Show("cliente salvo");
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            tbId.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbMorada.Text = string.Empty;
            tbNif.Text = string.Empty;
            tbTelefone.Text = string.Empty;
        }
        private void LimparListView()
        {
            while (listViewClientes.Items.Count > 0)
            {
                listViewClientes.Items.RemoveAt(0);
            }
        }

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

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            string busca = tbBuscaCliente.Text.ToUpper();

            List<Cliente> clientesEncontrados = clientes.FindAll(cliente =>
                cliente.Nome.ToUpper().Contains(busca) ||
                cliente.Telefone.Equals(busca) ||
                cliente.Nif.Equals(busca) ||
                cliente.Id.ToString().Contains(busca)
            );
            LimparListView();
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
    }
}
