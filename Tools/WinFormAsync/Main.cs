namespace WinFormAsync
{
    using System;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        #region Constructors

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void OpenNoAsyncWindow(object sender, EventArgs e)
        {
            NoAsync noAsync = new NoAsync();
            noAsync.Show();
        }

        private void OpenAsyncWindow(object sender, EventArgs e)
        {
            Async async = new Async();
            async.Show();
        }

        #endregion


    }
}
