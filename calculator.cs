using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int result = a + b;
            txtResult.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int result = a - b;
            txtResult.Text = result.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int result = a * b;
            txtResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            if (b == 0)
            {
                MessageBox.Show("Cannot divide by zero");
            }
            else
            {
                int result = a / b;
                txtResult.Text = result.ToString();
            }
        
    }
    }
}
