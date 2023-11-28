using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Practic2Abganeev.Models;

namespace Practic2Abganeev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<User> Users = new List<User>();
        public static Practic2AbganeevEntities DB = new Practic2AbganeevEntities();
        public static User LoggedUser;
    }
}
    