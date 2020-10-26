namespace Aplikasi_Rubi_Fauzan
{
    partial class Todo_item
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check = new System.Windows.Forms.CheckBox();
            this.label_item = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.del)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(22, 17);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 0;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.ForeColor = System.Drawing.Color.White;
            this.label_item.Location = new System.Drawing.Point(58, 13);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(76, 18);
            this.label_item.TabIndex = 1;
            this.label_item.Text = "To do Item";
            // 
            // del
            // 
            this.del.Image = global::Aplikasi_Rubi_Fauzan.Properties.Resources.trash;
            this.del.Location = new System.Drawing.Point(439, 9);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(25, 28);
            this.del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.del.TabIndex = 2;
            this.del.TabStop = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(141)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.del);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.check);
            this.Name = "Todo_item";
            this.Size = new System.Drawing.Size(480, 48);
            ((System.ComponentModel.ISupportInitialize)(this.del)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.PictureBox del;
    }
}
