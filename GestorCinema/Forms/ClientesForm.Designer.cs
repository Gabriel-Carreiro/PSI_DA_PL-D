namespace GestorCinema
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBCliente = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btMostrarTodosClientes = new System.Windows.Forms.Button();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.tbBuscaCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAtualizarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gBCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gBCliente);
            this.groupBox1.Controls.Add(this.btMostrarTodosClientes);
            this.groupBox1.Controls.Add(this.listViewClientes);
            this.groupBox1.Controls.Add(this.btBuscarCliente);
            this.groupBox1.Controls.Add(this.tbBuscaCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 516);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            this.groupBox1.Visible = false;
            // 
            // gBCliente
            // 
            this.gBCliente.Controls.Add(this.btAtualizarCliente);
            this.gBCliente.Controls.Add(this.tbId);
            this.gBCliente.Controls.Add(this.label7);
            this.gBCliente.Controls.Add(this.label1);
            this.gBCliente.Controls.Add(this.tbNome);
            this.gBCliente.Controls.Add(this.tbTelefone);
            this.gBCliente.Controls.Add(this.btSalvarCliente);
            this.gBCliente.Controls.Add(this.label6);
            this.gBCliente.Controls.Add(this.label4);
            this.gBCliente.Controls.Add(this.tbMorada);
            this.gBCliente.Controls.Add(this.tbNif);
            this.gBCliente.Controls.Add(this.label5);
            this.gBCliente.Location = new System.Drawing.Point(26, 97);
            this.gBCliente.Name = "gBCliente";
            this.gBCliente.Size = new System.Drawing.Size(402, 267);
            this.gBCliente.TabIndex = 38;
            this.gBCliente.TabStop = false;
            this.gBCliente.Text = "Cliente";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 44);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(143, 22);
            this.tbId.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(100, 80);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(279, 22);
            this.tbNome.TabIndex = 28;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(100, 180);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(279, 22);
            this.tbTelefone.TabIndex = 31;
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Location = new System.Drawing.Point(304, 218);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCliente.TabIndex = 32;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "NIF";
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(100, 144);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(279, 22);
            this.tbMorada.TabIndex = 30;
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(100, 112);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(279, 22);
            this.tbNif.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Morada";
            // 
            // btMostrarTodosClientes
            // 
            this.btMostrarTodosClientes.Location = new System.Drawing.Point(926, 474);
            this.btMostrarTodosClientes.Name = "btMostrarTodosClientes";
            this.btMostrarTodosClientes.Size = new System.Drawing.Size(138, 23);
            this.btMostrarTodosClientes.TabIndex = 6;
            this.btMostrarTodosClientes.Text = "Mostrar todos";
            this.btMostrarTodosClientes.UseVisualStyleBackColor = true;
            this.btMostrarTodosClientes.Click += new System.EventHandler(this.btMostrarTodosClientes_Click);
            // 
            // listViewClientes
            // 
            this.listViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewClientes.FullRowSelect = true;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(451, 72);
            this.listViewClientes.MultiSelect = false;
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(613, 380);
            this.listViewClientes.TabIndex = 5;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.Details;
            this.listViewClientes.SelectedIndexChanged += new System.EventHandler(this.listViewClientes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NIF";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Morada";
            this.columnHeader5.Width = 279;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bilhetes Adquiridos";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total gasto";
            this.columnHeader7.Width = 85;
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(857, 32);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(81, 23);
            this.btBuscarCliente.TabIndex = 4;
            this.btBuscarCliente.Text = "Buscar";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            this.btBuscarCliente.Click += new System.EventHandler(this.btBuscarCliente_Click);
            // 
            // tbBuscaCliente
            // 
            this.tbBuscaCliente.Location = new System.Drawing.Point(542, 33);
            this.tbBuscaCliente.Name = "tbBuscaCliente";
            this.tbBuscaCliente.Size = new System.Drawing.Size(285, 22);
            this.tbBuscaCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisar";
            // 
            // btAtualizarCliente
            // 
            this.btAtualizarCliente.Location = new System.Drawing.Point(223, 218);
            this.btAtualizarCliente.Name = "btAtualizarCliente";
            this.btAtualizarCliente.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarCliente.TabIndex = 38;
            this.btAtualizarCliente.Text = "Atualizar";
            this.btAtualizarCliente.UseVisualStyleBackColor = true;
            this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBCliente.ResumeLayout(false);
            this.gBCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMostrarTodosClientes;
        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.TextBox tbBuscaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gBCliente;
        private System.Windows.Forms.Button btAtualizarCliente;
    }
}