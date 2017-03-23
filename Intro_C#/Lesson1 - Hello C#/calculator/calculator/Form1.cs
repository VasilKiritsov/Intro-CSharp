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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            var a = decimal.Parse(firstNumber.Text);
            var b = decimal.Parse(secondNumber.Text);
            var finalResult = a + b;
            this.result.Text = finalResult.ToString();
        }
    }
}
