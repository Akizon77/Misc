using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
using System.Xml.Linq;

namespace JsonVis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [INotifyPropertyChanged]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var cvs = this.FindResource("view") as CollectionViewSource;
            cvs.Source = ViewModle.Instance.VTS;
        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            var vtb = e.Item as VT;
            var text = fitterTextBox.Text;
            e.Accepted = vtb.Name.Contains(text)
                || vtb.Uid.Contains(text)
                || vtb.Uid.Contains("UID")
                || vtb.Gid.Contains(text);
        }

        private void FitterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //CollectionViewSource.GetDefaultView(listView.ItemsSource).Refresh();
        }

        private void fitterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CollectionViewSource.GetDefaultView(listView.ItemsSource).Refresh();
            }
            
        }

        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            listView.MaxHeight = this.Height - 180;
            listView.MaxWidth = this.Width - 80;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //UID

            //var a = listView.SelectedItem as VT;
            //if (a != null) Clipboard.SetDataObject(a.Uid);
            copyNotice.Visibility = Visibility.Visible;
            CancelNotice();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //name
            //var a = listView.SelectedItem as VT;
            //if (a != null) Clipboard.SetDataObject(a.Name);
            copyNotice.Visibility = Visibility.Visible;
            CancelNotice();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Group
            //var a = listView.SelectedItem as VT;
            //if (a != null) Clipboard.SetDataObject(a.Gid);
            copyNotice.Visibility = Visibility.Visible;
            CancelNotice();
        }
        private async void CancelNotice()
        {
            await Task.Delay(600);
            copyNotice.Visibility = Visibility.Hidden;
        }

    }
}
