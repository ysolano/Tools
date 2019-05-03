namespace WpfAsync
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows;

    public partial class NoAsync : Window
    {
        #region Constructors

        public NoAsync()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private IEnumerable<string> GetFiles()
        {
            var files = from file
                        in Directory.GetFiles(@"C:\Windows\System32")
                        select file;
            Thread.Sleep(5000);
            return files;
        }

        private void ReadData(object sender, RoutedEventArgs e)
        {
            btnReadData.IsEnabled = false;
            lbxFiles.ItemsSource = GetFiles();
            btnReadData.IsEnabled = true;
        }

        private void ShowTime(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Son las {DateTime.Now.ToLongTimeString()}");
        }

        #endregion
    }
}
