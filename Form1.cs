using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHUpdater
{
    public partial class Form1 : Form
    {

        private readonly string Version = "1.0";
       public Form1()
        {
            
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(39, 451);
            pictureBox3.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(410, 475);
            pictureBox4.BackColor = Color.Transparent;
            button1.Controls.Add(pictureBox4);
            button1.Location = new Point(402, 476);
            button1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(panel1);
            panel1.Location = new Point(16, 475);
            panel1.BackColor = Color.Transparent;
           
            pictureBox1.Controls.Add(button3);
            button3.Location = new Point(500, 13);
            button3.BackColor = Color.Transparent;
            button3.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(498, 8);
            pictureBox5.BackColor = Color.Transparent;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            


        }
        public string getVersion()
        {
            return Version;
        }
        //Method to update
        private void checkForUpdater()
        {
            string URL = "http://127.0.0.1:88/Updater/";
            string AppName = "test.rar";
            string ServerVersion;
            string serverVersionName = "Update.txt";
            // i will make take a old app to check if its work

            WebRequest req = WebRequest.Create(URL + serverVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader tr = new StreamReader(str);
            ServerVersion = tr.ReadLine();

            if (getVersion() != ServerVersion)
            {
                //Update
                WebClient client = new WebClient();
                byte[] appdata = client.DownloadData(URL + AppName);

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Choose the location of Phoenix Heroes";
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    MessageBox.Show(fbd.SelectedPath);

            }
            else
            {
                MessageBox.Show("No Update is Avaible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;

            //Red image
            Bitmap bmp = new Bitmap("C:\\Users\\alexi\\Documents\\PHUpdater\\IDR_DEFAULTIMG.png");

            //load image in picturebox
            pictureBox2.Image = bmp;

            //write image
            bmp.Save("C:\\Users\\alexi\\Documents\\PHUpdater\\Output.png");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if(panel1.Width >= 380)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkForUpdater();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want cancel the game ?","Phoenix Heroes Updater", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

            else if (result == DialogResult.No) ;
                

           
        }
    }

 
}

