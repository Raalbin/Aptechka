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
    public sealed partial class RequestEditForm : Page
    {

        private AptechkaContext dbcontext;

        //formType = 0 - новая заявка
        //formType = 1 - редактирование
        private readonly int formType;
        private ContextMenu contextMenu;
        private Request currentItem;

        /// <summary>
        /// Конструктор формы редактирования заявки
        /// <param name="dbContext">контекст entity framework</param>
        /// <param name="item">Текущая заявка или null</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public RequestEditForm(AptechkaContext dbContext, Request? item = null)
        {
            InitializeComponent();

            dbcontext = dbContext;

            // Если параметр item null, то это форма создания новой заявки
            if (item == null)
            {
                formType = 0;

                currentItem = new Request();
                dbcontext.Requests.Add(currentItem);

                fmRequestEdit.Title = "Новая заявка";
                fmLabel.Content = "Новая заявка";
            }
            else
            {
                formType = 1;
                currentItem = item;

                fmRequestEdit.Title = "Редактирование заявки";
                fmLabel.Content = "Редактирование заявки";
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
            var req = fDataGrid.SelectedItem;
            if (req != null)
            {
                ;
            }
        }
        private void Menu_AddItem(object sender, RoutedEventArgs e)
        {
            ;
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

            ShowPurchases();
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /*
            var req = fDataGrid.SelectedItem!.GetType().GetMember("Name");
            if (req != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + req);
            }
            */
        }

        private void ShowPurchases()
        {

            var purch = dbcontext.Purchases
                .Where(p => p.IdRequests == currentItem.Id)
                .ToList()
                .Join(dbcontext.Drugs,
                        p => p.IdDrugs, d => d.Id, (p, d) => new PurchaseRow() { count = p.Count, purch = p, drug = d, summ = d.Price * p.Count })
                .ToList();
            /*
            p => p.IdDrugs, d => d.Id, (p, d) => new PurchaseRow() { count = p.Count, id = p.Id, purch = p, drug = d, price = d.Price, summ = d.Price * p.Count })
            */
            fmGrid.DataContext = currentItem;
            fDataGrid.ItemsSource = purch;

            fmStatus.ItemsSource = dbcontext.Statuses.ToList();
            fmStatus.DisplayMemberPath = "Name";
            fmStatus.SelectedValuePath = "Id";
            fmStatus.SelectedItem = currentItem.Status;

            fmDrugstore.ItemsSource = dbcontext.Drugstores.ToList();
            fmDrugstore.DisplayMemberPath = "Name";
            fmDrugstore.SelectedValuePath = "Id";
            fmDrugstore.SelectedItem = currentItem.Drugstore;
        }

        private void fmRequest_Loaded(object sender, RoutedEventArgs e)
        {
            ShowPurchases();
        }

        private void fDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            ;
        }

        private void fDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if ((string)e.Column.Header == "Количество")
            {
                decimal count = Decimal.Parse(((TextBox)e.EditingElement).Text);
                if ((count == 0) || (count < 0))
                {
                    MessageBox.Show("Недопустимое количество!\nВеличина должна быть целым положительным числом!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    e.Cancel = true;
                    return;
                }

                PurchaseRow row = (PurchaseRow)e.Row.Item;

                if (row.purch == null)
                {
                    Drug? drg = row.drug == null ? dbcontext.Drugs.Find(1) : row.drug;

                    Purchase newPurch = new Purchase() { Count = (int)count, IdDrugs = 1, IdRequests = currentItem.Id };
                    dbcontext.Purchases.Add(newPurch);
                    row.purch = newPurch;
                    row.drug = drg!;
                }
                else
                { 
                    row.count = (int)count;
                    row.purch.Count = (int)count;

                    dbcontext.Purchases.Update(row.purch);
                }

                row.summ = row.drug!.Price * count;
                e.Row.Item = null;
                e.Row.Item = row;

                dbcontext.SaveChanges();
            }
        }

        /// <summary>
        /// Прокси класс, представляющий собой строку в таблице закупок
        /// </summary>
        public class PurchaseRow
        {
            public int? count { get; set; }
            //            public int id { get; set; }
            public Purchase purch { get; set; } = null!;
            public Drug drug { get; set; } = null!;
            //            public decimal? price { get; set; }
            public decimal? summ { get; set; }
        }
    }
}
