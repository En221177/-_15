 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form0919
{
    internal class Member           //給Frm宣告值
    {
        public string Name;
        public DateTime Birthday;
    }
   
    
    public class StaticLab
    {
        public int NoStaticCount;
        public static int StaticCount;
    }



    public enum UserRole
    {
        Admin = 1,
        User = 2,
    }



    public struct Product           //m19 struct
    {
        public string Name;
        public decimal Price;

        //public string Name { get; set; } //有設定屬性要new實作
        //public decimal Price { get; set; }


        public Product(string txtName, decimal txtPrice)
        {
            Name = txtName;
            Price = txtPrice;
        }


    }

    public struct homework2
    {
        public decimal Price, Month, Rate, Interest, price;
        
    }





}
