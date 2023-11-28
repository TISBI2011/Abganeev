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

namespace Practic2Abganeev.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPages.xaml
    /// </summary>
    public partial class MainMenuPages : Page
    {
        public MainMenuPages()
        {
            InitializeComponent();
        }

        
        public void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        public void BTasks_Click(object sended, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TasksPage());
        }
    }
}
