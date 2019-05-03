namespace WpfAsync
{
    using System.Windows;

    public partial class MainWindow : Window
    {
        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void OpenNoAsyncWindow(object sender, RoutedEventArgs e)
        {
            NoAsync noAsync = new NoAsync();
            noAsync.Show();
        }

        private void OpenAsyncWindow(object sender, RoutedEventArgs e)
        {
            Async async = new Async();
            async.Show();
        }

        #endregion
    }
}
