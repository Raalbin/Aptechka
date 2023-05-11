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
     public sealed partial class DrugstoresForm : Page
 
    {

        private AptechkaContext dbcontext;
        private ContextMenu contextMenu;

        /// <summary>
        /// Конструктор формы списка заявок или списка активных корзин
        /// <param name="dbContext">контекст entity framework</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugstoresForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;


            // Создаём контекстное меню для элемента DataGrid
            //{
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
            //}

            fDataGrid.ContextMenu = contextMenu;

        }

        /// <summary>
        /// Обработчик контекстного пункта меню "Редактировать"
        /// открывает форму редактирования текущей записи
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void Menu_EditItem(object sender, RoutedEventArgs e)
        {
            var req = fDataGrid.SelectedItem;
            if (req != null)
            {
                ;
            }
        }

        /// <summary>
        /// Обработчик контекстного пункта меню "Добавить"
        /// открывает форму редактирования новой записи
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void Menu_AddItem(object sender, RoutedEventArgs e)
        {
            ;
        }

        /// <summary>
        /// Обработчик контекстного пункта меню "Удалить"
        /// удаляет текущую строку из базы данных
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void Menu_DeleteItem(object sender, RoutedEventArgs e)
        {
            Drugstore drg = (Drugstore)fDataGrid.SelectedItem;

            if (drg != null)
            {

                MessageBoxResult rez = MessageBox.Show("Вы действительно хотите удалить запись " + drg.Name + "?", "Винимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (rez != MessageBoxResult.Yes) { return; }
                
                dbcontext.Drugstores.Remove(drg);

                try
                {
                    dbcontext.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    System.Windows.MessageBox.Show("Произошла ошибка при удалении строки!\n" + e);
                }
                
            }

            ShowDrugstores();
        }

        /// <summary>
        /// Обработчик двойного нажатия в элементе DataGrid. При двойном щелчке
        /// открывается форма редактирования выбранной строки.
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Drugstore drg = (Drugstore)fDataGrid.SelectedItem;
            if (drg != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + drg.Name);
            }


        }

        /// <summary>
        /// Процедура выполняет запрос к БД и заполняет элемент формы данными.
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void ShowDrugstores()
        {
            List<Drugstore> drg;

            drg = dbcontext.Drugstores
                .Include(d => d.Address)
                .ToList();

            fDataGrid.ItemsSource = drg;
        }

        /// <summary>
        /// Обработчик события загрузки формы. Отображает список аптек при октрытии.
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void form_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDrugstores();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}

