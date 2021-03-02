
namespace sinozicSebastianISPIT
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OkBtn.Location = new System.Drawing.Point(32, 383);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(260, 44);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(511, 383);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(260, 44);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(32, 39);
            this.textBoxIme.Multiline = true;
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(260, 29);
            this.textBoxIme.TabIndex = 2;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(32, 108);
            this.textBoxPrezime.Multiline = true;
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(260, 29);
            this.textBoxPrezime.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(32, 189);
            this.textBoxOIB.Multiline = true;
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(260, 29);
            this.textBoxOIB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "OIB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(29, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Godina rođenja:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}