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

namespace GestorCinema
{
    public partial class FuncionariosForm : Form
    {
        public GroupBox MyGroupBox { get; private set; }
        ApplicationContext applicationContext;
        List<Funcionario> funcionarios;
        public FuncionariosForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBoxFuncionarios;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);


            //Ligação a base de dados
            applicationContext = new ApplicationContext();
            //Criar lista de funcionarios
            funcionarios = new List<Funcionario>();
            //Pegar da base de dados na tabela Pessoas somente os que forem type Funcionario e adicionar a lista
            funcionarios = applicationContext.Pessoas.OfType<Funcionario>().ToList();


        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            //Comparar o nif digitado com os funcionarios já cadastrados e retorna true caso o nif esteja em uso
            bool FuncionarioEncontrado = funcionarios.Exists(funcionario =>
                funcionario.Nif.Equals(tbNif.Text)
            );
            if (FuncionarioEncontrado)
            {
                MessageBox.Show("Nif já cadastrado");
                return;
            }

            // *****************ATENÇAO ALTERAR O LOGIN E SENHA************************
            Funcionario funcionarioNovo = new Funcionario(tbNome.Text,tbNif.Text, tbMorada.Text, tbTelefone.Text,tbSalario.Text,tbCargo.Text,tbNome.Text,"1234");

            //adiciona o funcionario a lista funcionarios
            funcionarios.Add(funcionarioNovo);
            //adiciona o funcionario a base de dados
            applicationContext.Pessoas.Add(funcionarioNovo);
            applicationContext.SaveChanges();
            applicationContext.Pessoas.Load();
            MessageBox.Show("Funcionario salvo");
            LimparFormulario();
        }
        
        //Método para limpar o formulário de funcionarios
        private void LimparFormulario()
        {
            tbId.Text = string.Empty;
            tbCargo.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbMorada.Text = string.Empty;
            tbNif.Text = string.Empty;
            tbTelefone.Text = string.Empty;
            tbSalario.Text = string.Empty;
        }
        //Método para limpar a lista de funcionarios
        private void LimparListView()
        {
            while (listViewFuncionarios.Items.Count > 0)
            {
                listViewFuncionarios.Items.RemoveAt(0);
            }
        }

        // Mostrar todos os funcionarios na listView
        private void btMostrarTodos_Click(object sender, EventArgs e)
        {
            LimparListView();
            foreach (Funcionario item in funcionarios)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Funcao);
                listViewItem.SubItems.Add(item.Nif);
                listViewItem.SubItems.Add(item.Telefone);
                listViewItem.SubItems.Add(item.Morada);
                listViewItem.SubItems.Add(item.Salario);
                listViewItem.SubItems.Add(item.DataContratacao.ToString());

                listViewFuncionarios.Items.Add(listViewItem);
            }
        }

        //Busca o funcionario por nome ou telefone ou nif ou id
        private void btBuscarFuncionario_Click(object sender, EventArgs e)
        {
            string busca = tbBusca.Text.ToUpper();

            //Comparar a busca com os funcionarios e retornar uma lista com as respostas
            List<Funcionario> funcionariosEncontrados = funcionarios.FindAll(funcionario =>
                funcionario.Nome.ToUpper().Contains(busca) ||
                funcionario.Telefone.Equals(busca) ||
                funcionario.Nif.Equals(busca) ||
                funcionario.Id.ToString().Contains(busca)
            );
            LimparListView();

            //adicionar os funcionarios encontrados na listView
            foreach (Funcionario item in funcionariosEncontrados)
            {
                var listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Nome);
                listViewItem.SubItems.Add(item.Funcao);
                listViewItem.SubItems.Add(item.Telefone);
                listViewItem.SubItems.Add(item.Nif);
                listViewItem.SubItems.Add(item.Morada);
                listViewItem.SubItems.Add(item.DataContratacao.ToString());

                listViewFuncionarios.Items.Add(listViewItem);
            }
        }

        private void listViewFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            //verificar se existe algum item selecionado
            if (listViewFuncionarios.SelectedItems.Count > 0)
            {
                btRegistar.Visible = false;
                btAlterar.Visible = true;
                //acessar o item selecionado
                ListViewItem selectedItem = listViewFuncionarios.SelectedItems[0];

                tbId.Text = selectedItem.SubItems[0].Text;
                tbNome.Text = selectedItem.SubItems[1].Text;
                tbCargo.Text = selectedItem.SubItems[2].Text;
                tbNif.Text = selectedItem.SubItems[3].Text;
                tbTelefone.Text = selectedItem.SubItems[4].Text;
                tbMorada.Text = selectedItem.SubItems[5].Text;
                tbSalario.Text = selectedItem.SubItems[6].Text;
            }
            else
            {
                // Limpa a label se nenhum item estiver selecionado
                LimparFormulario();

                btRegistar.Visible = true;
                btAlterar.Visible = false;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Busca o funcionario selecionado na lista de funcionarios
            Funcionario funcionarioEncontrado = funcionarios.Find(funcionario =>
                funcionario.Id.ToString().Equals(tbId.Text)
            );

            funcionarioEncontrado.Funcao = tbCargo.Text;
            funcionarioEncontrado.Nome = tbNome.Text;
            funcionarioEncontrado.Telefone = tbTelefone.Text;
            funcionarioEncontrado.Morada = tbMorada.Text;
            funcionarioEncontrado.Salario = tbSalario.Text;
            // Confere se o nif antigo é igual ao novo, caso seja igual nao faz nada
            if (funcionarioEncontrado.Nif != tbNif.Text)
            {
                //Comparar o nif digitado com os funcionarios já cadastrados e retorna true caso o nif esteja em uso
                bool funcionarioRepetido = funcionarios.Exists(funcionario =>
                    funcionario.Nif.Equals(tbNif.Text)
                );
                // Caso tenha um funcionario com o mesmo nif apresenta mensagem de erro
                if (funcionarioRepetido)
                {
                    MessageBox.Show("Nif já cadastrado");
                    return;
                }
                // Caso nao tenha funcionario com o mesmo nif atualiza o valor
                else
                {
                    funcionarioEncontrado.Nif = tbNif.Text;
                }
            }

            MessageBox.Show("Funcionario alterado!");

            //atualizar o funcionario na base de dados
            applicationContext.SaveChanges();
            applicationContext.Pessoas.Load();
            LimparListView();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listViewFuncionarios.SelectedItems[0].SubItems[0].Text);
            Pessoa funcionarioRemovido = applicationContext.Pessoas.FirstOrDefault(i => i.Id == id);

            if(funcionarioRemovido != null)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir esse funcionario?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    applicationContext.Pessoas.Remove(funcionarioRemovido);
                    applicationContext.SaveChanges();
                    applicationContext.Pessoas.Load();
                    LimparListView();
                    MessageBox.Show("Funcionario removido com sucesso");
                }
               
            }
        }
    }
}
