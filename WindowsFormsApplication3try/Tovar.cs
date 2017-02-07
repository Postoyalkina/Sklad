using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3try
{
    class Tovar
    {
        private string ProductName = string.Empty;
        private string NameOfShop = string.Empty;
        private double CoastOfGoods = 0;
        public string NameP
        {
            get
            {
                return ProductName;
            }
        }
        public string NameSh
        {
            get
            {
                return NameOfShop;
            }
        }
        public double Coast
        {
            get
            {
                return CoastOfGoods;
            }
        }
        public string Sostoyanie
        {
            get
            {
                return string.Format("Название товара: {0}, Название магазина: {1}, Стоимость:{2}", NameP, NameSh, Coast);
            }
        }
        public Tovar(string name, string nameSh, double coast)
        {
            ProductName = name;
            NameOfShop = nameSh;
            CoastOfGoods = coast;
        }
        public static double operator +(Tovar t1, Tovar t2)
        {
            return t1.Coast + t2.Coast;
        }
    }
}
