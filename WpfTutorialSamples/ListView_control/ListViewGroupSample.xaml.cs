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
    /// ListViewGroupSample.xaml 的交互逻辑
    /// </summary>
    public partial class ListViewGroupSample : UserControl
    {
        public ListViewGroupSample()
        {
            InitializeComponent();
            List<User2> items = new List<User2>();
            items.Add(new User2() { Name = "John Doe", Age = 42, Sex = SexType.Male });
            items.Add(new User2() { Name = "Jane Doe", Age = 39, Sex = SexType.Female });
            items.Add(new User2() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}
