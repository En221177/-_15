using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_StructFrom
{
    public partial class FrmStudendStruct : Form
    {
        public FrmStudendStruct()
        {
            InitializeComponent();
        }


        
        string result;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal Priceresult = 0;  //接收轉換值
            bool isSUCCESS = decimal.TryParse(txtChinese.Text, out Priceresult);
            bool isSUCCESS1 = decimal.TryParse(txtEnglish.Text, out Priceresult);
            bool isSUCCESS2 = decimal.TryParse(txtMath.Text, out Priceresult);

            if (isSUCCESS && isSUCCESS1 && isSUCCESS2)
            {
                Student stu = new Student();
                stu.Name = txtName.Text;
                stu.Chinese = decimal.Parse(txtChinese.Text);
                stu.English = decimal.Parse(txtEnglish.Text);
                stu.Math = decimal.Parse(txtMath.Text);
                result = "姓名:"+stu.Name+ Environment.NewLine +"國文:"+ stu.Chinese+
                    Environment.NewLine + "英文:" +stu.English+Environment.NewLine +"數學:"+stu.Math;
            }
            else
            {
                MessageBox.Show("輸入錯誤");
                txtChinese.Clear();
                txtEnglish.Clear();
                txtMath.Clear();
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            txtShow.Text = result;
        }




        private void btnCompare_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Name = txtName.Text;
            stu.Chinese = decimal.Parse(txtChinese.Text);
            stu.English = decimal.Parse(txtEnglish.Text);
            stu.Math = decimal.Parse(txtMath.Text);

            if (stu.Chinese > stu.English && stu.Chinese > stu.Math)
            {
                txtShow1.Text = "最高分為國文:" + stu.Chinese + Environment.NewLine;
            }

            else if (stu.English > stu.Chinese && stu.English > stu.Math)
            {
                txtShow1.Text = "最高分為英文:" + stu.English + Environment.NewLine;
            }

            else if (stu.Math > stu.Chinese && stu.Math > stu.English)
            {
                txtShow1.Text = "最高分為數學:" + stu.Math + Environment.NewLine;
            }

            if (stu.Chinese < stu.Math && stu.Chinese < stu.English)
            {
                txtShow1.Text += "最低分為國文:" + stu.Chinese;
            }

            else if (stu.English < stu.Chinese && stu.English < stu.Math)
            {
                txtShow1.Text += "最低分為英文:" + stu.English;
            }

            else if (stu.Math < stu.Chinese && stu.Math < stu.English)
            {
                txtShow1.Text += "最低分為數學:" + stu.Math;
            }
        }
    }
    
}
