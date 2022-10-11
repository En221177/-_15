using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentGrade.Gra;

namespace StudentGrade
{
    public partial class studentGrade : Form
    {
        public studentGrade()
        {
            InitializeComponent();
            listshow.Items.Add("姓名      國文       英文        數學           總分       平均           最低        最高");
        }
        

        int Chin, Engl, Math ,sum,i, SumC, SumE, SumM, avgC, avgE, avgM;
        int maxC = 0;
        int minC = 100;
        int maxE = 0;
        int minE = 100;
        int maxM = 0;
        int minM = 100;

        int j = 1;
        int k = 0;
        string Nam, resuitMax, resuitMin;      
        decimal avg;

        Grade[,] gra = new Grade[4, 100];


        //*********************************************************加入學生資料

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            Nam = txtName.Text;
            Chin = Convert.ToInt32(txtChi.Text);
            Engl = Convert.ToInt32(txtEng.Text);
            Math = Convert.ToInt32(txtMat.Text);

            ar();

        }


        //***********************************************************隨機加入資料
        private void btnRand1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rc = random.Next(101);
            int re = random.Next(101);
            int rm = random.Next(101);

            Nam =j.ToString();
            Chin =rc;
            Engl = re;
            Math = rm;

            ar();

        }



        //*************************************************************隨機加入20筆

        private void btnRand20_Click(object sender, EventArgs e)
        {
            
            
            
            for (int q = 0; q<20; q++)
            {
                
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int rc = random.Next(101);
                int re = random.Next(101);
                int rm = random.Next(101);

                Nam = j.ToString();
                Chin = rc;
                Engl = re;
                Math = rm;

                ar();
            }
        }

        //***************************************************************各科統計
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            listshow2.Items.Clear();
            listshow2.Items.Add($"\t國文       英文        數學\n");
            listshow2.Items.Add($"Sum\t{SumC}\t{SumE}\t{SumM}\n");
            listshow2.Items.Add($"Avg\t{avgC}\t{avgE}\t{avgM}\n");
            listshow2.Items.Add($"Max\t{maxC}\t{maxE}\t{maxM}");
            listshow2.Items.Add($"Min\t{minC}\t{minE}\t{minM}");
            
        }

        //***************************************************************Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(gra, 0, gra.Length);
            listshow.Items.Clear();
            listshow2.Items.Clear();
            Chin = Engl = Math = sum = i = SumC = SumE = SumM = avgC = avgE  =avgM =
            maxC = maxE = maxM = k = 0;
            minC = minE = minM = 100;
            j = 1;

            listshow.Items.Add("姓名      國文       英文        數學           總分       平均           最低        最高");

        }

        //***************************************************************陣列
        void ar()
        {
            

            gra[0, k] = new Grade();
            gra[1, k] = new Grade();
            gra[2, k] = new Grade();
            gra[3, k] = new Grade();

            gra[0, k].Name = Nam;
            gra[1, k].Chi = Chin;
            gra[2, k].Eng = Engl;
            gra[3, k].Mat = Math;

            sum = gra[1, k].Chi + gra[2, k].Eng + gra[3, k].Mat;
            avg = (gra[1, k].Chi + gra[2, k].Eng + gra[3, k].Mat) / 3;




            if (gra[1, k].Chi > gra[2, k].Eng && gra[1, k].Chi > gra[3, k].Mat)
            {
                resuitMax = "國文:" + gra[1, k].Chi;
            }

            else if (gra[2, k].Eng > gra[1, k].Chi && gra[2, k].Eng > gra[3, k].Mat)
            {
                resuitMax = "英文:" + gra[2, k].Eng;
            }

            else if (gra[3, k].Mat > gra[1, k].Chi && gra[3, k].Mat > gra[2, k].Eng)
            {
                resuitMax = "數學:" + gra[3, k].Mat;
            }


            if (gra[1, k].Chi < gra[3, k].Mat && gra[1, k].Chi < gra[2, k].Eng)
            {
                resuitMin = "國文:" + gra[1, k].Chi;
            }

            else if (gra[2, k].Eng < gra[1, k].Chi && gra[2, k].Eng < gra[3, k].Mat)
            {
                resuitMin = "英文:" + gra[2, k].Eng;
            }

            else if (gra[3, k].Mat < gra[1, k].Chi && gra[3, k].Mat < gra[2, k].Eng)
            {
                resuitMin = "數學:" + gra[3, k].Mat;
            }

            listshow.Items.Add($"{gra[0, k].Name}\t{gra[1, k].Chi}\t{gra[2, k].Eng}\t{gra[3, k].Mat}\t" +
                $"{sum}\t{avg}\t{resuitMin}\t{resuitMax}");
                        

            SumC += gra[1, k].Chi;
            SumE += gra[2, k].Eng;
            SumM += gra[3, k].Mat;
            avgC = SumC / j;
            avgE = SumE/j;
            avgM = SumM/j;


            if (gra[1,k].Chi > maxC)
            {
                maxC = gra[1, k].Chi;
            }
            if (gra[1, k].Chi < minC)
            {
                minC = gra[1, k].Chi;
            }
            if(gra[2, k].Eng > maxE)
            {
                maxE = gra[2, k].Eng;
            }
            if (gra[2, k].Eng < minE)
            {
                minE = gra[2, k].Eng;
            }
            if(gra[3, k].Mat >maxM)
            {
                maxM = gra[3, k].Mat;
            }
            if (gra[3, k].Mat < minM)
            {
                minM = gra[3, k].Mat;
            }

            k++;
            j++;        
            
        }


    }
}
