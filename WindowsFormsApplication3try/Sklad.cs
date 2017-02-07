using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3try
{
    class Sklad
    {
        List<Tovar> tovar = new List<Tovar>();// массив товаров

        public void Add(Tovar tvr)
        {
            tovar.Add(tvr);
        }
        public List<Tovar> Get()
        {
            return tovar;
        }
        public string InfIndex(int i)
        {
            if ((i < 1) || (i >= tovar.Count+1)) return "Такого товара нет";
            return tovar[i-1].Sostoyanie;
        }
        public string InfName(string name)
        {
            foreach(Tovar t in tovar)
            {
                if(t.NameP.Equals(name))
                {
                    return t.Sostoyanie;
                }
            }
            return "Такого товара нет";
        }

        public void SortName()
        {
            tovar.Sort(delegate (Tovar t1, Tovar t2)
            {
                return t1.NameP.CompareTo(t2.NameP);
            });
        }
        public void SortShop()
        {
            tovar.Sort(delegate (Tovar t1, Tovar t2)
            {
                return t1.NameSh.CompareTo(t2.NameSh);
            });
        }
        public void SortPrice()
        {
            tovar.Sort(delegate (Tovar t1, Tovar t2)
            {
                return t1.Coast.CompareTo(t2.Coast);
            });
        }
        public double Sum(Tovar t1, Tovar t2)
        {
            return t1 + t2;
        }
    }
}

