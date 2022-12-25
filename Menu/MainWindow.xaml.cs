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
       
        List<string> price1 = new List<string>() { "580", "690", "700", "890", "1620", "350", "490", "790", "490", "990" };
        List<string> price2 = new List<string>() { "590", "720", "500", "250", "620", "450", "560", "320" };
        List<string> price3 = new List<string>() { "380", "270", "345", "150", "150", "400" };

        private string strin;
        public MainWindow()
        {
            InitializeComponent();
            lv1.ItemsSource = list1;
            lv2.ItemsSource = list2;
            lv3.ItemsSource = list3;
            ShowPrice();


        }
        public void ShowPrice()
        {
            
            MessageBox.Show(""+ lv1.Items[0] + " "+ price1[0]);

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
