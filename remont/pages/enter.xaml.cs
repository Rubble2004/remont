using remont.classes;
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


namespace remont.pages
{
    /// <summary>
    /// Логика взаимодействия для enter.xaml
    /// </summary>
    public partial class enter : Page
    {
        public enter()
        {
            InitializeComponent();
            connect.dbmodel = new models.remontEntities2();
           
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            var userobj = classes.connect.dbmodel.users.FirstOrDefault(x => x.login == login.Text && password.Password == x.password);
            if(userobj.id_type == 1)
            
            ///if (login.Text == "root" && password.Password == "12345") 
            
            {
                classes.manager.MainFrame.Navigate(new Admin());
            }
            if (userobj.id_type == 2)
            {
                classes.manager.MainFrame.Navigate(new Client());
            }


        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            classes.manager.MainFrame.Navigate(new registr());
        }
    }
}
