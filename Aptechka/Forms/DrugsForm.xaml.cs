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

    public sealed partial class DrugsForm : Page
    {

        private AptechkaContext dbcontext;
        private ContextMenu contextMenu;

        /// <summary>
        /// Конструктор формы списка медикаментов
        /// <param name="dbContext">контекст entity framework</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugsForm(AptechkaContext dbContext)
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
            OpenEditForm();
        }

        /// <summary>
        /// Обработчик контекстного пункта меню "Добавить"
        /// открывает форму редактирования новой записи
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void Menu_AddItem(object sender, RoutedEventArgs e)
        {
            OpenEditForm(1);
        }

        /// <summary>
        /// Обработчик контекстного пункта меню "Удалить"
        /// удаляет текущую строку из базы данных
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void Menu_DeleteItem(object sender, RoutedEventArgs e)
        {
            Drug drg = (Drug)fDataGrid.SelectedItem;

            if (drg != null)
            {

                MessageBoxResult rez = MessageBox.Show("Вы действительно хотите удалить запись " + drg.Name + "?", "Винимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (rez != MessageBoxResult.Yes) { return; }

                dbcontext.Drugs.Remove(drg);

                try
                {
                    dbcontext.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    System.Windows.MessageBox.Show("Произошла ошибка при удалении строки!\n" + e);
                }

            }

            ShowDrugs();
        }

        /// <summary>
        /// Обработчик двойного нажатия в элементе DataGrid. При двойном щелчке
        /// открывается форма редактирования выбранной строки.
        /// <return>Не возвращает ничего</return>
        /// </summary>
        private void fDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenEditForm();
        }

        /// <summary>
        /// Процедура открывает форму редактирования медикамента
        /// </summary>
        /// <param name="addnew">Если 1 - создаётся новый, если 0 - открывается выбранный</param>
        private void OpenEditForm(int addnew = 0)
        {
            Drug req = (Drug)fDataGrid.SelectedItem;

            if ((addnew == 1) || (req == null))
            {
                MainWindow.GetNavFrame().Navigate(new DrugEditForm(dbcontext));
            }
            else
            {
                MainWindow.GetNavFrame().Navigate(new DrugEditForm(dbcontext, req));
            }
        }

        /// <summary>
        /// Процедура загрузки медикаментов из БД
        /// </summary>
        private void ShowDrugs()
        {
            string searchStr = tbSearch.Text.ToLower().Trim();

            List<Drug> drg = dbcontext.Drugs
                .Include(d => d.Producer)
                .ToList()
                .Where(d => d.Name!.ToLower().Contains(searchStr)
                            || d.Price!.ToString()!.ToLower().Contains(searchStr)
                            || d.Producer!.Name!.ToLower().Contains(searchStr)
                            || d.DateOfManufacture!.ToString()!.ToLower().Contains(searchStr)
                            || d.BestBeforeDate!.ToString()!.ToLower().Contains(searchStr)
                        )
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

        /// <summary>
        /// Обработчик строки поиска. При изменении данные перезапрашиваются
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowDrugs();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenEditForm(1);
        }
    }

}

