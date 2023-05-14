﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    public partial class Form1 : Form
    {
        private Funcionarios funcionarios;
        private Clientes clientes;
        private Informacoes informacoes;

        public Form1()
        {
            InitializeComponent();
            
            //temos que fazer com que caso nao esteja logado entre em loop
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            panel1.Controls.Clear();
            if (this.clientes == null)
            {
                this.clientes = new Clientes();
            }

            GroupBox groupBox = this.clientes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.funcionarios == null)
            {
                this.funcionarios = new Funcionarios();
            }

            GroupBox groupBox = this.funcionarios.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }

        private void informaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (this.informacoes == null)
            {
                this.informacoes = new Informacoes();
            }

            GroupBox groupBox = this.informacoes.MyGroupBox;
            groupBox.Parent = this.panel1;
            groupBox.Visible = true;
        }
    }
}