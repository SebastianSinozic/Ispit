using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinozicSebastianISPIT
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void UnesiBtn_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.ShowDialog();
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
