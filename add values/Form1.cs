using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(number1.Text);
            int b = Convert.ToInt32(number2.Text);
            int y = Convert.ToInt32(number3.Text);
            int z = Convert.ToInt32(number4.Text);
            lbxOutput.Items.Add (a + b + y + z);
        }


        private void button_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(number1.Text);
            int b = Convert.ToInt32(number2.Text);

            int y = Convert.ToInt32(number3.Text);
            int z = Convert.ToInt32(number4.Text);
            lbxOutput.Items.Add(a * b * y * z);
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(number1.Text);
            float b = Convert.ToInt32(number2.Text);
            float y = Convert.ToInt32(number3.Text);
            float z = Convert.ToInt32(number4.Text);
            float Avg = (a + b + y + z)/4;
            lbxOutput.Items.Add(Avg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
