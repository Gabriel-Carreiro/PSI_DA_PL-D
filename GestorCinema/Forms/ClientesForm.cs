using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            //Comparar o nif digitado com os clientes já cadastrados e retorna true caso o nif esteja em uso
            bool clienteEncontrado = clientes.Exists(cliente =>
                cliente.Nif.Equals(tbNif.Text)
            );
            if (clienteEncontrado)
            {
                MessageBox.Show("Nif já cadastrado");
                return;
            }

            // Cria o cliente usando o construtor
            Cliente clienteNovo = new Cliente(tbNome.Text, tbMorada.Text, tbNif.Text, tbTelefone.Text);

            //adiciona o cliente a lista clientes
            clientes.Add(clienteNovo);
            //adiciona o cliente a base de dados
            applicationContext.Pessoas.Add(clienteNovo);
            applicationContext.SaveChanges();
            applicationContext.Pessoas.Load();
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

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se existe algum item selecionado
            if (listViewClientes.SelectedItems.Count > 0)
            {
                btSalvarCliente.Visible = false;
                btAtualizarCliente.Visible = true;
                //acessar o item selecionado
                ListViewItem selectedItem = listViewClientes.SelectedItems[0];

                tbId.Text = selectedItem.SubItems[0].Text;
                tbNome.Text = selectedItem.SubItems[1].Text;
                tbNif.Text = selectedItem.SubItems[2].Text;
                tbTelefone.Text = selectedItem.SubItems[3].Text;
                tbMorada.Text = selectedItem.SubItems[4].Text;
            }
            else
            {
                // Limpa a label se nenhum item estiver selecionado
                LimparFormulario();
                btSalvarCliente.Visible = true;
                btAtualizarCliente.Visible = false;
            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {

            //Busca o cliente selecionado na lista de clientes
            Cliente clienteEncontrado = clientes.Find(cliente =>
                cliente.Id.ToString().Equals(tbId.Text)
            );

            clienteEncontrado.Nome = tbNome.Text;
            clienteEncontrado.Telefone = tbTelefone.Text;
            clienteEncontrado.Morada = tbMorada.Text;
            // Confere se o nif antigo é igual ao novo, caso seja igual nao faz nada
            if(clienteEncontrado.Nif != tbNif.Text)
            {
                //Comparar o nif digitado com os clientes já cadastrados e retorna true caso o nif esteja em uso
                bool clienteRepetido = clientes.Exists(cliente =>
                    cliente.Nif.Equals(tbNif.Text)
                );
                // Caso tenha um cliente com o mesmo nif apresenta mensagem de erro
                if (clienteRepetido)
                {
                    MessageBox.Show("Nif já cadastrado");
                    return;
                }
                // Caso nao tenha cliente com o mesmo nif atualiza o valor
                else
                {
                    clienteEncontrado.Nif = tbNif.Text;
                }
            }
            
            MessageBox.Show("Cliente alterado!");

            //atualizar o cliente na base de dados
            applicationContext.SaveChanges();
            applicationContext.Pessoas.Load();
            LimparListView();
        }
    }
}
