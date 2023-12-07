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

namespace _1_4
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

            double nn = Convert.ToDouble(Rezult_a.Text);

            string m = " ";
            switch (nn)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    m = "в месяце 31 день";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    m = "в месяце 30 дней";
                    break;
                case 2:
                    m = "в месяце 28 дней";
                    break;
            }


            TextBlockAnswer.Text = $"{m}";
        }
    }
}
