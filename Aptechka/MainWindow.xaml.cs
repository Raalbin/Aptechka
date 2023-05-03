using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AptechkaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AptechkaContext dbcontext;

        public MainWindow()
        {
            InitializeComponent();

            dbcontext = new AptechkaContext();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dbcontext.Drugstores.Load();
            dbcontext.Addresses.Load();

            fDataGrid.AutoGenerateColumns = true;
            fDataGrid.ItemsSource = dbcontext.Drugstores.Local.ToObservableCollection();
        }

        

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dbcontext.Dispose();
        }

        private void fDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btSave(object sender, RoutedEventArgs e)
        {
            dbcontext.SaveChanges();
        }

        private void fDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "TextAddr":
                    e.Column.Header = "Адрес";
                    break;
                case "Name":
                    e.Column.Header = "Название";
                    break;
                case "Telephone":
                    e.Column.Header = "Телефон";
                    break;
                case "PharmacyInn":
                    e.Column.Header = "ИНН";
                    break;
                case "Id":
                    //e.Column.IsFrozen = true;
                    e.Column.IsReadOnly = true;
                    break;
                case "AddressId":
                case "Address":
                case "Requests":
                    e.Column.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void fDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            int rowId = ((Drugstore)e.Row.Item).Id;
            if (rowId != 0)
            {
                System.Windows.MessageBox.Show("Здесь редактируем выбранную строку" + ", " + rowId);
            } else
            {
                System.Windows.MessageBox.Show("Создаём новую запись в таблице");
            }
            
            e.Cancel = true;
        }

        private void fDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            //System.Windows.MessageBox.Show("Insert");
        }
    }
}
