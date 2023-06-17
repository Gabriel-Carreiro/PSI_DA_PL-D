namespace GestorCinema
{
    partial class InformacoesForm
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
            this.gbCinema = new System.Windows.Forms.GroupBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.numeroSalas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBEmailCinema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBMoradaCinema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNomeCinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSalas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCriarSala = new System.Windows.Forms.Button();
            this.novaSala = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numeroColunaCriar = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numeroFilaCriar = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numeroSala = new System.Windows.Forms.ComboBox();
            this.buttonEditarSala = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroColunaEditar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numeroFilaEditar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonExcluirSala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCinema.SuspendLayout();
            this.tabControlSalas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroColunaCriar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFilaCriar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroColunaEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFilaEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbCinema);
            this.groupBox1.Controls.Add(this.tabControlSalas);
            this.groupBox1.Location = new System.Drawing.Point(184, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(919, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // gbCinema
            // 
            this.gbCinema.Controls.Add(this.btSalvar);
            this.gbCinema.Controls.Add(this.numeroSalas);
            this.gbCinema.Controls.Add(this.label4);
            this.gbCinema.Controls.Add(this.tBEmailCinema);
            this.gbCinema.Controls.Add(this.label3);
            this.gbCinema.Controls.Add(this.tBMoradaCinema);
            this.gbCinema.Controls.Add(this.label2);
            this.gbCinema.Controls.Add(this.tBNomeCinema);
            this.gbCinema.Controls.Add(this.label1);
            this.gbCinema.Location = new System.Drawing.Point(38, 96);
            this.gbCinema.Margin = new System.Windows.Forms.Padding(4);
            this.gbCinema.Name = "gbCinema";
            this.gbCinema.Padding = new System.Windows.Forms.Padding(4);
            this.gbCinema.Size = new System.Drawing.Size(394, 321);
            this.gbCinema.TabIndex = 18;
            this.gbCinema.TabStop = false;
            this.gbCinema.Text = "Cinema";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(278, 260);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(89, 31);
            this.btSalvar.TabIndex = 42;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // numeroSalas
            // 
            this.numeroSalas.AutoSize = true;
            this.numeroSalas.Location = new System.Drawing.Point(134, 221);
            this.numeroSalas.Name = "numeroSalas";
            this.numeroSalas.Size = new System.Drawing.Size(18, 20);
            this.numeroSalas.TabIndex = 41;
            this.numeroSalas.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Numero de salas";
            // 
            // tBEmailCinema
            // 
            this.tBEmailCinema.Location = new System.Drawing.Point(131, 159);
            this.tBEmailCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBEmailCinema.Name = "tBEmailCinema";
            this.tBEmailCinema.Size = new System.Drawing.Size(236, 22);
            this.tBEmailCinema.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Email";
            // 
            // tBMoradaCinema
            // 
            this.tBMoradaCinema.Location = new System.Drawing.Point(131, 106);
            this.tBMoradaCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBMoradaCinema.Name = "tBMoradaCinema";
            this.tBMoradaCinema.Size = new System.Drawing.Size(236, 22);
            this.tBMoradaCinema.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Morada";
            // 
            // tBNomeCinema
            // 
            this.tBNomeCinema.Location = new System.Drawing.Point(131, 54);
            this.tBNomeCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBNomeCinema.Name = "tBNomeCinema";
            this.tBNomeCinema.Size = new System.Drawing.Size(236, 22);
            this.tBNomeCinema.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome";
            // 
            // tabControlSalas
            // 
            this.tabControlSalas.Controls.Add(this.tabPage1);
            this.tabControlSalas.Controls.Add(this.tabPage2);
            this.tabControlSalas.Location = new System.Drawing.Point(467, 127);
            this.tabControlSalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSalas.Name = "tabControlSalas";
            this.tabControlSalas.SelectedIndex = 0;
            this.tabControlSalas.Size = new System.Drawing.Size(431, 260);
            this.tabControlSalas.TabIndex = 17;
            this.tabControlSalas.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCriarSala);
            this.tabPage1.Controls.Add(this.novaSala);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.numeroColunaCriar);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.numeroFilaCriar);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(423, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCriarSala
            // 
            this.buttonCriarSala.Location = new System.Drawing.Point(309, 185);
            this.buttonCriarSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCriarSala.Name = "buttonCriarSala";
            this.buttonCriarSala.Size = new System.Drawing.Size(75, 23);
            this.buttonCriarSala.TabIndex = 25;
            this.buttonCriarSala.Text = "Criar";
            this.buttonCriarSala.UseVisualStyleBackColor = true;
            this.buttonCriarSala.Click += new System.EventHandler(this.buttonCriarSala_Click);
            // 
            // novaSala
            // 
            this.novaSala.AutoSize = true;
            this.novaSala.Location = new System.Drawing.Point(179, 52);
            this.novaSala.Name = "novaSala";
            this.novaSala.Size = new System.Drawing.Size(18, 20);
            this.novaSala.TabIndex = 24;
            this.novaSala.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sala";
            // 
            // numeroColunaCriar
            // 
            this.numeroColunaCriar.Location = new System.Drawing.Point(181, 127);
            this.numeroColunaCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroColunaCriar.Name = "numeroColunaCriar";
            this.numeroColunaCriar.Size = new System.Drawing.Size(71, 22);
            this.numeroColunaCriar.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Numero de colunas";
            // 
            // numeroFilaCriar
            // 
            this.numeroFilaCriar.Location = new System.Drawing.Point(181, 89);
            this.numeroFilaCriar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroFilaCriar.Name = "numeroFilaCriar";
            this.numeroFilaCriar.Size = new System.Drawing.Size(71, 22);
            this.numeroFilaCriar.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Numero de filas";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExcluirSala);
            this.tabPage2.Controls.Add(this.numeroSala);
            this.tabPage2.Controls.Add(this.buttonEditarSala);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.numeroColunaEditar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.numeroFilaEditar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(423, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numeroSala
            // 
            this.numeroSala.FormattingEnabled = true;
            this.numeroSala.Location = new System.Drawing.Point(181, 52);
            this.numeroSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroSala.Name = "numeroSala";
            this.numeroSala.Size = new System.Drawing.Size(75, 24);
            this.numeroSala.TabIndex = 33;
            this.numeroSala.SelectedIndexChanged += new System.EventHandler(this.numeroSala_SelectedIndexChanged);
            // 
            // buttonEditarSala
            // 
            this.buttonEditarSala.Location = new System.Drawing.Point(309, 185);
            this.buttonEditarSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarSala.Name = "buttonEditarSala";
            this.buttonEditarSala.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarSala.TabIndex = 32;
            this.buttonEditarSala.Text = "Editar";
            this.buttonEditarSala.UseVisualStyleBackColor = true;
            this.buttonEditarSala.Click += new System.EventHandler(this.buttonEditarSala_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sala";
            // 
            // numeroColunaEditar
            // 
            this.numeroColunaEditar.Location = new System.Drawing.Point(181, 127);
            this.numeroColunaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroColunaEditar.Name = "numeroColunaEditar";
            this.numeroColunaEditar.Size = new System.Drawing.Size(71, 22);
            this.numeroColunaEditar.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Numero de colunas";
            // 
            // numeroFilaEditar
            // 
            this.numeroFilaEditar.Location = new System.Drawing.Point(181, 89);
            this.numeroFilaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeroFilaEditar.Name = "numeroFilaEditar";
            this.numeroFilaEditar.Size = new System.Drawing.Size(71, 22);
            this.numeroFilaEditar.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Numero de filas";
            // 
            // buttonExcluirSala
            // 
            this.buttonExcluirSala.Location = new System.Drawing.Point(228, 185);
            this.buttonExcluirSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirSala.Name = "buttonExcluirSala";
            this.buttonExcluirSala.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirSala.TabIndex = 34;
            this.buttonExcluirSala.Text = "Excluir";
            this.buttonExcluirSala.UseVisualStyleBackColor = true;
            this.buttonExcluirSala.Click += new System.EventHandler(this.buttonExcluirSala_Click);
            // 
            // InformacoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InformacoesForm";
            this.Text = "Informacoes";
            this.groupBox1.ResumeLayout(false);
            this.gbCinema.ResumeLayout(false);
            this.gbCinema.PerformLayout();
            this.tabControlSalas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroColunaCriar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFilaCriar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroColunaEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFilaEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlSalas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCriarSala;
        private System.Windows.Forms.Label novaSala;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numeroColunaCriar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numeroFilaCriar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox numeroSala;
        private System.Windows.Forms.Button buttonEditarSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeroColunaEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeroFilaEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCinema;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label numeroSalas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBEmailCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBMoradaCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNomeCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluirSala;
    }
}