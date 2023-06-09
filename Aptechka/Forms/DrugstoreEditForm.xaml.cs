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
    public sealed partial class DrugstoreEditForm : Page
    {

        private AptechkaContext dbcontext;

        private Drugstore currentItem;

        /// <summary>
        /// Конструктор формы редактирования аптеки
        /// <param name="dbContext">контекст entity framework</param>
        /// <param name="item">Текущая аптеки или null</param>
        /// <return>Не возвращает ничего</return>
        /// </summary>
        public DrugstoreEditForm(AptechkaContext dbContext, Drugstore? item = null)
        {
            InitializeComponent();

            dbcontext = dbContext;

            // Если параметр item null, то это форма создания новой аптеки
            if (item == null)
            {
                currentItem = new Drugstore() {Name = "Новая аптека", AddressId = null , PharmacyInn = null, Telephone = null};
                dbcontext.Drugstores.Add(currentItem);
                try
                {
                    dbcontext.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка записи аптеки в базу данных!");
                }

                fmDrugstoreEdit.Title = "Новая аптека";
                fmLabel.Content = "Новая аптека";
            }
            else
            {
                currentItem = item;

                fmDrugstoreEdit.Title = "Редактирование аптеки";
                fmLabel.Content = "Редактирование аптеки";
            }

        }

        /// <summary>
        /// Процедура загрузки данных в форму. 
        /// </summary>
        private void ShowDrugstore()
        {
            dbcontext.Addresses.Load();
            fmGrid.DataContext = dbcontext.Drugstores.Find(currentItem.Id);
            fmAddr.Text = dbcontext.Addresses.Find(currentItem.AddressId)!.Name;
        }


        /// <summary>
        /// Процедура обработки события загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmDrugstoreEdit_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDrugstore();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить", записывает данные в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            currentItem.Name = fmName.Text;
            currentItem.Telephone = fmPhone.Text;
            currentItem.PharmacyInn = fmINN.Text;

            try
            {
            
                dbcontext.Drugstores.Update(currentItem);
                dbcontext.SaveChanges();

                MessageBox.Show("Данные сохранены в БД!\n", "Сохранение данных", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            catch
            {
                MessageBox.Show("Ошибка записи аптеки в БД!\n" + e.ToString());
            }
        }

        


       

        private void fmAddr_MouseEnter(object sender, MouseEventArgs e)
        {
            {
                {
                    List<Address> addr = new List<Address> { dbcontext.Addresses.Find(currentItem.AddressId)! };

                    AddressForm addrFm = new AddressForm(dbcontext, addr);
                    addrFm.ShowDialog();

                    if (addr[0] != null)
                    {
                        fmAddr.Text = addr[0].Name;
                        currentItem.AddressId = addr[0].Id;
                    }
                    else
                    {
                        fmAddr.Text = "<Адрес не задан>";
                        currentItem.AddressId = null;
                    }

                    try
                    {
                        dbcontext.Drugstores.Update(currentItem);
                        dbcontext.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка записи аптеки в БД!\n" + e.ToString());
                    }

                    ShowDrugstore();
                }
            }
        }
    }
}

