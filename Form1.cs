using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(39, 451);
            pictureBox3.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(410, 475);
            pictureBox4.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(button1);
            button1.Location = new Point(410, 475);
            button1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(panel1);
            panel1.Location = new Point(12, 475);
            panel1.BackColor = Color.Transparent;
            panel2.Location = new Point(30, 480);
            panel2.BackColor = Color.SteelBlue;
            pictureBox1.Controls.Add(button3);
            button3.Location = new Point(500, 13);
            button3.BackColor = Color.Transparent;
            button3.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(498, 8);
            pictureBox5.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Red image
            Bitmap bmp = new Bitmap("C:\\Users\\alexi\\Documents\\PHUpdater\\IDR_DEFAULTIMG.png");

            //load image in picturebox
            pictureBox2.Image = bmp;

            //write image
            bmp.Save("C:\\Users\\alexi\\Documents\\PHUpdater\\Output.png");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 355)
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
