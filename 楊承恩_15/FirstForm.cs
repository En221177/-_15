using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form0919
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_Click(object sender, EventArgs e) 
        {
            string Name = txtName.Text;
            string Name_Eng = txtName_Eng.Text;
            MessageBox.Show("Hi," + Name + "!!!"+ Environment.NewLine + "Hi," + Name_Eng + "!!!");
        }

        private void btn_Hallo_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Name_Eng = txtName_Eng.Text;
            MessageBox.Show("Hallo," + Name + "!!!" + Environment.NewLine + "Hallo," + Name_Eng + "!!!");
        }
    }
}
