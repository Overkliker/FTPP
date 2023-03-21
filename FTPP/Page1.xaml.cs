using System;
using System.Collections.Generic;
using System.Data;
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
using FTPP.fppDataSetTableAdapters;

namespace FTPP
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        usersTableAdapter users = new usersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = users.GetData();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UName.Text != null && UMail.Text != null)
            {
                users.UpdateQuery(UName.Text, UMail.Text, Convert.ToInt32((UsersGrid.SelectedItem as DataRowView).Row[0]));
                UsersGrid.ItemsSource = users.GetData();
            }
        }
    }
}
