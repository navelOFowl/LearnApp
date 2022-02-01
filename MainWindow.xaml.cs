using LearnApp.Classes;
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

namespace LearnApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool adTumbler = false;
        public MainWindow()
        {
            InitializeComponent();
            DataBase.db = new SchoolBD();
            Frames.FrameMain = FrmMain;
            Frames.FrameMain.Navigate(new ServiceList());
        }

        private void ButtAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminCheck win = new AdminCheck();
            win.ShowDialog();
            if(adTumbler == true)
            {
                Frames.FrameMain.Navigate(new AdminList());
            }
        }
    }
}
