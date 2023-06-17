namespace GestorCinema
{
    partial class FilmesForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbIdFilme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btAlterarFilme = new System.Windows.Forms.Button();
            this.tbNomeFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstadoFilme = new System.Windows.Forms.ComboBox();
            this.cbCategoriaFilme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuracaoFilme = new System.Windows.Forms.TextBox();
            this.btAdicionarFilme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAlterarEstadoCategoria = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btMostarTodosFilmes);
            this.groupBox1.Controls.Add(this.btBuscarFilme);
            this.groupBox1.Controls.Add(this.tbBusca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listViewFilmes);
            this.groupBox1.Location = new System.Drawing.Point(185, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 500);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filme";
            this.groupBox1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbIdFilme);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btAlterarFilme);
            this.groupBox3.Controls.Add(this.tbNomeFilme);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbEstadoFilme);
            this.groupBox3.Controls.Add(this.cbCategoriaFilme);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbDuracaoFilme);
            this.groupBox3.Controls.Add(this.btAdicionarFilme);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 219);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criar filme";
            // 
            // tbIdFilme
            // 
            this.tbIdFilme.Location = new System.Drawing.Point(79, 24);
            this.tbIdFilme.Name = "tbIdFilme";
            this.tbIdFilme.ReadOnly = true;
            this.tbIdFilme.Size = new System.Drawing.Size(100, 22);
            this.tbIdFilme.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id";
            // 
            // btAlterarFilme
            // 
            this.btAlterarFilme.Location = new System.Drawing.Point(133, 186);
            this.btAlterarFilme.Name = "btAlterarFilme";
            this.btAlterarFilme.Size = new System.Drawing.Size(75, 23);
            this.btAlterarFilme.TabIndex = 5;
            this.btAlterarFilme.Text = "Alterar";
            this.btAlterarFilme.UseVisualStyleBackColor = true;
            this.btAlterarFilme.Click += new System.EventHandler(this.btAlterarFilme_Click);
            // 
            // tbNomeFilme
            // 
            this.tbNomeFilme.Location = new System.Drawing.Point(79, 49);
            this.tbNomeFilme.Name = "tbNomeFilme";
            this.tbNomeFilme.Size = new System.Drawing.Size(213, 22);
            this.tbNomeFilme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria";
            // 
            // cbEstadoFilme
            // 
            this.cbEstadoFilme.FormattingEnabled = true;
            this.cbEstadoFilme.Items.AddRange(new object[] {
            "Ativo",
            "Desativo"});
            this.cbEstadoFilme.Location = new System.Drawing.Point(79, 109);
            this.cbEstadoFilme.Name = "cbEstadoFilme";
            this.cbEstadoFilme.Size = new System.Drawing.Size(125, 24);
            this.cbEstadoFilme.TabIndex = 3;
            // 
            // cbCategoriaFilme
            // 
            this.cbCategoriaFilme.FormattingEnabled = true;
            this.cbCategoriaFilme.Location = new System.Drawing.Point(79, 142);
            this.cbCategoriaFilme.Name = "cbCategoriaFilme";
            this.cbCategoriaFilme.Size = new System.Drawing.Size(125, 24);
            this.cbCategoriaFilme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado";
            // 
            // tbDuracaoFilme
            // 
            this.tbDuracaoFilme.Location = new System.Drawing.Point(79, 78);
            this.tbDuracaoFilme.Name = "tbDuracaoFilme";
            this.tbDuracaoFilme.Size = new System.Drawing.Size(129, 22);
            this.tbDuracaoFilme.TabIndex = 2;
            // 
            // btAdicionarFilme
            // 
            this.btAdicionarFilme.Location = new System.Drawing.Point(218, 186);
            this.btAdicionarFilme.Name = "btAdicionarFilme";
            this.btAdicionarFilme.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarFilme.TabIndex = 6;
            this.btAdicionarFilme.Text = "Adicionar";
            this.btAdicionarFilme.UseVisualStyleBackColor = true;
            this.btAdicionarFilme.Click += new System.EventHandler(this.btAdicionarFilme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duração";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btAlterarEstadoCategoria);
            this.groupBox2.Location = new System.Drawing.Point(13, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 140);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Categoria";
            // 
            // btAlterarEstadoCategoria
            // 
            this.btAlterarEstadoCategoria.Location = new System.Drawing.Point(209, 65);
            this.btAlterarEstadoCategoria.Name = "btAlterarEstadoCategoria";
            this.btAlterarEstadoCategoria.Size = new System.Drawing.Size(83, 23);
            this.btAlterarEstadoCategoria.TabIndex = 8;
            this.btAlterarEstadoCategoria.Text = "Ativar";
            this.btAlterarEstadoCategoria.UseVisualStyleBackColor = true;
            this.btAlterarEstadoCategoria.Click += new System.EventHandler(this.btAlterarEstadoCategoria_Click);
            // 
            // btMostarTodosFilmes
            // 
            this.btMostarTodosFilmes.Location = new System.Drawing.Point(762, 83);
            this.btMostarTodosFilmes.Name = "btMostarTodosFilmes";
            this.btMostarTodosFilmes.Size = new System.Drawing.Size(103, 23);
            this.btMostarTodosFilmes.TabIndex = 17;
            this.btMostarTodosFilmes.Text = "Mostrar todos";
            this.btMostarTodosFilmes.UseVisualStyleBackColor = true;
            this.btMostarTodosFilmes.Click += new System.EventHandler(this.btMostarTodosFilmes_Click);
            // 
            // btBuscarFilme
            // 
            this.btBuscarFilme.Location = new System.Drawing.Point(691, 83);
            this.btBuscarFilme.Name = "btBuscarFilme";
            this.btBuscarFilme.Size = new System.Drawing.Size(61, 23);
            this.btBuscarFilme.TabIndex = 16;
            this.btBuscarFilme.Text = "Buscar";
            this.btBuscarFilme.UseVisualStyleBackColor = true;
            this.btBuscarFilme.Click += new System.EventHandler(this.btBuscarFilme_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(406, 83);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(279, 22);
            this.tbBusca.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 86);
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
            this.columnHeader10});
            this.listViewFilmes.FullRowSelect = true;
            this.listViewFilmes.HideSelection = false;
            this.listViewFilmes.Location = new System.Drawing.Point(325, 118);
            this.listViewFilmes.MultiSelect = false;
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(546, 377);
            this.listViewFilmes.TabIndex = 5;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.View = System.Windows.Forms.View.Details;
            this.listViewFilmes.SelectedIndexChanged += new System.EventHandler(this.listViewFilmes_SelectedIndexChanged);
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
            // FilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmesForm";
            this.Text = "Filme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btAdicionarFilme;
        private System.Windows.Forms.ComboBox cbCategoriaFilme;
        private System.Windows.Forms.TextBox tbNomeFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstadoFilme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuracaoFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btMostarTodosFilmes;
        private System.Windows.Forms.Button btBuscarFilme;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAlterarEstadoCategoria;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAlterarFilme;
        private System.Windows.Forms.TextBox tbIdFilme;
        private System.Windows.Forms.Label label7;
    }
}