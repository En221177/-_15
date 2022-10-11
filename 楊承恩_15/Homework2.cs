using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form0919
{

    public partial class Frm_Homework2 : Form
    {
        internal string result = "\n";
        homework2 hw;
        int num;
        decimal Interest, price, Price, EveryMonth, MountiyPay;
        internal string totalInterest;
        


        // public object Price { get; internal set; }

        public Frm_Homework2()
        {
            InitializeComponent();
        }

        public void btnMonthly_Click(object sender, EventArgs e)

        {
            hw.Price = decimal.Parse(txtPrice.Text);
            hw.Month = decimal.Parse(txtYear.Text);
            hw.Rate = decimal.Parse(txtRate.Text);

            decimal EveryMonth = hw.Price / hw.Month + 0.5m;
            hw.Rate = hw.Rate / 1200;


            for (decimal i = 0; i < hw.Month; i++)
            {
                num += 1;
                price = hw.Price;
                Interest = price * hw.Rate + 0.5m;
                price = hw.Price -= EveryMonth;
                MountiyPay = EveryMonth + Interest;


                totalInterest += Interest;

                result += $"\n期數:{num}償還本金:{EveryMonth}, 償還利息:{Interest}, 本期應繳金額{MountiyPay}\r\n"; 
            }
            
           

            Homework2_1 hwk2_1 = new Homework2_1(this);
            hwk2_1.ShowDialog();



        }

        


        // public void btnTatol_Click(object sender, EventArgs e)
        //{
        //    decimal Price = decimal.Parse(txtPrice.Text);
        //    decimal Rate = decimal.Parse(txtRate.Text);
        //    decimal Dowmpay = decimal.Parse (txtDownpay.Text);
        //    decimal Year = decimal.Parse(txtYear.Text);

        //    decimal rate = (Price - Dowmpay) * (Rate / 100);
        //    decimal Pay = (Price + Dowmpay + rate);
        //    string result = Pay + "元";
        //    MessageBox.Show(result);

             
        //}

        //private void btnExport_Click(object sender, EventArgs e)
        //{
        //    Homework2_1 hwk2_1 = new Homework2_1(this);
        //    hwk2_1.ShowDialog();           //將表單顯示為強制回應對話方塊
        //}
    }

 }    
