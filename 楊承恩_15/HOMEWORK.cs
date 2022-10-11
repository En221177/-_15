using Form0919;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator;
using Guess;
using ooxx;
using POS1;
using Student_StructFrom;
using StudentGrade;

namespace 楊承恩_15
{
    public partial class HOMEWORK : Form
    {
        public HOMEWORK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstForm frm = new FirstForm();           
            DialogResult result = frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Homework2 frm = new Frm_Homework2();
            DialogResult result = frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCalculator frm = new FrmCalculator();
            DialogResult result = frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guess frm = new guess();
            DialogResult result = frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOOXX frm = new FrmOOXX();
            DialogResult result = frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPos frm = new FrmPos();
            DialogResult result = frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmStudendStruct frm = new FrmStudendStruct();
            DialogResult result = frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            studentGrade frm = new studentGrade();
            DialogResult result = frm.ShowDialog();
        }
    }
    
}
