using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            studentreg1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("학생등록버튼누름");
            menuBar.Location = new System.Drawing.Point(12, 143);
            studentreg1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menuBar.Location = new System.Drawing.Point(12, 207);
            studentsearch1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menuBar.Location = new System.Drawing.Point(12, 271);
            studentdel1.BringToFront();
        }
    }
}
