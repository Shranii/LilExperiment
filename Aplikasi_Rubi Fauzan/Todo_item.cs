using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Rubi_Fauzan
{
    public partial class Todo_item : UserControl
    {
        public Todo_item()
        {
            InitializeComponent();
        }
        public Todo_item(string Text,string Key, bool Checked)
        {
            key = Key;
            value = Text;
            InitializeComponent();
            label_item.Text = Text;
            check.Checked = Checked;
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                label_item.Font = new Font(label_item.Font.Name, label_item.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                label_item.Font = new Font(label_item.Font.Name, label_item.Font.SizeInPoints, FontStyle.Regular);
            }
            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void Todo_item_load(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                label_item.Font = new Font(label_item.Font.Name, label_item.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                label_item.Font = new Font(label_item.Font.Name, label_item.Font.SizeInPoints, FontStyle.Regular);
            }
            

        }


        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;
        public string key = null;
        public string value = null;

        private void del_Click(object sender, EventArgs e)
        {
            label_item.Text = "Deleted";
            this.BackColor = Color.Tomato;

            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }

    }
}
