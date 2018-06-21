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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in ((sender as TreeViewItem).Parent as TreeView).Items)
        //    {
        //        if(((sender as TreeViewItem).Parent as TreeView).SelectedItem != (item as TreeViewItem))
        //        {
        //            (item as TreeViewItem).IsExpanded = false;
        //        }
        //    }
        //}
    }
}
