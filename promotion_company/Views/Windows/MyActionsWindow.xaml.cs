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
    /// Логика взаимодействия для MyActionsWindow.xaml
    /// </summary>
    public partial class MyActionsWindow : Window
    {
        public MyActionsWindow()
        {
            InitializeComponent();
            gridActions.ItemsSource = App.context.Actions.ToList();
         
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
