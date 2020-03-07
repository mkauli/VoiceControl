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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this._languageLabel = new System.Windows.Forms.Label();
            this._languageBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            resources.ApplyResources(this._closeButton, "_closeButton");
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Name = "_closeButton";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.closeButton__Click);
            // 
            // _processesBox
            // 
            resources.ApplyResources(this._processesBox, "_processesBox");
            this._processesBox.FormattingEnabled = true;
            this._processesBox.Name = "_processesBox";
            this._processesBox.SelectedIndexChanged += new System.EventHandler(this._processesBox_SelectedIndexChanged);
            // 
            // _refreshButton
            // 
            resources.ApplyResources(this._refreshButton, "_refreshButton");
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this._refreshButton_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // _spectrumButton
            // 
            resources.ApplyResources(this._spectrumButton, "_spectrumButton");
            this._spectrumButton.Name = "_spectrumButton";
            this._spectrumButton.UseVisualStyleBackColor = true;
            this._spectrumButton.Click += new System.EventHandler(this._spectrumButton_Click);
            // 
            // _levelLabel
            // 
            resources.ApplyResources(this._levelLabel, "_levelLabel");
            this._levelLabel.Name = "_levelLabel";
            // 
            // _processLabel
            // 
            resources.ApplyResources(this._processLabel, "_processLabel");
            this._processLabel.Name = "_processLabel";
            // 
            // _loadProfileBox
            // 
            resources.ApplyResources(this._loadProfileBox, "_loadProfileBox");
            this._loadProfileBox.Name = "_loadProfileBox";
            this._loadProfileBox.TextChanged += new System.EventHandler(this._loadProfileBox_TextChanged);
            // 
            // _loadProfileLabel
            // 
            resources.ApplyResources(this._loadProfileLabel, "_loadProfileLabel");
            this._loadProfileLabel.Name = "_loadProfileLabel";
            // 
            // _loadProfileButton
            // 
            resources.ApplyResources(this._loadProfileButton, "_loadProfileButton");
            this._loadProfileButton.Name = "_loadProfileButton";
            this._loadProfileButton.UseVisualStyleBackColor = true;
            this._loadProfileButton.Click += new System.EventHandler(this._loadProfileButton_Click);
            // 
            // _loadProfileDialog
            // 
            this._loadProfileDialog.DefaultExt = "*.xml";
            resources.ApplyResources(this._loadProfileDialog, "_loadProfileDialog");
            this._loadProfileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // _createNewProfileButton
            // 
            resources.ApplyResources(this._createNewProfileButton, "_createNewProfileButton");
            this._createNewProfileButton.Name = "_createNewProfileButton";
            this._createNewProfileButton.UseVisualStyleBackColor = true;
            this._createNewProfileButton.Click += new System.EventHandler(this._createNewProfileButton_Click);
            // 
            // _saveProfileDialog
            // 
            this._saveProfileDialog.DefaultExt = "*.xml";
            resources.ApplyResources(this._saveProfileDialog, "_saveProfileDialog");
            // 
            // _eventsListBox
            // 
            resources.ApplyResources(this._eventsListBox, "_eventsListBox");
            this._eventsListBox.FormattingEnabled = true;
            this._eventsListBox.Name = "_eventsListBox";
            this._eventsListBox.SelectedIndexChanged += new System.EventHandler(this._eventsListBox_SelectedIndexChanged);
            // 
            // _eventsLabel
            // 
            resources.ApplyResources(this._eventsLabel, "_eventsLabel");
            this._eventsLabel.Name = "_eventsLabel";
            // 
            // _eventsCreateButton
            // 
            resources.ApplyResources(this._eventsCreateButton, "_eventsCreateButton");
            this._eventsCreateButton.Name = "_eventsCreateButton";
            this._eventsCreateButton.UseVisualStyleBackColor = true;
            this._eventsCreateButton.Click += new System.EventHandler(this._eventsCreateButton_Click);
            // 
            // _eventsDeleteButton
            // 
            resources.ApplyResources(this._eventsDeleteButton, "_eventsDeleteButton");
            this._eventsDeleteButton.Name = "_eventsDeleteButton";
            this._eventsDeleteButton.UseVisualStyleBackColor = true;
            this._eventsDeleteButton.Click += new System.EventHandler(this._eventsDeleteButton_Click);
            // 
            // _eventsEditButton
            // 
            resources.ApplyResources(this._eventsEditButton, "_eventsEditButton");
            this._eventsEditButton.Name = "_eventsEditButton";
            this._eventsEditButton.UseVisualStyleBackColor = true;
            this._eventsEditButton.Click += new System.EventHandler(this._eventsEditButton_Click);
            // 
            // _languageLabel
            // 
            resources.ApplyResources(this._languageLabel, "_languageLabel");
            this._languageLabel.Name = "_languageLabel";
            // 
            // _languageBox
            // 
            resources.ApplyResources(this._languageBox, "_languageBox");
            this._languageBox.FormattingEnabled = true;
            this._languageBox.Items.AddRange(new object[] {
            resources.GetString("_languageBox.Items"),
            resources.GetString("_languageBox.Items1")});
            this._languageBox.Name = "_languageBox";
            this._languageBox.SelectedIndexChanged += new System.EventHandler(this._languageBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this._closeButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._languageBox);
            this.Controls.Add(this._languageLabel);
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
        private System.Windows.Forms.Label _languageLabel;
        private System.Windows.Forms.ComboBox _languageBox;
    }
}

