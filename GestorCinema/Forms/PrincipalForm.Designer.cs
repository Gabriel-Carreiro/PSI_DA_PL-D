namespace GestorCinema
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMenuRapido = new System.Windows.Forms.GroupBox();
            this.btPrincipal = new System.Windows.Forms.Button();
            this.btInformacoes = new System.Windows.Forms.Button();
            this.btSessoes = new System.Windows.Forms.Button();
            this.btFilmes = new System.Windows.Forms.Button();
            this.btFuncionarios = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btAtendimento = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.groupBoxSessoesDia = new System.Windows.Forms.GroupBox();
            this.btComprarBilhete = new System.Windows.Forms.Button();
            this.btMostarTodosFilmes = new System.Windows.Forms.Button();
            this.btBuscarFilme = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewFilmes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMenuRapido.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxSessoesDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(164, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 516);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxMenuRapido
            // 
            this.groupBoxMenuRapido.Controls.Add(this.btPrincipal);
            this.groupBoxMenuRapido.Controls.Add(this.btInformacoes);
            this.groupBoxMenuRapido.Controls.Add(this.btSessoes);
            this.groupBoxMenuRapido.Controls.Add(this.btFilmes);
            this.groupBoxMenuRapido.Controls.Add(this.btFuncionarios);
            this.groupBoxMenuRapido.Controls.Add(this.btClientes);
            this.groupBoxMenuRapido.Controls.Add(this.btAtendimento);
            this.groupBoxMenuRapido.Location = new System.Drawing.Point(3, 41);
            this.groupBoxMenuRapido.Name = "groupBoxMenuRapido";
            this.groupBoxMenuRapido.Size = new System.Drawing.Size(163, 499);
            this.groupBoxMenuRapido.TabIndex = 24;
            this.groupBoxMenuRapido.TabStop = false;
            this.groupBoxMenuRapido.Text = "Menu Rapido";
            // 
            // btPrincipal
            // 
            this.btPrincipal.Location = new System.Drawing.Point(15, 31);
            this.btPrincipal.Name = "btPrincipal";
            this.btPrincipal.Size = new System.Drawing.Size(128, 51);
            this.btPrincipal.TabIndex = 24;
            this.btPrincipal.Text = "Principal";
            this.btPrincipal.UseVisualStyleBackColor = true;
            this.btPrincipal.Click += new System.EventHandler(this.btPrincipal_Click);
            // 
            // btInformacoes
            // 
            this.btInformacoes.Location = new System.Drawing.Point(15, 442);
            this.btInformacoes.Name = "btInformacoes";
            this.btInformacoes.Size = new System.Drawing.Size(128, 51);
            this.btInformacoes.TabIndex = 23;
            this.btInformacoes.Text = "Informaçoes do Cinema";
            this.btInformacoes.UseVisualStyleBackColor = true;
            this.btInformacoes.Click += new System.EventHandler(this.btInformacoes_Click);
            // 
            // btSessoes
            // 
            this.btSessoes.Location = new System.Drawing.Point(15, 371);
            this.btSessoes.Name = "btSessoes";
            this.btSessoes.Size = new System.Drawing.Size(128, 51);
            this.btSessoes.TabIndex = 22;
            this.btSessoes.Text = "Sessoes";
            this.btSessoes.UseVisualStyleBackColor = true;
            this.btSessoes.Click += new System.EventHandler(this.btSessoes_Click);
            // 
            // btFilmes
            // 
            this.btFilmes.Location = new System.Drawing.Point(15, 304);
            this.btFilmes.Name = "btFilmes";
            this.btFilmes.Size = new System.Drawing.Size(128, 51);
            this.btFilmes.TabIndex = 21;
            this.btFilmes.Text = "Filmes";
            this.btFilmes.UseVisualStyleBackColor = true;
            this.btFilmes.Click += new System.EventHandler(this.btFilmes_Click);
            // 
            // btFuncionarios
            // 
            this.btFuncionarios.Location = new System.Drawing.Point(15, 237);
            this.btFuncionarios.Name = "btFuncionarios";
            this.btFuncionarios.Size = new System.Drawing.Size(128, 51);
            this.btFuncionarios.TabIndex = 20;
            this.btFuncionarios.Text = "Funcionarios";
            this.btFuncionarios.UseVisualStyleBackColor = true;
            this.btFuncionarios.Click += new System.EventHandler(this.btFuncionarios_Click);
            // 
            // btClientes
            // 
            this.btClientes.Location = new System.Drawing.Point(15, 167);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(128, 51);
            this.btClientes.TabIndex = 19;
            this.btClientes.Text = "Clientes";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btAtendimento
            // 
            this.btAtendimento.Location = new System.Drawing.Point(15, 99);
            this.btAtendimento.Name = "btAtendimento";
            this.btAtendimento.Size = new System.Drawing.Size(128, 51);
            this.btAtendimento.TabIndex = 18;
            this.btAtendimento.Text = "Atendimento";
            this.btAtendimento.UseVisualStyleBackColor = true;
            this.btAtendimento.Click += new System.EventHandler(this.btAtendimento_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1116, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabelUsuario.Text = "Usuario";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // groupBoxSessoesDia
            // 
            this.groupBoxSessoesDia.Controls.Add(this.btComprarBilhete);
            this.groupBoxSessoesDia.Controls.Add(this.btMostarTodosFilmes);
            this.groupBoxSessoesDia.Controls.Add(this.btBuscarFilme);
            this.groupBoxSessoesDia.Controls.Add(this.tbBusca);
            this.groupBoxSessoesDia.Controls.Add(this.label5);
            this.groupBoxSessoesDia.Controls.Add(this.listViewFilmes);
            this.groupBoxSessoesDia.Location = new System.Drawing.Point(184, 41);
            this.groupBoxSessoesDia.Name = "groupBoxSessoesDia";
            this.groupBoxSessoesDia.Size = new System.Drawing.Size(919, 499);
            this.groupBoxSessoesDia.TabIndex = 7;
            this.groupBoxSessoesDia.TabStop = false;
            this.groupBoxSessoesDia.Text = "Sessoes do dia";
            // 
            // btComprarBilhete
            // 
            this.btComprarBilhete.Location = new System.Drawing.Point(711, 457);
            this.btComprarBilhete.Name = "btComprarBilhete";
            this.btComprarBilhete.Size = new System.Drawing.Size(141, 32);
            this.btComprarBilhete.TabIndex = 18;
            this.btComprarBilhete.Text = "Comprar Bilhete";
            this.btComprarBilhete.UseVisualStyleBackColor = true;
            this.btComprarBilhete.Click += new System.EventHandler(this.btComprarBilhete_Click);
            // 
            // btMostarTodosFilmes
            // 
            this.btMostarTodosFilmes.Location = new System.Drawing.Point(581, 20);
            this.btMostarTodosFilmes.Name = "btMostarTodosFilmes";
            this.btMostarTodosFilmes.Size = new System.Drawing.Size(112, 23);
            this.btMostarTodosFilmes.TabIndex = 17;
            this.btMostarTodosFilmes.Text = "Mostrar todos";
            this.btMostarTodosFilmes.UseVisualStyleBackColor = true;
            // 
            // btBuscarFilme
            // 
            this.btBuscarFilme.Location = new System.Drawing.Point(504, 21);
            this.btBuscarFilme.Name = "btBuscarFilme";
            this.btBuscarFilme.Size = new System.Drawing.Size(75, 23);
            this.btBuscarFilme.TabIndex = 16;
            this.btBuscarFilme.Text = "Buscar";
            this.btBuscarFilme.UseVisualStyleBackColor = true;
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(122, 21);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(376, 22);
            this.tbBusca.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pesquisar";
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Nome,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFilmes.FullRowSelect = true;
            this.listViewFilmes.HideSelection = false;
            this.listViewFilmes.Location = new System.Drawing.Point(41, 50);
            this.listViewFilmes.MultiSelect = false;
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(811, 401);
            this.listViewFilmes.TabIndex = 5;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.View = System.Windows.Forms.View.Details;
            this.listViewFilmes.VisibleChanged += new System.EventHandler(this.listViewFilmes_VisibleChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 39;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 335;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Duração";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Categoria";
            this.columnHeader9.Width = 101;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Estado";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sala";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Horario";
            this.columnHeader3.Width = 100;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBoxMenuRapido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxSessoesDia);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalForm";
            this.Text = "tea";
            this.groupBoxMenuRapido.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxSessoesDia.ResumeLayout(false);
            this.groupBoxSessoesDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        public System.Windows.Forms.GroupBox groupBoxSessoesDia;
        private System.Windows.Forms.Button btMostarTodosFilmes;
        private System.Windows.Forms.Button btBuscarFilme;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBoxMenuRapido;
        private System.Windows.Forms.Button btInformacoes;
        private System.Windows.Forms.Button btSessoes;
        private System.Windows.Forms.Button btFilmes;
        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btAtendimento;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btPrincipal;
        private System.Windows.Forms.Button btComprarBilhete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}

