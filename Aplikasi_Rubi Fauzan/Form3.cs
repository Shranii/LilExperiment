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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form2 fr2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {

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

            pictureBox4.Image = Aplikasi_Rubi_Fauzan.Properties.Resources._lock;
            panel3.BackColor = Color.WhiteSmoke;
            ConPassBox.ForeColor = Color.WhiteSmoke;
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

            pictureBox4.Image = Aplikasi_Rubi_Fauzan.Properties.Resources._lock;
            panel3.BackColor = Color.WhiteSmoke;
            ConPassBox.ForeColor = Color.WhiteSmoke;
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
         
            {
                MessageBox.Show("idk how to do online database... you can login with admin tho", "oh no", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ConPassBox_Click(object sender, EventArgs e)
        {
            ConPassBox.Clear();
            ConPassBox.UseSystemPasswordChar = true;
            pictureBox4.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.lock1;
            panel3.BackColor = Color.FromArgb(145, 141, 222);
            ConPassBox.ForeColor = Color.FromArgb(145, 141, 222);

            pictureBox1.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.login;
            panel1.BackColor = Color.WhiteSmoke;
            UserBox.ForeColor = Color.WhiteSmoke;

            pictureBox3.Image = Aplikasi_Rubi_Fauzan.Properties.Resources._lock;
            panel2.BackColor = Color.WhiteSmoke;
            PassBox.ForeColor = Color.WhiteSmoke;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox2.ImageIndex = 1;
            else
                checkBox2.ImageIndex = 0;

            if (checkBox2.Checked)
                ConPassBox.UseSystemPasswordChar = false;
            else
                ConPassBox.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
            this.Close();
        }
    }
}
