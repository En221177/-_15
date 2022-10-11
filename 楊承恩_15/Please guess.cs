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
    public partial class Please_guess : Form
    {

        
        public Please_guess()
        {
            InitializeComponent();

            Random random = new Random();
            a = random.Next(100);
           


        }

        int min =1 ;
        int max =100;
        

        int i, a;



        private void btnEnter_Click(object sender, EventArgs e)
        {
            //       Guess guess = new Guess();

     

                i = int.Parse(txtInput.Text);

                if (i >= min && i <= max)
                { 
                
                //Guess.test.labShow.Text = "range"+ min.ToString()+"-" +max.ToString();


                    if (i == a)
                    {
                        guess.test.labShow.Text = "Good";
                    }
                    else if (i < a)
                    {
                    min =i;
                    guess.test.labShow.Text = "Too small!!! between " + min + " to " + max;
                   
                    }
                    else if (i > a)
                    {
                        max = i;
                        guess.test.labShow.Text = "Too Large!!! between " + min + " to " + max;
                        
                    }
                }
                else
                {
                    guess.test.labShow.Text = "between" + min +  "-"+max + "!!!!!!!!!!!!!!!";
                }
           
          
             
        
        }

    }


}
