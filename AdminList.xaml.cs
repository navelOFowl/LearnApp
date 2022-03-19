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
    /// Логика взаимодействия для AdminList.xaml
    /// </summary>
    public partial class AdminList : Page
    {
        List<Service> AdminStart = DataBase.db.Service.ToList();
        public AdminList()
        {
            InitializeComponent();
            LVServices.ItemsSource = AdminStart;
        }

        private void ButtEdit_Click(object sender, RoutedEventArgs e)
        {
            Button buttEdit = (Button)sender;
            int ID = Convert.ToInt32(buttEdit.Uid);
            Service SerEdit = DataBase.db.Service.FirstOrDefault(x => x.ID == ID);
            Frames.FrameMain.Navigate(new Edit(SerEdit));
        }

        private void ButtDelete_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int ID = Convert.ToInt32(button.Uid);
            Service lessDelete = DataBase.db.Service.FirstOrDefault(x => x.ID == ID);
            DataBase.db.Service.Remove(lessDelete);
            DataBase.db.SaveChanges();
            Frames.FrameMain.Navigate(new AdminList());
            MessageBox.Show("Услуга удалена!", "Удаление", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void ButtAcc_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int ID = Convert.ToInt32(button.Uid);
            Service lessAcc = DataBase.db.Service.FirstOrDefault(x => x.ID == ID);
            AccWindow win = new AccWindow(lessAcc);
            win.ShowDialog();
        }
    }
}
