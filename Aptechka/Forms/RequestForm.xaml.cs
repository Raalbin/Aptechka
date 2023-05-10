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
        private readonly int formType;

        /// <summary>
        /// Конструктор формы списка заявок или списка активных корзин
        /// <param name="dbContext">контекст entity framework</param>
        /// <param name="basket">Тип списка. 1 - корзина, 0 - обычный (default)</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public RequestForm(AptechkaContext dbContext, int basket = 0)
        {
            InitializeComponent();

            dbcontext = dbContext;
            formType = basket;

            if (formType == 0)
            {
                fmRequest.Title = "Жрунал Заявок";
            }
            else
            {
                fmRequest.Title = "Жрунал Корзин";
            }

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
            List<Request> req;

            if (formType == 0)
            {
                req = dbcontext.Requests
                .Where(r => r.Status!.Code != 100)
                .Include(r => r.Status)
                .Include(r => r.Drugstore)
                .ToList();
            }
            else
            {
                req = dbcontext.Requests
                    .Where(r => r.Status!.Code == 100)
                    .Include(r => r.Status)
                    .Include(r => r.Drugstore)
                    .ToList();
            }

            fDataGrid.ItemsSource = req;
        }

        private void fmRequest_Loaded(object sender, RoutedEventArgs e)
        {
            ShowRequests();
        }
    }

}

