namespace GestorCinema
{
    partial class AtendimentoForm
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
            this.list_sessions = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btClienteAnonimo = new System.Windows.Forms.Button();
            this.btSelecionarCliente = new System.Windows.Forms.Button();
            this.list_clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search = new System.Windows.Forms.Button();
            this.search_for = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.list_films = new System.Windows.Forms.ComboBox();
            this.TabAtendimento = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLugares = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.TabAtendimento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_sessions);
            this.groupBox1.Controls.Add(this.btClienteAnonimo);
            this.groupBox1.Controls.Add(this.btSelecionarCliente);
            this.groupBox1.Controls.Add(this.list_clients);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.search_for);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.list_films);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(899, 474);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atendimento";
            // 
            // list_sessions
            // 
            this.list_sessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Hora,
            this.Sala,
            this.Preco});
            this.list_sessions.FullRowSelect = true;
            this.list_sessions.HideSelection = false;
            this.list_sessions.Location = new System.Drawing.Point(23, 100);
            this.list_sessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_sessions.Name = "list_sessions";
            this.list_sessions.Size = new System.Drawing.Size(279, 340);
            this.list_sessions.TabIndex = 15;
            this.list_sessions.UseCompatibleStateImageBehavior = false;
            this.list_sessions.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 37;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            // 
            // Sala
            // 
            this.Sala.Text = "Sala";
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            // 
            // btClienteAnonimo
            // 
            this.btClienteAnonimo.Location = new System.Drawing.Point(576, 446);
            this.btClienteAnonimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClienteAnonimo.Name = "btClienteAnonimo";
            this.btClienteAnonimo.Size = new System.Drawing.Size(139, 23);
            this.btClienteAnonimo.TabIndex = 14;
            this.btClienteAnonimo.Text = "Cliente anonimo";
            this.btClienteAnonimo.UseVisualStyleBackColor = true;
            this.btClienteAnonimo.Click += new System.EventHandler(this.btClienteAnonimo_Click);
            // 
            // btSelecionarCliente
            // 
            this.btSelecionarCliente.Location = new System.Drawing.Point(733, 446);
            this.btSelecionarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelecionarCliente.Name = "btSelecionarCliente";
            this.btSelecionarCliente.Size = new System.Drawing.Size(139, 23);
            this.btSelecionarCliente.TabIndex = 13;
            this.btSelecionarCliente.Text = "Selecionar cliente";
            this.btSelecionarCliente.UseVisualStyleBackColor = true;
            this.btSelecionarCliente.Click += new System.EventHandler(this.btSelecionarCliente_Click);
            // 
            // list_clients
            // 
            this.list_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.list_clients.FullRowSelect = true;
            this.list_clients.HideSelection = false;
            this.list_clients.Location = new System.Drawing.Point(364, 100);
            this.list_clients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_clients.Name = "list_clients";
            this.list_clients.Size = new System.Drawing.Size(507, 340);
            this.list_clients.TabIndex = 11;
            this.list_clients.UseCompatibleStateImageBehavior = false;
            this.list_clients.View = System.Windows.Forms.View.Details;
            this.list_clients.VisibleChanged += new System.EventHandler(this.list_clients_VisibleChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NIF";
            this.columnHeader3.Width = 81;
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
            // search
            // 
            this.search.Location = new System.Drawing.Point(789, 62);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(81, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search_for
            // 
            this.search_for.Location = new System.Drawing.Point(448, 62);
            this.search_for.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_for.Name = "search_for";
            this.search_for.Size = new System.Drawing.Size(336, 22);
            this.search_for.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(101, 27);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 1;
            // 
            // list_films
            // 
            this.list_films.FormattingEnabled = true;
            this.list_films.Location = new System.Drawing.Point(101, 66);
            this.list_films.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_films.Name = "list_films";
            this.list_films.Size = new System.Drawing.Size(200, 24);
            this.list_films.TabIndex = 0;
            this.list_films.SelectedIndexChanged += new System.EventHandler(this.list_films_SelectedIndexChanged);
            // 
            // TabAtendimento
            // 
            this.TabAtendimento.Controls.Add(this.tabPage1);
            this.TabAtendimento.Controls.Add(this.tabPage2);
            this.TabAtendimento.Location = new System.Drawing.Point(184, 41);
            this.TabAtendimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabAtendimento.Name = "TabAtendimento";
            this.TabAtendimento.SelectedIndex = 0;
            this.TabAtendimento.Size = new System.Drawing.Size(917, 514);
            this.TabAtendimento.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(909, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelLugares);
            this.tabPage2.Controls.Add(this.labelTotal);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(909, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(721, 456);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(92, 16);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total lugares: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelLugares
            // 
            this.labelLugares.AutoSize = true;
            this.labelLugares.Location = new System.Drawing.Point(6, 456);
            this.labelLugares.Name = "labelLugares";
            this.labelLugares.Size = new System.Drawing.Size(128, 16);
            this.labelLugares.TabIndex = 10;
            this.labelLugares.Text = "Lugares escolhidos:";
            // 
            // AtendimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.TabAtendimento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AtendimentoForm";
            this.Text = "Atendimento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabAtendimento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox list_films;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabControl TabAtendimento;
        private System.Windows.Forms.Button btSelecionarCliente;
        private System.Windows.Forms.ListView list_clients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox search_for;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btClienteAnonimo;
        private System.Windows.Forms.ListView list_sessions;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Sala;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLugares;
    }
}