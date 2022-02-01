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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        Service Ser = new Service();
        public Edit(Service SerEdit)
        {
            InitializeComponent();
            TbTitle.Text = SerEdit.Title.ToString();
            TbCost.Text = SerEdit.Cost.ToString();
            TbDur.Text = (SerEdit.DurationInSeconds / 60).ToString();
            TbDis.Text = "" + SerEdit.Description.ToString();
            TbSale.Text = (SerEdit.Discount * 100).ToString();
            Ser = SerEdit;
        }

        private void ButtEdit_Click(object sender, RoutedEventArgs e)
        {
            Ser.Title = TbTitle.Text;
            Ser.Cost = Convert.ToInt32(TbCost.Text);
            Ser.DurationInSeconds = Convert.ToInt32(TbDur.Text) * 60;
            Ser.Description = TbDis.Text;
            Ser.Discount = Convert.ToInt32(TbSale.Text) / 100;
            DataBase.db.SaveChanges();
            MessageBox.Show("Услуга успешно записана!", "Запись услуги", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            Frames.FrameMain.Navigate(new AdminList());
        }
    }
}
