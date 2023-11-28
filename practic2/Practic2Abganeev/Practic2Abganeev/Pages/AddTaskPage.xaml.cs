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
using Practic2Abganeev.Pages;

namespace Practic2Abganeev.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        Tasks contextTasks;
        public AddTaskPage(Tasks tasks)
        {
            InitializeComponent();
            contextTasks = tasks;
            DataContext = contextTasks;
        }
        private void BSave_Click(object sended, RoutedEventArgs e)
        {
            if (contextTasks.Taskid == 0)
                App.DB.Tasks.Add(contextTasks);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }



        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
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
