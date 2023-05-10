﻿using System;
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
    /// Логика взаимодействия для ProducersForm.xaml
    /// </summary>
    public partial class ProducersForm : Page
    {

        private AptechkaContext dbcontext;

        /// <summary>
        /// Конструктор формы списка заявок или списка производителей
        /// </summary>
        public ProducersForm(AptechkaContext dbContext)
        {
            InitializeComponent();

            dbcontext = dbContext;
        }

        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var prd = fDataGrid.SelectedItem;
            if (prd != null)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + ((Producer)prd).Name);
            }


        }

        private void ShowProducers()
        {
            List<Producer> prd;

            prd = dbcontext.Producers
                .Include(d => d.Address)
                .ToList();

            fDataGrid.ItemsSource = prd;
        }

        private void form_Loaded(object sender, RoutedEventArgs e)
        {
            ShowProducers();
        }
    }

}
