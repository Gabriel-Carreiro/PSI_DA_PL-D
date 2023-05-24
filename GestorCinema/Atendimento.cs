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
    public partial class Atendimento : Form
    {
        public Atendimento()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = 10;
            //TabAtendimento.SelectedTab = tabPage2;
            //TabAtendimento.Refresh();
            //tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = size;
            tableLayoutPanel1.ColumnCount = size;
            
            for (int i = 0; i < size; i++)
            {
                //ColumnStyle columnStyle = new ColumnStyle(SizeType.AutoSize);
                //tableLayoutPanel1.ColumnStyles.Add(columnStyle);

                for (int j = 0; j < size; j++)
                {
                    Button button = new LugarButton(i, j);
                    //button.Anchor = AnchorStyles.None;
                    button.Size = new Size(70,50);
                    button.Text = (char)(i + 65) + "" + (j + 1);
                    // button.BackColor = i % 2 == 0 ? Color.Red : Color.Green;
                    //button.ForeColor = Color.Black;
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.BackgroundImage = Image.FromFile("C:\\Users\\gabri\\OneDrive\\Documentos\\GitHub\\ProjetoDA\\GestorCinema\\cadeira.png");
                    button.Click += LugarClicked;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }

            tableLayoutPanel1.ResumeLayout();
            //tabPage2.ResumeLayout();
        }

        internal TabPage getPage()
        {
            return TabAtendimento.TabPages[0];
        }

        private void LugarClicked(Object sender, EventArgs e)
        {
            LugarButton button = (LugarButton)sender;
            MessageBox.Show("X: " + button.X + " Y: " + button.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
