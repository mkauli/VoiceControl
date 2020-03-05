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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this._spectrumButton = new System.Windows.Forms.Button();
            this._levelLabel = new System.Windows.Forms.Label();
            this._processLabel = new System.Windows.Forms.Label();
            this._loadProfileBox = new System.Windows.Forms.TextBox();
            this._loadProfileLabel = new System.Windows.Forms.Label();
            this._loadProfileButton = new System.Windows.Forms.Button();
            this._loadProfileDialog = new System.Windows.Forms.OpenFileDialog();
            this._createNewProfileButton = new System.Windows.Forms.Button();
            this._saveProfileDialog = new System.Windows.Forms.SaveFileDialog();
            this._eventsListBox = new System.Windows.Forms.ListBox();
            this._eventsLabel = new System.Windows.Forms.Label();
            this._eventsCreateButton = new System.Windows.Forms.Button();
            this._eventsDeleteButton = new System.Windows.Forms.Button();
            this._eventsEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Location = new System.Drawing.Point(721, 525);
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
            this._processesBox.Location = new System.Drawing.Point(12, 147);
            this._processesBox.Name = "_processesBox";
            this._processesBox.Size = new System.Drawing.Size(703, 21);
            this._processesBox.TabIndex = 1;
            this._processesBox.SelectedIndexChanged += new System.EventHandler(this._processesBox_SelectedIndexChanged);
            // 
            // _refreshButton
            // 
            this._refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._refreshButton.Location = new System.Drawing.Point(721, 145);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(75, 23);
            this._refreshButton.TabIndex = 2;
            this._refreshButton.Text = "_refreshButton";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this._refreshButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(784, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // _spectrumButton
            // 
            this._spectrumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._spectrumButton.Location = new System.Drawing.Point(640, 525);
            this._spectrumButton.Name = "_spectrumButton";
            this._spectrumButton.Size = new System.Drawing.Size(75, 23);
            this._spectrumButton.TabIndex = 7;
            this._spectrumButton.Text = "_spectrumButton";
            this._spectrumButton.UseVisualStyleBackColor = true;
            this._spectrumButton.Click += new System.EventHandler(this._spectrumButton_Click);
            // 
            // _levelLabel
            // 
            this._levelLabel.AutoSize = true;
            this._levelLabel.Location = new System.Drawing.Point(12, 64);
            this._levelLabel.Name = "_levelLabel";
            this._levelLabel.Size = new System.Drawing.Size(61, 13);
            this._levelLabel.TabIndex = 8;
            this._levelLabel.Text = "_levelLabel";
            // 
            // _processLabel
            // 
            this._processLabel.AutoSize = true;
            this._processLabel.Location = new System.Drawing.Point(12, 131);
            this._processLabel.Name = "_processLabel";
            this._processLabel.Size = new System.Drawing.Size(76, 13);
            this._processLabel.TabIndex = 9;
            this._processLabel.Text = "_processLabel";
            // 
            // _loadProfileBox
            // 
            this._loadProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._loadProfileBox.Location = new System.Drawing.Point(12, 27);
            this._loadProfileBox.Name = "_loadProfileBox";
            this._loadProfileBox.Size = new System.Drawing.Size(668, 20);
            this._loadProfileBox.TabIndex = 10;
            this._loadProfileBox.Text = "_loadProfileBox";
            this._loadProfileBox.TextChanged += new System.EventHandler(this._loadProfileBox_TextChanged);
            // 
            // _loadProfileLabel
            // 
            this._loadProfileLabel.AutoSize = true;
            this._loadProfileLabel.Location = new System.Drawing.Point(12, 11);
            this._loadProfileLabel.Name = "_loadProfileLabel";
            this._loadProfileLabel.Size = new System.Drawing.Size(88, 13);
            this._loadProfileLabel.TabIndex = 11;
            this._loadProfileLabel.Text = "_loadProfileLabel";
            // 
            // _loadProfileButton
            // 
            this._loadProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._loadProfileButton.Location = new System.Drawing.Point(686, 25);
            this._loadProfileButton.Name = "_loadProfileButton";
            this._loadProfileButton.Size = new System.Drawing.Size(29, 23);
            this._loadProfileButton.TabIndex = 12;
            this._loadProfileButton.Text = "...";
            this._loadProfileButton.UseVisualStyleBackColor = true;
            this._loadProfileButton.Click += new System.EventHandler(this._loadProfileButton_Click);
            // 
            // _loadProfileDialog
            // 
            this._loadProfileDialog.DefaultExt = "*.xml";
            this._loadProfileDialog.Filter = "XML-Files (*.xml)|*.xml|All-Files (*.*)|*.*";
            this._loadProfileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // _createNewProfileButton
            // 
            this._createNewProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._createNewProfileButton.Location = new System.Drawing.Point(721, 24);
            this._createNewProfileButton.Name = "_createNewProfileButton";
            this._createNewProfileButton.Size = new System.Drawing.Size(75, 23);
            this._createNewProfileButton.TabIndex = 13;
            this._createNewProfileButton.Text = "_createNewProfileButton";
            this._createNewProfileButton.UseVisualStyleBackColor = true;
            this._createNewProfileButton.Click += new System.EventHandler(this._createNewProfileButton_Click);
            // 
            // _saveProfileDialog
            // 
            this._saveProfileDialog.DefaultExt = "*.xml";
            this._saveProfileDialog.Filter = "XML-Files (*.xml)|*.xml";
            // 
            // _eventsListBox
            // 
            this._eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsListBox.FormattingEnabled = true;
            this._eventsListBox.Location = new System.Drawing.Point(12, 199);
            this._eventsListBox.Name = "_eventsListBox";
            this._eventsListBox.Size = new System.Drawing.Size(703, 160);
            this._eventsListBox.TabIndex = 14;
            this._eventsListBox.SelectedIndexChanged += new System.EventHandler(this._eventsListBox_SelectedIndexChanged);
            // 
            // _eventsLabel
            // 
            this._eventsLabel.AutoSize = true;
            this._eventsLabel.Location = new System.Drawing.Point(12, 183);
            this._eventsLabel.Name = "_eventsLabel";
            this._eventsLabel.Size = new System.Drawing.Size(71, 13);
            this._eventsLabel.TabIndex = 15;
            this._eventsLabel.Text = "_eventsLabel";
            // 
            // _eventsCreateButton
            // 
            this._eventsCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsCreateButton.Location = new System.Drawing.Point(721, 199);
            this._eventsCreateButton.Name = "_eventsCreateButton";
            this._eventsCreateButton.Size = new System.Drawing.Size(75, 23);
            this._eventsCreateButton.TabIndex = 16;
            this._eventsCreateButton.Text = "_eventsCreateButton";
            this._eventsCreateButton.UseVisualStyleBackColor = true;
            this._eventsCreateButton.Click += new System.EventHandler(this._eventsCreateButton_Click);
            // 
            // _eventsDeleteButton
            // 
            this._eventsDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsDeleteButton.Location = new System.Drawing.Point(721, 336);
            this._eventsDeleteButton.Name = "_eventsDeleteButton";
            this._eventsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this._eventsDeleteButton.TabIndex = 17;
            this._eventsDeleteButton.Text = "_eventsDeleteButton";
            this._eventsDeleteButton.UseVisualStyleBackColor = true;
            this._eventsDeleteButton.Click += new System.EventHandler(this._eventsDeleteButton_Click);
            // 
            // _eventsEditButton
            // 
            this._eventsEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._eventsEditButton.Location = new System.Drawing.Point(721, 228);
            this._eventsEditButton.Name = "_eventsEditButton";
            this._eventsEditButton.Size = new System.Drawing.Size(75, 23);
            this._eventsEditButton.TabIndex = 18;
            this._eventsEditButton.Text = "_eventsEditButton";
            this._eventsEditButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this._closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 560);
            this.Controls.Add(this._eventsEditButton);
            this.Controls.Add(this._eventsDeleteButton);
            this.Controls.Add(this._eventsCreateButton);
            this.Controls.Add(this._eventsLabel);
            this.Controls.Add(this._eventsListBox);
            this.Controls.Add(this._createNewProfileButton);
            this.Controls.Add(this._loadProfileButton);
            this.Controls.Add(this._loadProfileLabel);
            this.Controls.Add(this._loadProfileBox);
            this.Controls.Add(this._processLabel);
            this.Controls.Add(this._levelLabel);
            this.Controls.Add(this._spectrumButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this._refreshButton);
            this.Controls.Add(this._processesBox);
            this.Controls.Add(this._closeButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.ComboBox _processesBox;
        private System.Windows.Forms.Button _refreshButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button _spectrumButton;
        private System.Windows.Forms.Label _levelLabel;
        private System.Windows.Forms.Label _processLabel;
        private System.Windows.Forms.TextBox _loadProfileBox;
        private System.Windows.Forms.Label _loadProfileLabel;
        private System.Windows.Forms.Button _loadProfileButton;
        private System.Windows.Forms.OpenFileDialog _loadProfileDialog;
        private System.Windows.Forms.Button _createNewProfileButton;
        private System.Windows.Forms.SaveFileDialog _saveProfileDialog;
        private System.Windows.Forms.ListBox _eventsListBox;
        private System.Windows.Forms.Label _eventsLabel;
        private System.Windows.Forms.Button _eventsCreateButton;
        private System.Windows.Forms.Button _eventsDeleteButton;
        private System.Windows.Forms.Button _eventsEditButton;
    }
}

