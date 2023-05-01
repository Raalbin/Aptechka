using Aptechka.Models;
using Microsoft.EntityFrameworkCore;
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

namespace Aptechka.Pages.View
{
    /// <summary>
    /// Логика взаимодействия для ViewPurchase.xaml
    /// </summary>
    public partial class ViewPurchase : Page
    {
        AptechkaContext db;
        public ViewPurchase()
        {
            InitializeComponent();
            db = new AptechkaContext();
            db.Requests.Load(); // загружаем данные
            GridListPurchase.ItemsSource = db.Requests.Local.ToBindingList(); // устанавливаем привязку к кэшу
        }

        private void BtnSpecialty_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
