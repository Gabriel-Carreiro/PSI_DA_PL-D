namespace GestorCinema
{
    partial class FuncionariosForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxFuncionarios = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.btMostrarTodos = new System.Windows.Forms.Button();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRegistar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewFuncionarios = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btBuscarFuncionario = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.groupBoxFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(191, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxFuncionarios
            // 
            this.groupBoxFuncionarios.Controls.Add(this.tbId);
            this.groupBoxFuncionarios.Controls.Add(this.label1);
            this.groupBoxFuncionarios.Controls.Add(this.tbCargo);
            this.groupBoxFuncionarios.Controls.Add(this.btMostrarTodos);
            this.groupBoxFuncionarios.Controls.Add(this.tbSalario);
            this.groupBoxFuncionarios.Controls.Add(this.label8);
            this.groupBoxFuncionarios.Controls.Add(this.btAlterar);
            this.groupBoxFuncionarios.Controls.Add(this.btRemover);
            this.groupBoxFuncionarios.Controls.Add(this.tbTelefone);
            this.groupBoxFuncionarios.Controls.Add(this.label6);
            this.groupBoxFuncionarios.Controls.Add(this.tbMorada);
            this.groupBoxFuncionarios.Controls.Add(this.label5);
            this.groupBoxFuncionarios.Controls.Add(this.tbNif);
            this.groupBoxFuncionarios.Controls.Add(this.label4);
            this.groupBoxFuncionarios.Controls.Add(this.label3);
            this.groupBoxFuncionarios.Controls.Add(this.btRegistar);
            this.groupBoxFuncionarios.Controls.Add(this.tbNome);
            this.groupBoxFuncionarios.Controls.Add(this.label7);
            this.groupBoxFuncionarios.Controls.Add(this.listViewFuncionarios);
            this.groupBoxFuncionarios.Controls.Add(this.btBuscarFuncionario);
            this.groupBoxFuncionarios.Controls.Add(this.tbBusca);
            this.groupBoxFuncionarios.Controls.Add(this.label2);
            this.groupBoxFuncionarios.Location = new System.Drawing.Point(184, 41);
            this.groupBoxFuncionarios.Name = "groupBoxFuncionarios";
            this.groupBoxFuncionarios.Size = new System.Drawing.Size(919, 499);
            this.groupBoxFuncionarios.TabIndex = 12;
            this.groupBoxFuncionarios.TabStop = false;
            this.groupBoxFuncionarios.Text = "Funcionarios";
            this.groupBoxFuncionarios.Visible = false;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(113, 141);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(198, 22);
            this.tbId.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(113, 169);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(198, 22);
            this.tbCargo.TabIndex = 1;
            // 
            // btMostrarTodos
            // 
            this.btMostrarTodos.Location = new System.Drawing.Point(792, 448);
            this.btMostrarTodos.Name = "btMostrarTodos";
            this.btMostrarTodos.Size = new System.Drawing.Size(110, 23);
            this.btMostrarTodos.TabIndex = 26;
            this.btMostrarTodos.Text = "Mostrar todos";
            this.btMostrarTodos.UseVisualStyleBackColor = true;
            this.btMostrarTodos.Click += new System.EventHandler(this.btMostrarTodos_Click);
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(113, 335);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(198, 22);
            this.tbSalario.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Salario";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(155, 374);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(711, 448);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 23;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(113, 302);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(198, 22);
            this.tbTelefone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefone";
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(113, 266);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(198, 22);
            this.tbMorada.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Morada";
            // 
            // tbNif
            // 
            this.tbNif.Location = new System.Drawing.Point(113, 234);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(198, 22);
            this.tbNif.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "NIF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cargo";
            // 
            // btRegistar
            // 
            this.btRegistar.Location = new System.Drawing.Point(236, 374);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(75, 23);
            this.btRegistar.TabIndex = 7;
            this.btRegistar.Text = "Registar";
            this.btRegistar.UseVisualStyleBackColor = true;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(113, 202);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(198, 22);
            this.tbNome.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome";
            // 
            // listViewFuncionarios
            // 
            this.listViewFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader14,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader13});
            this.listViewFuncionarios.FullRowSelect = true;
            this.listViewFuncionarios.HideSelection = false;
            this.listViewFuncionarios.Location = new System.Drawing.Point(334, 79);
            this.listViewFuncionarios.MultiSelect = false;
            this.listViewFuncionarios.Name = "listViewFuncionarios";
            this.listViewFuncionarios.Size = new System.Drawing.Size(568, 363);
            this.listViewFuncionarios.TabIndex = 11;
            this.listViewFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionarios.View = System.Windows.Forms.View.Details;
            this.listViewFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listViewFuncionarios_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id";
            this.columnHeader8.Width = 39;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nome";
            this.columnHeader9.Width = 147;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Função";
            this.columnHeader14.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NIF";
            this.columnHeader10.Width = 98;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Telefone";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Morada";
            this.columnHeader12.Width = 180;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salario";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Contratado em";
            this.columnHeader13.Width = 135;
            // 
            // btBuscarFuncionario
            // 
            this.btBuscarFuncionario.Location = new System.Drawing.Point(827, 33);
            this.btBuscarFuncionario.Name = "btBuscarFuncionario";
            this.btBuscarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btBuscarFuncionario.TabIndex = 10;
            this.btBuscarFuncionario.Text = "Buscar";
            this.btBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btBuscarFuncionario.Click += new System.EventHandler(this.btBuscarFuncionario_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(412, 34);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(407, 22);
            this.tbBusca.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisar";
            // 
            // FuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.groupBoxFuncionarios);
            this.Controls.Add(this.tabControl1);
            this.Name = "FuncionariosForm";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.groupBoxFuncionarios.ResumeLayout(false);
            this.groupBoxFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxFuncionarios;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewFuncionarios;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btBuscarFuncionario;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMostrarTodos;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
    }
}