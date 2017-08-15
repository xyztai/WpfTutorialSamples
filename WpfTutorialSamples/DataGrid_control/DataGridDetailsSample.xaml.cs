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

namespace WpfTutorialSamples.DataGrid_control
{
    /// <summary>
    /// DataGridDetailsSample.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridDetailsSample : UserControl
    {
        public DataGridDetailsSample()
        {
            InitializeComponent();
            List<User1> users = new List<User1>();
            users.Add(new User1() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User1() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users.Add(new User1() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = users;

        }
    }
}
