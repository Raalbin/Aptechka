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
    public sealed partial class DrugsForm : Page
    {

        private AptechkaContext dbcontext;

        /// <summary>
        /// Конструктор формы списка медикаментов
        /// <param name="dbContext">контекст entity framework</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugsForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;
        }

        /// <summary>
        /// Обработчик двойного нажатия левой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var drg = fDataGrid.SelectedItem;
            if (drg != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + ((Drug)drg).Name);
            }
        }

        /// <summary>
        /// Процедура загрузки медикоментов из БД
        /// </summary>
        private void ShowDrugs()
        {
            List<Drug> drg = dbcontext.Drugs
                .Include(d => d.Producer)
                .ToList();

            fDataGrid.ItemsSource = drg;
        }

        /// <summary>
        /// Обработчик события загрузки формы. Вызывает процедуру заполнения формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmDrugs_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDrugs();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}

