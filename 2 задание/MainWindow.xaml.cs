using System;
using System.Collections.Generic;
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

namespace _2_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Button_Click(object sender, EventArgs e)
        {

            double years = Convert.ToDouble(Rezult_a.Text);
            string s1 = " ";
            string s2 = " ";
            string s3 = " ";
            switch (years / 10)
            {
                case 2:
                    s1 = ("двадцать ");
                    break;
                case 3:
                    s1 = ("тридцать ");
                    break;
                case 4:
                    s1 = ("сорок ");
                    break;
                case 5:
                    s1 = ("пятдесят ");
                    break;
                case 6:
                    s1 = ("шестьдесят ");
                    break;
            }

            switch (years % 10)
            {
                case 1:
                    s2 = ("один ");
                    break;
                case 2:
                    s2 = ("два ");
                    break;
                case 3:
                    s2 = ("три ");
                    break;
                case 4:
                    s2 = ("четыре ");
                    break;
                case 5:
                    s2 = ("пять ");
                    break;
                case 6:
                    s2 = ("шесть ");
                    break;
                case 7:
                    s2 = ("семь ");
                    break;
                case 8:
                    s2 = ("восемь ");
                    break;
                case 9:
                    s2 = ("девять ");
                    break;
            }

            switch (years % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    s3 = "лет. ";
                    break;
                case 1:
                    s3 = "год.\n ";
                    break;
                case 2:
                case 3:
                case 4:
                    s3 = "года.\n ";
                    break;
            }


            TextBlockAnswer.Text = $"{s1} {s2} {s3}";
        }
    }
}