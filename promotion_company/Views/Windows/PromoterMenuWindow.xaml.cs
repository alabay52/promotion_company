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

namespace promotion_company.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для PromoterMenuWindow.xaml
    /// </summary>
    public partial class PromoterMenuWindow : Window
    {
        public PromoterMenuWindow()
        {
            InitializeComponent();
        }

        private void MyActions_Click(object sender, RoutedEventArgs e)
        {
            MyActionsWindow myActionsWindow = new MyActionsWindow();
            myActionsWindow.Show();
            this.Close();
        }

        private void Available_Click(object sender, RoutedEventArgs e)
        {
            AvailableActionsWindow availableActionsWindow = new AvailableActionsWindow();
            availableActionsWindow.Show();
            this.Close();
        }

        private void FinesBtn_Click(object sender, RoutedEventArgs e)
        {
            FinesWindow finesWindow = new FinesWindow();
            finesWindow.Show();
            this.Close();
        }
    }
}
