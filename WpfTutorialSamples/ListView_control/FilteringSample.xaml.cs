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

namespace WpfTutorialSamples.ListView_control
{
    /// <summary>
    /// FilteringSample.xaml 的交互逻辑
    /// </summary>
    public partial class FilteringSample : UserControl
    {
        public FilteringSample()
        {
            InitializeComponent();
            List<User2> items = new List<User2>();
            items.Add(new User2() { Name = "John Doe", Age = 42 });
            items.Add(new User2() { Name = "Jane Doe", Age = 39 });
            items.Add(new User2() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User2() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;
        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as User2).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }
}