using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list1 = new List <string>() { "Бургер","Гамбургер","Чизбургер","Пицца","Суши","Крылышки","Острые крылышки","Нагетсы","Картошка фри","Шашлык"};
        List<string> list2 = new List<string>() { "Кола","Пепси","Лимонад","Вода","Спрайт","Фанта","Квас","Минералка"};
        List<string> list3 = new List<string>() { "Тар-тар", "Чесночный", "Кетчуп", "Майонез", "Сырный" };

        List<string[]> ls = new List<string[]> { 
            new string[] { "Бургер", "580" },
            new string[] { "Гамбургер", "690" },
            new string[] { "Чизбургер", "700" },
            new string[] { "Пицца", "890" },

        };
        List<string> price1 = new List<string>() { "580", "690", "700", "890", "1620", "350", "490", "790", "490", "990" };
        List<string> price2 = new List<string>() { "590", "720", "500", "250", "620", "450", "560", "320" };
        List<string> price3 = new List<string>() { "380", "270", "345", "150", "150", "400" };

        private string strin;
        public MainWindow()
        {
            InitializeComponent();
            LoadData2(ls, lv1);
            LoadData(list2, price2, lv2);
            LoadData(list3, price3, lv3);
        }
        //этот код писал НЕ МАТВЕЙ
        private void AddToCart(object sender, MouseButtonEventArgs e)
        {
            ListView lv = (ListView)sender;

            List<string[]> ls = new List<string[]>();

            string[] item = lv.SelectedItem.ToString().Split('-');
            int count = 0;

            if (lv4.Items.Count > 1)
            {
                for (int i = 0; i < lv4.Items.Count; i++)
                {
                    string[] s = lv4.Items[i].ToString().Split('-');
                    ls.Add(s);
                }

                int index = ls.IndexOf(item);
                MessageBox.Show(ls[index].ToString());

                for (int i = 0; i < lv4.Items.Count; i++)
                {
                    if (ls[i][0] == item[0])
                    {
                        count++;

                        lv4.Items[index] = $"{item[0]}-{count}";
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                lv4.Items.Add($"{item[0]}-{count}");
            }


            //if (lv4.Items.Contains(lv.SelectedItem.ToString().Split('-')[0]))
            //{
            //    int i = lv4.Items.IndexOf(lv.SelectedItem.ToString().Split('-')[0]);

            //    int count;
            //    int.TryParse(lv4.Items.ToString().Split('-')[1], out count);

            //    lv4.Items[i] = $"{lv.SelectedItem} x{count++}";
            //}
            //else
            //{
            //    string s = $"{lv.SelectedItem.ToString().Split('-')[0]} - 1";
            //    lv4.Items.Add(s);
            //}
        }
        private void LoadData(List<string> names, List<string> price, ListView lv)
        {
            for (int i = 0; i < names.Count; i++)
            {
                lv.Items.Add($"{names[i]} - {price[i]}");
            }
        }
        private void LoadData2(List<string[]> data, ListView lv)
        {
            foreach (var item in data)
            {
                lv.Items.Add($"{item[0]}-{item[1]}");
            }
        }
    }
    //public void LoadFile()
    //{
    //    int i = 0;
    //    StreamReader pathFile = new StreamReader("C:\\Users\\BOBA4\\source\\temp\\rgb.txt");
    //    StreamReader pathFile1 = new StreamReader("C:\\Users\\BOBA4\\source\\temp\\rgb1.txt");
    //    string stroka;
    //    while (pathFile.EndOfStream != true)
    //    {
    //        i++;
    //        stroka = pathFile.ReadLine();
    //        listV.Items.Add(stroka);
    //    }
    //    pathFile.Close();
    //    string stroka1;
    //    while (pathFile1.EndOfStream != true)
    //    {
    //        i++;
    //        stroka1 = pathFile1.ReadLine();
    //        listV1.Items.Add(stroka1);
    //    }
    //    pathFile1.Close();
    //}
    
}
