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
using static System.Math;

namespace _3_4
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

            double n = Convert.ToDouble(Rezult_a.Text);
            double x = Convert.ToDouble(Rezult_b.Text);
            double a = 0, c = 0, h = 0, S = 0;
            switch (n)
            {
                case 1:
                    a = x;
                    c = a * Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    break;
                case 2:
                    c = x;
                    a = c / Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    break;
                case 3:
                    h = x;
                    c = 2 * h;
                    a = c / Sqrt(2);
                    S = c * h / 2;
                    break;
                case 4:
                    S = x;
                    h = Sqrt(S);
                    c = 2 * h;
                    a = c / Sqrt(2);
                    break;

            }
            TextBlockAnswer.Text = $"Длина катета равна: {a}\n Гипатенуза равна: {c}\n Высота опущенная на гипотенузу равна: {h}\n Площадь равна: {S}";
        }
    }
}
