namespace WpfAsync
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    public partial class Async : Window
    {
        #region Constructors

        public Async()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private Task<IEnumerable<string>> GetFiles()
        {
            return Task.Run(() =>
            {
                var files = from file
                            in Directory.GetFiles(@"C:\Windows\System32")
                            select file;
                Thread.Sleep(5000);
                return files;
            });
        }

        private async void ReadData(object sender, RoutedEventArgs e)
        {
            btnReadData.IsEnabled = false;
            lbxFiles.ItemsSource = await GetFiles();
            btnReadData.IsEnabled = true;
        }

        private void ShowTime(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Son las {DateTime.Now.ToLongTimeString()}");
        }

        #endregion
    }
}
