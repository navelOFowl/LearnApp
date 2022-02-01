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

namespace LearnApp
{
    /// <summary>
    /// Логика взаимодействия для AdminCheck.xaml
    /// </summary>
    public partial class AdminCheck : Window
    {
        public AdminCheck()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TbCode.Text == "0000")
            {
                MainWindow.adTumbler = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный код!");
            }
        }
    }
}
