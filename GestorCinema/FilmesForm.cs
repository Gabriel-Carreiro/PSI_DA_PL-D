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
    public partial class FilmesForm : Form
    {
        public GroupBox MyGroupBox { get; internal set; }
        public FilmesForm()
        {
            InitializeComponent();
            //chamar a groupbox no form1
            this.MyGroupBox = groupBox1;
            this.MyGroupBox.Dock = DockStyle.Fill;
            this.Controls.Add(this.MyGroupBox);
        }

        
    }
}
