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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        chatsTableAdapter chats = new chatsTableAdapter();
        public Page2()
        {
            InitializeComponent();
            UsersGrid.ItemsSource = chats.GetData();

        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UName1.Text != null && UName2.Text != null)
            {
                chats.UpdateQuery(Convert.ToInt32(UName1.Text), Convert.ToInt32(UName2.Text), Convert.ToInt32((UsersGrid.SelectedItem as DataRowView).Row[0]));
                UsersGrid.ItemsSource = chats.GetData();
            }
        }
    }
}
