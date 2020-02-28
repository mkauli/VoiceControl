namespace SendVoiceCommands
{
    partial class MainForm
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
            this._closeButton = new System.Windows.Forms.Button();
            this._processesBox = new System.Windows.Forms.ComboBox();
            this._refreshButton = new System.Windows.Forms.Button();
            this._testButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this._spectrumButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Location = new System.Drawing.Point(888, 525);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 0;
            this._closeButton.Text = "_closeButton";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.closeButton__Click);
            // 
            // _processesBox
            // 
            this._processesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._processesBox.FormattingEnabled = true;
            this._processesBox.Location = new System.Drawing.Point(12, 12);
            this._processesBox.Name = "_processesBox";
            this._processesBox.Size = new System.Drawing.Size(870, 21);
            this._processesBox.TabIndex = 1;
            this._processesBox.SelectedIndexChanged += new System.EventHandler(this._processesBox_SelectedIndexChanged);
            // 
            // _refreshButton
            // 
            this._refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._refreshButton.Location = new System.Drawing.Point(888, 12);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(75, 23);
            this._refreshButton.TabIndex = 2;
            this._refreshButton.Text = "_refreshButton";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this._refreshButton_Click);
            // 
            // _testButton
            // 
            this._testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._testButton.Location = new System.Drawing.Point(807, 525);
            this._testButton.Name = "_testButton";
            this._testButton.Size = new System.Drawing.Size(75, 23);
            this._testButton.TabIndex = 3;
            this._testButton.Text = "_testButton";
            this._testButton.UseVisualStyleBackColor = true;
            this._testButton.Click += new System.EventHandler(this._testButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(951, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(12, 78);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(951, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 50;
            // 
            // _spectrumButton
            // 
            this._spectrumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._spectrumButton.Location = new System.Drawing.Point(726, 525);
            this._spectrumButton.Name = "_spectrumButton";
            this._spectrumButton.Size = new System.Drawing.Size(75, 23);
            this._spectrumButton.TabIndex = 7;
            this._spectrumButton.Text = "_spectrumButton";
            this._spectrumButton.UseVisualStyleBackColor = true;
            this._spectrumButton.Click += new System.EventHandler(this._spectrumButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this._closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this._spectrumButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this._testButton);
            this.Controls.Add(this._refreshButton);
            this.Controls.Add(this._processesBox);
            this.Controls.Add(this._closeButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.ComboBox _processesBox;
        private System.Windows.Forms.Button _refreshButton;
        private System.Windows.Forms.Button _testButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button _spectrumButton;
    }
}

