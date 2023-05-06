using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class MainWindow : Window
    {
        private readonly AptechkaContext dbcontext;

        public MainWindow()
        {
            InitializeComponent();

            CultureInfo newCulture = CultureInfo.CreateSpecificCulture("ru-RU");
            Thread.CurrentThread.CurrentUICulture = newCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;

            dbcontext = new AptechkaContext();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationUIVisibility = NavigationUIVisibility.Visible;
            toRequestsForm();
        }

 
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dbcontext.Dispose();
        }

        private void Requests_Click(object sender, RoutedEventArgs e)
        {
            toRequestsForm();
        }

        private void toRequestsForm()
        {
            mainFrame.Navigate(new RequestForm(dbcontext));       
        }
    }
}
