namespace WinFormAsync
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNoAsync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoAsync
            // 
            this.btnNoAsync.Location = new System.Drawing.Point(12, 12);
            this.btnNoAsync.Name = "btnNoAsync";
            this.btnNoAsync.Size = new System.Drawing.Size(112, 23);
            this.btnNoAsync.TabIndex = 0;
            this.btnNoAsync.Text = "No Async";
            this.btnNoAsync.UseVisualStyleBackColor = true;
            this.btnNoAsync.Click += new System.EventHandler(this.OpenNoAsyncWindow);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(12, 41);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(112, 23);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.OpenAsyncWindow);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 78);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnNoAsync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoAsync;
        private System.Windows.Forms.Button btnAsync;
    }
}

