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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsEditForm));
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
            this._eventPanel = new System.Windows.Forms.Panel();
            this._toleranceUpDown = new System.Windows.Forms.NumericUpDown();
            this._toleranceLabel = new System.Windows.Forms.Label();
            this._musicalNoteBox = new System.Windows.Forms.TextBox();
            this._musicalNoteLabel = new System.Windows.Forms.Label();
            this._nameBox = new System.Windows.Forms.TextBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._eventBox = new System.Windows.Forms.TextBox();
            this._keyLabel = new System.Windows.Forms.Label();
            this._eventLabel = new System.Windows.Forms.Label();
            this._testEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).BeginInit();
            this._infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).BeginInit();
            this._spectrumPanel.SuspendLayout();
            this._eventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._toleranceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Name = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _spectrumChart
            // 
            resources.ApplyResources(this._spectrumChart, "_spectrumChart");
            chartArea1.Name = "ChartArea1";
            this._spectrumChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this._spectrumChart.Legends.Add(legend1);
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
            // 
            // _detectedFrequencyBox
            // 
            resources.ApplyResources(this._detectedFrequencyBox, "_detectedFrequencyBox");
            this._detectedFrequencyBox.Name = "_detectedFrequencyBox";
            // 
            // _detectedFrequencyLabel
            // 
            resources.ApplyResources(this._detectedFrequencyLabel, "_detectedFrequencyLabel");
            this._detectedFrequencyLabel.Name = "_detectedFrequencyLabel";
            // 
            // _detectedNoteBox
            // 
            resources.ApplyResources(this._detectedNoteBox, "_detectedNoteBox");
            this._detectedNoteBox.Name = "_detectedNoteBox";
            // 
            // _detectedNoteLabel
            // 
            resources.ApplyResources(this._detectedNoteLabel, "_detectedNoteLabel");
            this._detectedNoteLabel.Name = "_detectedNoteLabel";
            // 
            // _differenceBox
            // 
            resources.ApplyResources(this._differenceBox, "_differenceBox");
            this._differenceBox.Name = "_differenceBox";
            // 
            // _differenceSlider
            // 
            resources.ApplyResources(this._differenceSlider, "_differenceSlider");
            this._differenceSlider.Name = "_differenceSlider";
            this._differenceSlider.Pan = 0.5F;
            // 
            // _differenceLabel
            // 
            resources.ApplyResources(this._differenceLabel, "_differenceLabel");
            this._differenceLabel.Name = "_differenceLabel";
            // 
            // _infoPanel
            // 
            resources.ApplyResources(this._infoPanel, "_infoPanel");
            this._infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._infoPanel.Controls.Add(this._detectedNoteBox);
            this._infoPanel.Controls.Add(this._differenceBox);
            this._infoPanel.Controls.Add(this._detectedFrequencyBox);
            this._infoPanel.Controls.Add(this._differenceSlider);
            this._infoPanel.Controls.Add(this._detectedNoteLabel);
            this._infoPanel.Controls.Add(this._differenceLabel);
            this._infoPanel.Controls.Add(this._detectedFrequencyLabel);
            this._infoPanel.Name = "_infoPanel";
            // 
            // _infoLabel
            // 
            resources.ApplyResources(this._infoLabel, "_infoLabel");
            this._infoLabel.Name = "_infoLabel";
            // 
            // _detectLevelBox
            // 
            resources.ApplyResources(this._detectLevelBox, "_detectLevelBox");
            this._detectLevelBox.Name = "_detectLevelBox";
            this._detectLevelBox.TextChanged += new System.EventHandler(this._detectLevelBox_TextChanged);
            this._detectLevelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._detectLevelBox_KeyPress);
            // 
            // _detectLevelBar
            // 
            resources.ApplyResources(this._detectLevelBar, "_detectLevelBar");
            this._detectLevelBar.Name = "_detectLevelBar";
            this._detectLevelBar.ValueChanged += new System.EventHandler(this._detectLevelBar_ValueChanged);
            // 
            // _detectLevelLabel
            // 
            resources.ApplyResources(this._detectLevelLabel, "_detectLevelLabel");
            this._detectLevelLabel.Name = "_detectLevelLabel";
            // 
            // _spectrumPanel
            // 
            resources.ApplyResources(this._spectrumPanel, "_spectrumPanel");
            this._spectrumPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._spectrumPanel.Controls.Add(this._detectLevelBar);
            this._spectrumPanel.Controls.Add(this._detectLevelLabel);
            this._spectrumPanel.Controls.Add(this._detectLevelBox);
            this._spectrumPanel.Controls.Add(this._spectrumChart);
            this._spectrumPanel.Name = "_spectrumPanel";
            // 
            // _spectrumLabel
            // 
            resources.ApplyResources(this._spectrumLabel, "_spectrumLabel");
            this._spectrumLabel.Name = "_spectrumLabel";
            // 
            // _eventPanel
            // 
            resources.ApplyResources(this._eventPanel, "_eventPanel");
            this._eventPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._eventPanel.Controls.Add(this._toleranceUpDown);
            this._eventPanel.Controls.Add(this._toleranceLabel);
            this._eventPanel.Controls.Add(this._musicalNoteBox);
            this._eventPanel.Controls.Add(this._musicalNoteLabel);
            this._eventPanel.Controls.Add(this._nameBox);
            this._eventPanel.Controls.Add(this._nameLabel);
            this._eventPanel.Controls.Add(this._eventBox);
            this._eventPanel.Controls.Add(this._keyLabel);
            this._eventPanel.Name = "_eventPanel";
            // 
            // _toleranceUpDown
            // 
            resources.ApplyResources(this._toleranceUpDown, "_toleranceUpDown");
            this._toleranceUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this._toleranceUpDown.Name = "_toleranceUpDown";
            this._toleranceUpDown.ValueChanged += new System.EventHandler(this._toleranceUpDown_ValueChanged);
            // 
            // _toleranceLabel
            // 
            resources.ApplyResources(this._toleranceLabel, "_toleranceLabel");
            this._toleranceLabel.Name = "_toleranceLabel";
            // 
            // _musicalNoteBox
            // 
            resources.ApplyResources(this._musicalNoteBox, "_musicalNoteBox");
            this._musicalNoteBox.Name = "_musicalNoteBox";
            // 
            // _musicalNoteLabel
            // 
            resources.ApplyResources(this._musicalNoteLabel, "_musicalNoteLabel");
            this._musicalNoteLabel.Name = "_musicalNoteLabel";
            // 
            // _nameBox
            // 
            resources.ApplyResources(this._nameBox, "_nameBox");
            this._nameBox.Name = "_nameBox";
            this._nameBox.TextChanged += new System.EventHandler(this._nameBox_TextChanged);
            // 
            // _nameLabel
            // 
            resources.ApplyResources(this._nameLabel, "_nameLabel");
            this._nameLabel.Name = "_nameLabel";
            // 
            // _eventBox
            // 
            resources.ApplyResources(this._eventBox, "_eventBox");
            this._eventBox.Name = "_eventBox";
            this._eventBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._eventBox_KeyDown);
            // 
            // _keyLabel
            // 
            resources.ApplyResources(this._keyLabel, "_keyLabel");
            this._keyLabel.Name = "_keyLabel";
            // 
            // _eventLabel
            // 
            resources.ApplyResources(this._eventLabel, "_eventLabel");
            this._eventLabel.Name = "_eventLabel";
            // 
            // _testEventButton
            // 
            resources.ApplyResources(this._testEventButton, "_testEventButton");
            this._testEventButton.Name = "_testEventButton";
            this._testEventButton.UseVisualStyleBackColor = true;
            this._testEventButton.Click += new System.EventHandler(this._testEventButton_Click);
            // 
            // EventsEditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._testEventButton);
            this.Controls.Add(this._eventLabel);
            this.Controls.Add(this._eventPanel);
            this.Controls.Add(this._spectrumLabel);
            this.Controls.Add(this._spectrumPanel);
            this.Controls.Add(this._infoLabel);
            this.Controls.Add(this._infoPanel);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Name = "EventsEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).EndInit();
            this._infoPanel.ResumeLayout(false);
            this._infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).EndInit();
            this._spectrumPanel.ResumeLayout(false);
            this._spectrumPanel.PerformLayout();
            this._eventPanel.ResumeLayout(false);
            this._eventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._toleranceUpDown)).EndInit();
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
        private System.Windows.Forms.Panel _eventPanel;
        private System.Windows.Forms.Label _eventLabel;
        private System.Windows.Forms.Label _keyLabel;
        private System.Windows.Forms.TextBox _eventBox;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _nameBox;
        private System.Windows.Forms.Label _musicalNoteLabel;
        private System.Windows.Forms.TextBox _musicalNoteBox;
        private System.Windows.Forms.Label _toleranceLabel;
        private System.Windows.Forms.NumericUpDown _toleranceUpDown;
        private System.Windows.Forms.Button _testEventButton;
    }
}