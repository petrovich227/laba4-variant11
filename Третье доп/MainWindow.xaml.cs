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

namespace _9_4
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(Rezult_a.Text);
            int B = int.Parse(Rezult_b.Text);




            int remainder = 0;
            while (B != 0)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }



            TextBlockAnswer.Text = "НОД: " + A;
        }
    }
}
