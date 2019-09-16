using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 10 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X - 10 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 10 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 25);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Location.Y - 10 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 25);
            }
        }
    }
}
