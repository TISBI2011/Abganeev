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
using Practic2Abganeev.Models;

namespace Practic2Abganeev.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }
        public void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Name = TextBoxName.Text;
            App.DB.User.Add(user);
            App.DB.SaveChanges();
        }
        public void BAddCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UsersPage());
        }
    }
}
