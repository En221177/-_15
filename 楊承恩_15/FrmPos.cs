using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS1
{
    public partial class FrmPos : Form
    {
        public FrmPos()
        {
            InitializeComponent();
        }

        decimal BeerNum, BeerPrice, TqlPrice, TqlNum,WskNum, WskPrice, WineNum, WinePrice, result1, result2;
        string  resultWine1, resultWhisken1, resultTequila1, resultBeer1;
        decimal Beer = 120, Tql =180, Wsk = 350, Wine = 320;





        private void btnClear_Click(object sender, EventArgs e)
        {

            WinePrice = 0;
            WineNum = 0;
            resultWine1 = $"Wine數量{WineNum}, 單價:{Wine}, 總價:{WinePrice}\n";
            txtList.Text = resultWine1;
            result1 = 0;
            txtPrice.Text = "NT" + result1.ToString();

            WskPrice = 0;
            WskNum = 0;
            resultWhisken1 = $"Whisken數量{WskNum}, 單價:{Wsk}, 總價:{WskPrice}\n";
            txtList.Text = resultWhisken1;
            result1 = 0;
            txtPrice.Text = "NT" + result1.ToString();

            TqlPrice = 0;
            TqlNum = 0;
            resultTequila1 = $"Tequila數量{TqlNum}, 單價:{Tql}, 總價:{TqlPrice}\n";
            txtList.Text = resultTequila1;
            result1 = 0;
            txtPrice.Text = "NT" + result1.ToString();
            
            BeerPrice = 0;
            BeerNum =0;
            resultBeer1 = $"Beer數量{BeerNum}, 單價:{Beer}, 總價:{BeerPrice}";
            txtList.Text = resultBeer1;
            result1 =0;
            txtPrice.Text = "NT" + result1.ToString();


            txtList.Clear();
            //txtPrice.Clear();
            //txtList.ResetText();


        }








        private void btnCard_Click(object sender, EventArgs e)
        {
            result2 = result1 * 0.9M;
            txtPrice.Text = result2.ToString();
            MessageBox.Show("信用卡打折: NT" + result2.ToString() );
        }
       

        private void btnCash_Click(object sender, EventArgs e)
        {
            result1=BeerPrice + TqlPrice+ WskPrice+ WinePrice;
            txtPrice.Text = "NT"+ result1.ToString();
            MessageBox.Show("現金: NT" + result1.ToString() );
        }
      







        private void btnWine_Click(object sender, EventArgs e)
        
        
        {
            
            WinePrice += Wine;
            WineNum ++ ;

            resultWine1 = $"Wine數量{WineNum}, 單價:{Wine}, 總價:{WinePrice}\n";
            resultWhisken1 = $"Whisken數量{WskNum}, 單價:{Wsk}, 總價:{WskPrice}\n";
            resultTequila1 = $"Tequila數量{TqlNum}, 單價:{Tql}, 總價:{TqlPrice}\n";
            resultBeer1 = $"Beer數量{BeerNum}, 單價:{Beer}, 總價:{BeerPrice}";
            txtList.Text = resultWhisken1 +Environment.NewLine + resultTequila1 + Environment.NewLine + resultBeer1 + Environment.NewLine + resultWine1;
            result1 = BeerPrice + TqlPrice + WskPrice + WinePrice;
            txtPrice.Text = "NT" + result1.ToString();

        }

        private void btnWsk_Click(object sender, EventArgs e)
        {
        
            WskPrice += Wsk;
            WskNum ++;

            resultWine1 = $"Wine數量{WineNum}, 單價:{Wine}, 總價:{WinePrice}\n";
            resultWhisken1 = $"Whisken數量{WskNum}, 單價:{Wsk}, 總價:{WskPrice}\n";
            resultTequila1 = $"Tequila數量{TqlNum}, 單價:{Tql}, 總價:{TqlPrice}\n";
            resultBeer1 = $"Beer數量{BeerNum}, 單價:{Beer}, 總價:{BeerPrice}";
            txtList.Text = resultWhisken1 + Environment.NewLine + resultTequila1 + Environment.NewLine + resultBeer1 + Environment.NewLine + resultWine1;
            result1 = BeerPrice + TqlPrice + WskPrice + WinePrice;
            txtPrice.Text = "NT" + result1.ToString();
        }

        

        private void btnTql_Click(object sender, EventArgs e)
        {
            
            TqlPrice += Tql;
            TqlNum ++;

            resultWine1 = $"Wine數量{WineNum}, 單價:{Wine}, 總價:{WinePrice}\n";
            resultWhisken1 = $"Whisken數量{WskNum}, 單價:{Wsk}, 總價:{WskPrice}\n";
            resultTequila1 = $"Tequila數量{TqlNum}, 單價:{Tql}, 總價:{TqlPrice}\n";
            resultBeer1 = $"Beer數量{BeerNum}, 單價:{Beer}, 總價:{BeerPrice}";
            txtList.Text = resultWhisken1 +Environment.NewLine + resultTequila1 + Environment.NewLine + resultBeer1 + Environment.NewLine + resultWine1;
            result1 = BeerPrice + TqlPrice + WskPrice + WinePrice;
            txtPrice.Text = "NT" + result1.ToString();
        }

        

        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeerPrice += Beer;
            BeerNum ++;

            resultWine1 = $"Wine數量{WineNum}, 單價:{Wine}, 總價:{WinePrice}\n";
            resultWhisken1 = $"Whisken數量{WskNum}, 單價:{Wsk}, 總價:{WskPrice}\n";
            resultTequila1 = $"Tequila數量{TqlNum}, 單價:{Tql}, 總價:{TqlPrice}\n";
            resultBeer1 = $"Beer數量{BeerNum}, 單價:{Beer}, 總價:{BeerPrice}";
            txtList.Text = resultWhisken1 + Environment.NewLine + resultTequila1 + Environment.NewLine + resultBeer1 + Environment.NewLine + resultWine1;
            result1 = BeerPrice + TqlPrice + WskPrice + WinePrice;
            txtPrice.Text = "NT" + result1.ToString();
        }
       

    }
}
