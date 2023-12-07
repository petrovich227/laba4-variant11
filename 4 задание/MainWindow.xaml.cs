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

namespace _4_4
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
            int k = 0;
            while (n <= 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            int a = 3;
            if (Log(n) % Log(a) == 0)
                TextBlockAnswer.Text = $" true";
            else
                TextBlockAnswer.Text = $"false";
        }
    }
}

