using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Rubi_Fauzan
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int poss = 10;
        public void addItem(string Text,string Key, bool Checked)
        {
            Todo_item item = new Todo_item(Text, Key, Checked);
            panel3.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void Item_onChange(object sender, EventArgs e)
        {

        }
        private void Item_onDelete(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            addItem(txt.Text,"0", false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_MouseClick(object sender, MouseEventArgs e)
        {
            txt.Clear();
        }
    }
}
