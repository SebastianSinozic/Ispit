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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Close();
            forma2.Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Close();
            forma2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
