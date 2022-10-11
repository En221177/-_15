using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Form0919
{
    public partial class Homework2_1 : Form
    {
        Frm_Homework2 f1;


        public Homework2_1(Frm_Homework2 Frm2)
        {
            InitializeComponent();
            this .f1 = Frm2;

        }

        private void Homework2_1_Load(object sender, EventArgs e)
        {
            txtPrice_1.Text = f1.result;
            textBox1.Text = f1.totalInterest;

        }

        

        //    public partial class Homework2_2       
        //    {



        ////Frm_Homework2 hm = new Frm_Homework2();

        ////object price = hm.Price;
        ////object rate = hm.Rate;
        ////object year = hm.Year;

        ////txtPrice_1.Text = price.ToString(); 



        //     }

        //private void txtPrice_1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
