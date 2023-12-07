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

namespace _5_4
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

            double p = Convert.ToDouble(Rezult_a.Text);
            int k = 1;
            double d = 10, s = 10;
            while (s <= 200)
            {
                ++k;
                d += d * p / 100;
                s += d;
            }
            TextBlockAnswer.Text = $"{k},{s}";
        }
    }
}
