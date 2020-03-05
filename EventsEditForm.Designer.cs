namespace SendVoiceCommands
{
    partial class EventsEditForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._detectedFrequencyBox = new System.Windows.Forms.TextBox();
            this._detectedFrequencyLabel = new System.Windows.Forms.Label();
            this._detectedNoteBox = new System.Windows.Forms.TextBox();
            this._detectedNoteLabel = new System.Windows.Forms.Label();
            this._differenceBox = new System.Windows.Forms.TextBox();
            this._differenceSlider = new NAudio.Gui.PanSlider();
            this._differenceLabel = new System.Windows.Forms.Label();
            this._infoPanel = new System.Windows.Forms.Panel();
            this._infoLabel = new System.Windows.Forms.Label();
            this._detectLevelBox = new System.Windows.Forms.TextBox();
            this._detectLevelBar = new System.Windows.Forms.TrackBar();
            this._detectLevelLabel = new System.Windows.Forms.Label();
            this._spectrumPanel = new System.Windows.Forms.Panel();
            this._spectrumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).BeginInit();
            this._infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).BeginInit();
            this._spectrumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(951, 577);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(870, 577);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _spectrumChart
            // 
            this._spectrumChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this._spectrumChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this._spectrumChart.Legends.Add(legend1);
            this._spectrumChart.Location = new System.Drawing.Point(13, 68);
            this._spectrumChart.Name = "_spectrumChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "spectrumSeries";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "detectLevelSeries";
            this._spectrumChart.Series.Add(series1);
            this._spectrumChart.Series.Add(series2);
            this._spectrumChart.Size = new System.Drawing.Size(983, 167);
            this._spectrumChart.TabIndex = 8;
            this._spectrumChart.Text = "_spectrumChart";
            // 
            // _detectedFrequencyBox
            // 
            this._detectedFrequencyBox.Enabled = false;
            this._detectedFrequencyBox.Location = new System.Drawing.Point(124, 12);
            this._detectedFrequencyBox.Name = "_detectedFrequencyBox";
            this._detectedFrequencyBox.Size = new System.Drawing.Size(100, 20);
            this._detectedFrequencyBox.TabIndex = 11;
            this._detectedFrequencyBox.Text = "_detectedFrequencyBox";
            this._detectedFrequencyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _detectedFrequencyLabel
            // 
            this._detectedFrequencyLabel.AutoSize = true;
            this._detectedFrequencyLabel.Location = new System.Drawing.Point(10, 15);
            this._detectedFrequencyLabel.Name = "_detectedFrequencyLabel";
            this._detectedFrequencyLabel.Size = new System.Drawing.Size(131, 13);
            this._detectedFrequencyLabel.TabIndex = 10;
            this._detectedFrequencyLabel.Text = "_detectedFrequencyLabel";
            // 
            // _detectedNoteBox
            // 
            this._detectedNoteBox.Location = new System.Drawing.Point(124, 38);
            this._detectedNoteBox.Name = "_detectedNoteBox";
            this._detectedNoteBox.Size = new System.Drawing.Size(100, 20);
            this._detectedNoteBox.TabIndex = 16;
            this._detectedNoteBox.Text = "_detectedNoteBox";
            // 
            // _detectedNoteLabel
            // 
            this._detectedNoteLabel.AutoSize = true;
            this._detectedNoteLabel.Location = new System.Drawing.Point(10, 41);
            this._detectedNoteLabel.Name = "_detectedNoteLabel";
            this._detectedNoteLabel.Size = new System.Drawing.Size(104, 13);
            this._detectedNoteLabel.TabIndex = 15;
            this._detectedNoteLabel.Text = "_detectedNoteLabel";
            // 
            // _differenceBox
            // 
            this._differenceBox.Location = new System.Drawing.Point(558, 38);
            this._differenceBox.Name = "_differenceBox";
            this._differenceBox.Size = new System.Drawing.Size(100, 20);
            this._differenceBox.TabIndex = 19;
            this._differenceBox.Text = "_differenceBox";
            // 
            // _differenceSlider
            // 
            this._differenceSlider.Location = new System.Drawing.Point(297, 38);
            this._differenceSlider.Name = "_differenceSlider";
            this._differenceSlider.Pan = 0.5F;
            this._differenceSlider.Size = new System.Drawing.Size(255, 20);
            this._differenceSlider.TabIndex = 18;
            // 
            // _differenceLabel
            // 
            this._differenceLabel.AutoSize = true;
            this._differenceLabel.Location = new System.Drawing.Point(237, 41);
            this._differenceLabel.Name = "_differenceLabel";
            this._differenceLabel.Size = new System.Drawing.Size(86, 13);
            this._differenceLabel.TabIndex = 20;
            this._differenceLabel.Text = "_differenceLabel";
            // 
            // _infoPanel
            // 
            this._infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._infoPanel.Controls.Add(this._detectedNoteBox);
            this._infoPanel.Controls.Add(this._detectedFrequencyLabel);
            this._infoPanel.Controls.Add(this._differenceBox);
            this._infoPanel.Controls.Add(this._detectedFrequencyBox);
            this._infoPanel.Controls.Add(this._differenceSlider);
            this._infoPanel.Controls.Add(this._detectedNoteLabel);
            this._infoPanel.Controls.Add(this._differenceLabel);
            this._infoPanel.Location = new System.Drawing.Point(12, 25);
            this._infoPanel.Name = "_infoPanel";
            this._infoPanel.Size = new System.Drawing.Size(1014, 79);
            this._infoPanel.TabIndex = 21;
            // 
            // _infoLabel
            // 
            this._infoLabel.AutoSize = true;
            this._infoLabel.Location = new System.Drawing.Point(9, 9);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(56, 13);
            this._infoLabel.TabIndex = 22;
            this._infoLabel.Text = "_infoLabel";
            // 
            // _detectLevelBox
            // 
            this._detectLevelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._detectLevelBox.Location = new System.Drawing.Point(874, 16);
            this._detectLevelBox.Name = "_detectLevelBox";
            this._detectLevelBox.Size = new System.Drawing.Size(122, 20);
            this._detectLevelBox.TabIndex = 25;
            this._detectLevelBox.Text = "_detectLevelBox";
            this._detectLevelBox.TextChanged += new System.EventHandler(this._detectLevelBox_TextChanged);
            this._detectLevelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._detectLevelBox_KeyPress);
            // 
            // _detectLevelBar
            // 
            this._detectLevelBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._detectLevelBar.Location = new System.Drawing.Point(114, 13);
            this._detectLevelBar.Name = "_detectLevelBar";
            this._detectLevelBar.Size = new System.Drawing.Size(740, 45);
            this._detectLevelBar.TabIndex = 24;
            this._detectLevelBar.ValueChanged += new System.EventHandler(this._detectLevelBar_ValueChanged);
            // 
            // _detectLevelLabel
            // 
            this._detectLevelLabel.AutoSize = true;
            this._detectLevelLabel.Location = new System.Drawing.Point(10, 16);
            this._detectLevelLabel.Name = "_detectLevelLabel";
            this._detectLevelLabel.Size = new System.Drawing.Size(95, 13);
            this._detectLevelLabel.TabIndex = 23;
            this._detectLevelLabel.Text = "_detectLevelLabel";
            // 
            // _spectrumPanel
            // 
            this._spectrumPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._spectrumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._spectrumPanel.Controls.Add(this._detectLevelBar);
            this._spectrumPanel.Controls.Add(this._detectLevelLabel);
            this._spectrumPanel.Controls.Add(this._detectLevelBox);
            this._spectrumPanel.Controls.Add(this._spectrumChart);
            this._spectrumPanel.Location = new System.Drawing.Point(12, 146);
            this._spectrumPanel.Name = "_spectrumPanel";
            this._spectrumPanel.Size = new System.Drawing.Size(1013, 250);
            this._spectrumPanel.TabIndex = 26;
            // 
            // _spectrumLabel
            // 
            this._spectrumLabel.AutoSize = true;
            this._spectrumLabel.Location = new System.Drawing.Point(9, 130);
            this._spectrumLabel.Name = "_spectrumLabel";
            this._spectrumLabel.Size = new System.Drawing.Size(82, 13);
            this._spectrumLabel.TabIndex = 27;
            this._spectrumLabel.Text = "_spectrumLabel";
            // 
            // EventsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 612);
            this.Controls.Add(this._spectrumLabel);
            this.Controls.Add(this._spectrumPanel);
            this.Controls.Add(this._infoLabel);
            this.Controls.Add(this._infoPanel);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Name = "EventsEditForm";
            this.Text = "EventsEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).EndInit();
            this._infoPanel.ResumeLayout(false);
            this._infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).EndInit();
            this._spectrumPanel.ResumeLayout(false);
            this._spectrumPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart _spectrumChart;
        private System.Windows.Forms.TextBox _detectedFrequencyBox;
        private System.Windows.Forms.Label _detectedFrequencyLabel;
        private System.Windows.Forms.TextBox _detectedNoteBox;
        private System.Windows.Forms.Label _detectedNoteLabel;
        private System.Windows.Forms.TextBox _differenceBox;
        private NAudio.Gui.PanSlider _differenceSlider;
        private System.Windows.Forms.Label _differenceLabel;
        private System.Windows.Forms.Panel _infoPanel;
        private System.Windows.Forms.Label _infoLabel;
        private System.Windows.Forms.TextBox _detectLevelBox;
        private System.Windows.Forms.TrackBar _detectLevelBar;
        private System.Windows.Forms.Label _detectLevelLabel;
        private System.Windows.Forms.Panel _spectrumPanel;
        private System.Windows.Forms.Label _spectrumLabel;
    }
}