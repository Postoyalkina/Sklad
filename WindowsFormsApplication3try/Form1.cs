using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3try
{
    public partial class Form1 : Form
    {
        Sklad tempSklad = new Sklad();
        public Form1()
        {
            InitializeComponent();       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(CoastBox.Text);
                Tovar tempTovar = new Tovar(NameBox.Text, ShopBox.Text, Convert.ToDouble(CoastBox.Text));
                tempSklad.Add(tempTovar);
                NameBox.Clear();
                ShopBox.Clear();
            }
            catch { string er = "Неверное введено значение"; MessageBox.Show(er); }
            finally { CoastBox.Clear(); }
            List<Tovar> listOfTovar = new List<Tovar>(tempSklad.Get());
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("№");
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Магазин");
            listView1.Columns.Add("Цена");
            listView1.Columns[listView1.Columns.Count - 1].Width = 90;
            listView1.Columns[listView1.Columns.Count - 2].Width = 123;
            listView1.Columns[listView1.Columns.Count - 3].Width = 123;
            listView1.Columns[listView1.Columns.Count - 4].Width = 30;
            for (int i = 0; i < listOfTovar.Count; i++)
            {
                listView1.Items.Add(Convert.ToString(i + 1));
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameP);
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameSh);
                listView1.Items[i].SubItems.Add(Convert.ToString(listOfTovar[i].Coast));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {          
        }
        private void SortN_Click(object sender, EventArgs e)
        {
            tempSklad.SortName();
            listView1.Clear();
            List<Tovar> listOfTovar = new List<Tovar>(tempSklad.Get());
            listView1.Columns.Add("№");
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Магазин");
            listView1.Columns.Add("Цена");
            listView1.Columns[listView1.Columns.Count - 1].Width = 90;
            listView1.Columns[listView1.Columns.Count - 2].Width = 123;
            listView1.Columns[listView1.Columns.Count - 3].Width = 123;
            listView1.Columns[listView1.Columns.Count - 4].Width = 30;
            for (int i = 0; i < listOfTovar.Count; i++)
            {
                listView1.Items.Add(Convert.ToString(i + 1));
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameP);
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameSh);
                listView1.Items[i].SubItems.Add(Convert.ToString(listOfTovar[i].Coast));
            }
        }
        private void SortSh_Click(object sender, EventArgs e)
        {
            tempSklad.SortShop();
            listView1.Clear();
            List<Tovar> listOfTovar = new List<Tovar>(tempSklad.Get());
            listView1.View = View.Details;
            listView1.Columns.Add("№");
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Магазин");
            listView1.Columns.Add("Цена");
            listView1.Columns[listView1.Columns.Count - 1].Width = 90;
            listView1.Columns[listView1.Columns.Count - 2].Width = 123;
            listView1.Columns[listView1.Columns.Count - 3].Width = 123;
            listView1.Columns[listView1.Columns.Count - 4].Width = 30;
            for (int i = 0; i < listOfTovar.Count; i++)
            {
                listView1.Items.Add(Convert.ToString(i + 1));
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameP);
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameSh);
                listView1.Items[i].SubItems.Add(Convert.ToString(listOfTovar[i].Coast));
            }
        }
        private void SortP_Click(object sender, EventArgs e)
        {
            tempSklad.SortPrice();
            listView1.Clear();
            List<Tovar> listOfTovar = new List<Tovar>(tempSklad.Get());
            listView1.View = View.Details;
            listView1.Columns.Add("№");
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Магазин");
            listView1.Columns.Add("Цена");
            listView1.Columns[listView1.Columns.Count - 1].Width = 90;
            listView1.Columns[listView1.Columns.Count - 2].Width = 123;
            listView1.Columns[listView1.Columns.Count - 3].Width = 123;
            listView1.Columns[listView1.Columns.Count - 4].Width = 30;
            for (int i = 0; i < listOfTovar.Count; i++)
            {
                listView1.Items.Add(Convert.ToString(i + 1));
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameP);
                listView1.Items[i].SubItems.Add(listOfTovar[i].NameSh);
                listView1.Items[i].SubItems.Add(Convert.ToString(listOfTovar[i].Coast));
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int16.Parse(TextSearh.Text);
                InfBox1.Clear();
                List<Tovar> listOfTovar = new List<Tovar>();
                InfBox1.Text = tempSklad.InfIndex(Convert.ToInt16(TextSearh.Text));
            }
            catch { string er = "Неверное введено значение"; MessageBox.Show(er); }
            finally { TextSearh.Clear(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfBox1.Clear();
            List<Tovar> listOfTovar = new List<Tovar>();
            InfBox1.Text = tempSklad.InfName(TextSearh.Text);
            TextSearh.Clear();
        }
    }
}
