namespace WinFormAsync
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public partial class NoAsync : Form
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

        private void ReadData(object sender, System.EventArgs e)
        {
            btnReadData.Enabled = false;
            lbxFiles.DataSource = GetFiles().ToList();
            btnReadData.Enabled = true;
        }

        #endregion

        private void ShowTime(object sender, System.EventArgs e)
        {
            MessageBox.Show($"Son las {DateTime.Now.ToLongTimeString()}");
        }
    }
}
