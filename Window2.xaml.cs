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
using System.Windows.Shapes;

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z, D, x1, x2;
            x = Convert.ToDouble(textBox.Text);
            y = Convert.ToDouble(textBox1.Text);
            z = Convert.ToDouble(textBox1_Copy.Text);

            D = Math.Pow(y, 2) - 4 * x * z;
            if (D > 0 || D == 0)
            {
                x1 = (-y + Math.Sqrt(D)) / (2 * x);
                x2 = (-y - Math.Sqrt(D)) / (2 * x);
                label2.Content = "Решение: " + "x1 = " + x1 + "  x2 = " + x2;

            }
            else
            {
                label2.Content = "Решение: Действительных корней нет";
            }
        }
    }
}
