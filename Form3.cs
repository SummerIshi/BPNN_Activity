using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPNN_Activity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 orGate = new Form1();
            orGate.Show();
        }
     
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 andGate = new Form2();
            andGate.Show();
        }
    }
}
