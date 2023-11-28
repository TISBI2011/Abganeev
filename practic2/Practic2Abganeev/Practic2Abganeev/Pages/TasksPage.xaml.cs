using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        public TasksPage()
        {
            InitializeComponent();
        }
        public void BAddTasks_Click(object sended, RoutedEventArgs e)
        {
            //var selectedTasks = DGTasks.SelectedItem as Tasks;
            NavigationService.Navigate(new AddTaskPage(new Tasks()));
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGTasks.ItemsSource = App.DB.Tasks.ToList();
        }

        private void BEditTasks_Click(object sender, RoutedEventArgs e)
        {
            var selectedTasks = DGTasks.SelectedItem as Tasks;
            if (selectedTasks == null)
            {
                MessageBox.Show("Выберите задачу");
                return;
            }
            NavigationService.Navigate(new AddTaskPage(selectedTasks));
        }
    }
}
