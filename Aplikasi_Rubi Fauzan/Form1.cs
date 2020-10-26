using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_UI_Rubi_Fauzan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 fr2 = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            UserBox.Clear();

            pictureBox1.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.login1;
            panel1.BackColor = Color.FromArgb(145, 141, 222);
            UserBox.ForeColor = Color.FromArgb(145, 141, 222);

            pictureBox3.Image = Aplikasi_Rubi_Fauzan.Properties.Resources._lock;
            panel2.BackColor = Color.WhiteSmoke;
            PassBox.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            PassBox.Clear();
            PassBox.UseSystemPasswordChar = true;
            pictureBox3.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.lock1;
            panel2.BackColor = Color.FromArgb(145, 141, 222);
            PassBox.ForeColor = Color.FromArgb(145, 141, 222);

            pictureBox1.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.login;
            panel1.BackColor = Color.WhiteSmoke;
            UserBox.ForeColor = Color.WhiteSmoke;
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.ImageIndex = 1;
            else
                checkBox1.ImageIndex = 0;

            if (checkBox1.Checked)
                PassBox.UseSystemPasswordChar = false;
            else
                PassBox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == "admin" || UserBox.Text == "admin")
            {
                this.Hide();
                Form2 fr2 = new Form2(UserBox.Text);
                fr2.ShowDialog();
                Close(); } 
            
            
            else
            {
                MessageBox.Show("Isi Username dan Password dengan benar","Perhatian!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(145, 141, 222);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
