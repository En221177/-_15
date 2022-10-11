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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        decimal Num1, Num2, Ans;

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtInput1.Text);
            Num2 = decimal.Parse(txtInput2.Text);
            Ans = Num1 * Num2;
            txtAnswer.Text = Ans.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtInput1.Text);
            Num2 = decimal.Parse(txtInput2.Text);
            Ans = Num1 / Num2;
            txtAnswer.Text = Ans.ToString();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtInput1.Text);
            Num2 = decimal.Parse(txtInput2.Text);
            Ans = Num1 - Num2;
            txtAnswer.Text = Ans.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Num1 = decimal.Parse(txtInput1.Text);
            Num2 = decimal.Parse(txtInput2.Text);
            Ans = Num1 + Num2;
            txtAnswer.Text = Ans.ToString();
        }
    }
}
