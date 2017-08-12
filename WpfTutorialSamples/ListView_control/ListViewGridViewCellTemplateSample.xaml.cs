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
    /// ListViewGridViewCellTemplateSample.xaml 的交互逻辑
    /// </summary>
    public partial class ListViewGridViewCellTemplateSample : UserControl
    {
        public ListViewGridViewCellTemplateSample()
        {
            InitializeComponent();
            List<User1> items = new List<User1>();
            items.Add(new User1() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User1() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User1() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            lvUsers.ItemsSource = items;
        }
    }
}
