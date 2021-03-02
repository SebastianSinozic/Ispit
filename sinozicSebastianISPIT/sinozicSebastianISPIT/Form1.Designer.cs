
namespace sinozicSebastianISPIT
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.UnesiBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 301);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // UnesiBtn
            // 
            this.UnesiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UnesiBtn.Location = new System.Drawing.Point(12, 375);
            this.UnesiBtn.Name = "UnesiBtn";
            this.UnesiBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnesiBtn.Size = new System.Drawing.Size(257, 47);
            this.UnesiBtn.TabIndex = 1;
            this.UnesiBtn.Text = "Unesi";
            this.UnesiBtn.UseVisualStyleBackColor = true;
            this.UnesiBtn.Click += new System.EventHandler(this.UnesiBtn_Click);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ObrisiBtn.Location = new System.Drawing.Point(531, 375);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(257, 47);
            this.ObrisiBtn.TabIndex = 2;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = true;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UnesiBtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button UnesiBtn;
        private System.Windows.Forms.Button ObrisiBtn;
    }
}

