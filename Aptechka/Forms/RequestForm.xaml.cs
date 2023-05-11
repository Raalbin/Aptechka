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

    public sealed partial class RequestForm : Page
    {

        private static readonly string regularTAG = "Журнал Заявок";
        private static readonly string basketTAG = "Журнал Корзин";
        private AptechkaContext dbcontext;
        private readonly int formType;
        private ContextMenu contextMenu;

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
                fmRequest.Title = regularTAG;
                fmLabel.Content = regularTAG;
            }
            else
            {
                fmRequest.Title = basketTAG;
                fmLabel.Content = basketTAG;
            }

            contextMenu = new ContextMenu();

            MenuItem mi = new MenuItem();
            mi.Header = "Редактировать";
            mi.Tag = 1;
            mi.Click += Menu_EditItem;
            contextMenu.Items.Add(mi);

            mi = new MenuItem();
            mi.Header = "Добавить";
            mi.Tag = 2;
            mi.Click += Menu_AddItem;
            contextMenu.Items.Add(mi);

            mi = new MenuItem();
            mi.Header = "Удалить";
            mi.Tag = 3;
            mi.Click += Menu_DeleteItem;
            contextMenu.Items.Add(mi);

            fDataGrid.ContextMenu = contextMenu;
        }

        private void Menu_EditItem(object sender, RoutedEventArgs e)
        {
            OpenEditForm();
        }
        private void Menu_AddItem(object sender, RoutedEventArgs e)
        {
            OpenEditForm();
        }

        private void Menu_DeleteItem(object sender, RoutedEventArgs e)
        {
            Request req = (Request)fDataGrid.SelectedItem;

            if (req != null)
            {

                MessageBoxResult rez = MessageBox.Show("Вы действительно хотите удалить запись " + 
                    req.Id + ", " + req.Drugstore!.Name + "?", 
                    "Винимание!", 
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Warning);

                if (rez != MessageBoxResult.Yes) { return; }

                dbcontext.Requests.Remove(req);
                try
                {
                    dbcontext.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    System.Windows.MessageBox.Show("Произошла ошибка при удалении строки!\n" + e);
                }

            }

            ShowRequests();
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenEditForm();
        }

        /// <summary>
        /// Процедура открывает форму редактирования текущей заявки
        /// </summary>
        private void OpenEditForm()
        {
            Request req = (Request)fDataGrid.SelectedItem;
            MainWindow.GetNavFrame().Navigate(new RequestEditForm(dbcontext, req));  
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

