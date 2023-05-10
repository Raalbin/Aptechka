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
    public partial class DrugsForm : Page
    {

        private AptechkaContext dbcontext;

        /// <summary>
        /// Конструктор формы списка заявок или списка активных корзин
        /// <param name="dbContext">контекст entity framework</param>
        /// <param name="basket">Тип списка. 1 - корзина, 0 - обычный (default)</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugsForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var drg = fDataGrid.SelectedItem;
            if (drg != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + ((Drug)drg).Name);
            }


        }

        private void ShowDrugs()
        {
            List<Drug> drg;

            drg = dbcontext.Drugs
                .Include(d => d.Producer)
                .ToList();

            fDataGrid.ItemsSource = drg;
        }

        private void fmDrugs_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDrugs();
        }
    }

}

