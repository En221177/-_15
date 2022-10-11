using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ooxx
{
    public partial class FrmOOXX : Form
    {
        public FrmOOXX()
        {
            InitializeComponent();
        }

        int k, j, total ;
        
        private void btn9_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn9.Text = (j == 0) ? "O" : "X";
            btn9.Enabled = false;
            total++;
            winner();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn8.Text = (j == 0) ? "O" : "X";
            btn8.Enabled = false;
            total++;
            winner();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn7.Text = (j == 0) ? "O" : "X";
            btn7.Enabled = false;
            total++;
            winner();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn6.Text = (j == 0) ? "O" : "X";
            btn6.Enabled = false;
            total++;
            winner();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn5.Text = (j == 0) ? "O" : "X";
            btn5.Enabled = false;
            total++;
            winner();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn4.Text = (j == 0) ? "O" : "X";
            btn4.Enabled = false;
            total++;
            winner();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn3.Text = (j == 0) ?  "O" :  "X";
            btn3.Enabled = false;
            total++;
            winner();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn2.Text = (j == 0) ? "O" : "X";
            btn2.Enabled = false;
            total++;
            winner();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            j = ++k % 2;

            btn1.Text = (j == 0) ? "O" : "X";
            btn1.Enabled = false;
            total++;
            winner();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled =
            btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
            total = 0;
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void winner()
        {
            if( btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O"||
                 btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O"||
                 btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O"||
                 btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O"||
                 btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O"||
                 btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O"||
                 btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O"||
                 btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                DialogResult dR = MessageBox.Show("O is Winner", MessageBoxButtons.OK.ToString());
                if (dR == DialogResult.OK);
                {
                    btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                    btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled =
                    btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                    total = 0;
                }
            }
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
                btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                DialogResult dR = MessageBox.Show("X is Winner", MessageBoxButtons.OK.ToString());
                if (dR == DialogResult.OK);
                {
                    btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                    btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled =
                    btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                    total = 0;
                }
            }
            else
            {
                if (total == 9)
                {
                    DialogResult dR = MessageBox.Show("平局!\n請按確定重新開始", MessageBoxButtons.OK.ToString());
                    if (dR == DialogResult.OK);
                    {
                        btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                        btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = 
                        btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
                        total = 0;
                    }
                   
                }
            }

        }

    }
}
