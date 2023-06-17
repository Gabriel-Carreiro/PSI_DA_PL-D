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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSessoesDia = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMenuRapido.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxSessoesDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.informaçõesToolStripMenuItem1});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.informaçõesToolStripMenuItem.Text = "Menu";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.principalToolStripMenuItem.Text = "Principal";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.atendimentoToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmesToolStripMenuItem1,
            this.sessõesToolStripMenuItem1,
            this.funcionarioToolStripMenuItem});
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.filmesToolStripMenuItem.Text = "Adicionar";
            // 
            // filmesToolStripMenuItem1
            // 
            this.filmesToolStripMenuItem1.Name = "filmesToolStripMenuItem1";
            this.filmesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.filmesToolStripMenuItem1.Text = "Filmes";
            this.filmesToolStripMenuItem1.Click += new System.EventHandler(this.filmesToolStripMenuItem1_Click);
            // 
            // sessõesToolStripMenuItem1
            // 
            this.sessõesToolStripMenuItem1.Name = "sessõesToolStripMenuItem1";
            this.sessõesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sessõesToolStripMenuItem1.Text = "Sessões";
            this.sessõesToolStripMenuItem1.Click += new System.EventHandler(this.sessõesToolStripMenuItem1_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem1
            // 
            this.informaçõesToolStripMenuItem1.Name = "informaçõesToolStripMenuItem1";
            this.informaçõesToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.informaçõesToolStripMenuItem1.Text = "Informações Cinema";
            this.informaçõesToolStripMenuItem1.Click += new System.EventHandler(this.informaçõesToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUtilizadorToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // trocarDeUtilizadorToolStripMenuItem
            // 
            this.trocarDeUtilizadorToolStripMenuItem.Name = "trocarDeUtilizadorToolStripMenuItem";
            this.trocarDeUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.trocarDeUtilizadorToolStripMenuItem.Text = "Trocar de utilizador";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
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
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1116, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBoxSessoesDia
            // 
            this.groupBoxSessoesDia.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBoxMenuRapido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxSessoesDia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "tea";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMenuRapido.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxSessoesDia.ResumeLayout(false);
            this.groupBoxSessoesDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
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
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.Button btPrincipal;
        private System.Windows.Forms.Button button1;
    }
}

