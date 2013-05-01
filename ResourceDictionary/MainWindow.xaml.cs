using System;
using System.Reflection;
using System.Windows;

namespace ResourceDictionaryTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Assembly.LoadFrom(@"C:\temp\test.dll");

            Assembly.LoadFrom(@"C:\temp\test.dll");
            var rd = new ResourceDictionary();
            rd.Source = new Uri("/test;component/myresource.xaml"); 


            rd.Source = new Uri("/test;component/myresource.xaml");

        }      
    }
}
