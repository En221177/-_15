using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class guess : Form
    {

        public static guess test;
        public guess()
        {
            InitializeComponent();
            test = this;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Please_guess Frm_please_Guess = new Please_guess();
            Frm_please_Guess.ShowDialog();
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Random R_num = new Random();
            int num = R_num.Next(100);
            MessageBox.Show("Answer is "+ num);
        }



    }
}
