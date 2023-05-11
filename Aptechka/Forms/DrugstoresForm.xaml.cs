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
    /// Логика взаимодействия для DrugstoresForm.xaml
    /// </summary>
    public partial class DrugstoresForm : Page
    {

        private AptechkaContext dbcontext;

        /// <summary>
        /// Конструктор формы списка заявок или списка активных корзин
        /// <param name="dbContext">контекст entity framework</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugstoresForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var drg = fDataGrid.SelectedItem;
            if (drg != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + ((Drugstore)drg).Name);
            }


        }

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

