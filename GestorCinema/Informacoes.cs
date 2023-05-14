using System;
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
    public partial class Informacoes : Form
    {
        public GroupBox MyGroupBox { get; set; }
        public Informacoes()
        {
            InitializeComponent();
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
        }
    }
}
