using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) {
               pictureBox1.Location = new Point(pictureBox1.Location.X , pictureBox1.Location.Y +10);
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X  , pictureBox1.Location.Y -10);
            }

            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X+10 , pictureBox1.Location.Y );
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X-10 , pictureBox1.Location.Y);
            }

            label3.Text = pictureBox1.Location.X.ToString();

            label4.Text = pictureBox1.Location.Y.ToString();

            if (pictureBox1.Location.X == 100)
            {
                MessageBox.Show("GANASTE");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
