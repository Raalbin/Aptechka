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
using Microsoft.EntityFrameworkCore;

namespace AptechkaWPF
{
    /// <summary>
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class RequestForm : Page
    {

        private AptechkaContext dbcontext;

        public RequestForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var req = fDataGrid.SelectedItem;
            if (req != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + ((Request)req).Drugstore!.Name);
            }


        }

        private void ShowRequests()
        {
            var req = dbcontext.Requests
                .Where(r => r.Status!.Code != 100)
                .Include(r => r.Status)
                .Include(r => r.Drugstore)
                .ToList();

            fDataGrid.ItemsSource = req;
        }

        private void fmRequest_Loaded(object sender, RoutedEventArgs e)
        {
            ShowRequests();
        }
    }

}

