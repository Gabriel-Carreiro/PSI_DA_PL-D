﻿namespace GestorCinema
{
    partial class SessoesForm
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
            this.search_by = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.list_sessions = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_rooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showall = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_films = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_by);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.list_sessions);
            this.groupBox1.Controls.Add(this.list_rooms);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_showall);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.list_films);
            this.groupBox1.Location = new System.Drawing.Point(184, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(919, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sessão";
            // 
            // search_by
            // 
            this.search_by.FormattingEnabled = true;
            this.search_by.Items.AddRange(new object[] {
            "Id do Filme",
            "Nome",
            "Categoria"});
            this.search_by.Location = new System.Drawing.Point(105, 39);
            this.search_by.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_by.Name = "search_by";
            this.search_by.Size = new System.Drawing.Size(106, 24);
            this.search_by.TabIndex = 27;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(800, 461);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(112, 23);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Criar Sessão";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // list_sessions
            // 
            this.list_sessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_sessions.HideSelection = false;
            this.list_sessions.Location = new System.Drawing.Point(518, 86);
            this.list_sessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_sessions.Name = "list_sessions";
            this.list_sessions.Size = new System.Drawing.Size(393, 365);
            this.list_sessions.TabIndex = 26;
            this.list_sessions.UseCompatibleStateImageBehavior = false;
            this.list_sessions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            // 
            // list_rooms
            // 
            this.list_rooms.FormattingEnabled = true;
            this.list_rooms.Location = new System.Drawing.Point(559, 40);
            this.list_rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_rooms.Name = "list_rooms";
            this.list_rooms.Size = new System.Drawing.Size(125, 24);
            this.list_rooms.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sala";
            // 
            // btn_showall
            // 
            this.btn_showall.Location = new System.Drawing.Point(384, 461);
            this.btn_showall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(112, 23);
            this.btn_showall.TabIndex = 5;
            this.btn_showall.Text = "Mostrar todos";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(421, 41);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(217, 40);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(198, 22);
            this.txt_search.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pesquisar por";
            // 
            // list_films
            // 
            this.list_films.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Nome,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.list_films.HideSelection = false;
            this.list_films.Location = new System.Drawing.Point(16, 86);
            this.list_films.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_films.Name = "list_films";
            this.list_films.Size = new System.Drawing.Size(480, 365);
            this.list_films.TabIndex = 18;
            this.list_films.UseCompatibleStateImageBehavior = false;
            this.list_films.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 39;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 171;
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
            this.columnHeader10.Width = 63;
            // 
            // SessoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SessoesForm";
            this.Text = "Sessao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_sessions;
        private System.Windows.Forms.ComboBox list_rooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView list_films;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox search_by;
    }
}