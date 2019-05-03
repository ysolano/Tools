namespace WinFormAsync
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Async : Form
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

        private async void ReadData(object sender, System.EventArgs e)
        {
            btnReadData.Enabled = false;
            var files = await GetFiles();
            lbxFiles.DataSource = files.ToList();
            btnReadData.Enabled = true;
        }

        #endregion

        private void ShowTime(object sender, System.EventArgs e)
        {
            MessageBox.Show($"Son las {DateTime.Now.ToLongTimeString()}");
        }
    }
}
