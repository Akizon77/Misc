using System;
using System.Windows;
using System.Windows.Controls;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  //类
    {
        public MainWindow() //构造函数
        {
            InitializeComponent();
        }

        //int num = 2;
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    while(true)
        //    {
        //        bool ds = true;
        //        for (int i = 2; i < num; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                ds = false;
        //                break;
        //            }
        //        }
        //        if (ds) _TextBlock.Text = num.ToString();
        //        num += 1;
        //        if (ds) break;
        //    }
            
        //}

        //private void _FormTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        //{
        //    try
        //    {
        //        var textbox = sender as TextBox;
        //        num = Convert.ToInt32(textbox.Text);
        //    }
        //    catch 
        //    {
        //        num = 2;
        //    }

        //}
    }
}
