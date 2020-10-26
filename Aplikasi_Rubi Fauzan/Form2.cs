using Aplikasi_Rubi_Fauzan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_UI_Rubi_Fauzan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            openChildForm(new Aplikasi_Rubi_Fauzan.Form5());
        }
        public Form2(string Str_Value)
        {
            InitializeComponent();
            textBox1.Text = Str_Value;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.logout1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Aplikasi_Rubi_Fauzan.Properties.Resources.logout;
        }

        private void button1_Click(object sender, EventArgs e)
        {

                Form4 obj = (Form4)Application.OpenForms["Form4"];
                obj.Close();


        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Aplikasi_Rubi_Fauzan.Form4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Aplikasi_Rubi_Fauzan.Form5());
        }
    }
}
