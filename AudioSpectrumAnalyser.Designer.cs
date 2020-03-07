namespace SendVoiceCommands
{
    partial class AudioSpectrumAnalyser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioSpectrumAnalyser));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._okButton = new System.Windows.Forms.Button();
            this._spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._detectedFrequencyLabel = new System.Windows.Forms.Label();
            this._detectedFrequencyBox = new System.Windows.Forms.TextBox();
            this._detectLevelLabel = new System.Windows.Forms.Label();
            this._detectLevelBar = new System.Windows.Forms.TrackBar();
            this._detectLevelBox = new System.Windows.Forms.TextBox();
            this._detectedNoteLabel = new System.Windows.Forms.Label();
            this._detectedNoteBox = new System.Windows.Forms.TextBox();
            this._differenceSlider = new NAudio.Gui.PanSlider();
            this._differenceBox = new System.Windows.Forms.TextBox();
            this._differenceLabel = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Name = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
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
            // _detectedFrequencyLabel
            // 
            resources.ApplyResources(this._detectedFrequencyLabel, "_detectedFrequencyLabel");
            this._detectedFrequencyLabel.Name = "_detectedFrequencyLabel";
            // 
            // _detectedFrequencyBox
            // 
            resources.ApplyResources(this._detectedFrequencyBox, "_detectedFrequencyBox");
            this._detectedFrequencyBox.Name = "_detectedFrequencyBox";
            // 
            // _detectLevelLabel
            // 
            resources.ApplyResources(this._detectLevelLabel, "_detectLevelLabel");
            this._detectLevelLabel.Name = "_detectLevelLabel";
            // 
            // _detectLevelBar
            // 
            resources.ApplyResources(this._detectLevelBar, "_detectLevelBar");
            this._detectLevelBar.Name = "_detectLevelBar";
            this._detectLevelBar.ValueChanged += new System.EventHandler(this._detectLevelBar_ValueChanged);
            // 
            // _detectLevelBox
            // 
            resources.ApplyResources(this._detectLevelBox, "_detectLevelBox");
            this._detectLevelBox.Name = "_detectLevelBox";
            this._detectLevelBox.TextChanged += new System.EventHandler(this._detectLevelBox_TextChanged);
            this._detectLevelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._detectLevelBox_KeyPress);
            // 
            // _detectedNoteLabel
            // 
            resources.ApplyResources(this._detectedNoteLabel, "_detectedNoteLabel");
            this._detectedNoteLabel.Name = "_detectedNoteLabel";
            // 
            // _detectedNoteBox
            // 
            resources.ApplyResources(this._detectedNoteBox, "_detectedNoteBox");
            this._detectedNoteBox.Name = "_detectedNoteBox";
            // 
            // _differenceSlider
            // 
            resources.ApplyResources(this._differenceSlider, "_differenceSlider");
            this._differenceSlider.Name = "_differenceSlider";
            this._differenceSlider.Pan = 0.5F;
            // 
            // _differenceBox
            // 
            resources.ApplyResources(this._differenceBox, "_differenceBox");
            this._differenceBox.Name = "_differenceBox";
            // 
            // _differenceLabel
            // 
            resources.ApplyResources(this._differenceLabel, "_differenceLabel");
            this._differenceLabel.Name = "_differenceLabel";
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // AudioSpectrumAnalyser
            // 
            this.AcceptButton = this._okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._okButton;
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._differenceBox);
            this.Controls.Add(this._differenceSlider);
            this.Controls.Add(this._detectedNoteBox);
            this.Controls.Add(this._detectedNoteLabel);
            this.Controls.Add(this._detectLevelBox);
            this.Controls.Add(this._detectLevelBar);
            this.Controls.Add(this._detectLevelLabel);
            this.Controls.Add(this._detectedFrequencyBox);
            this.Controls.Add(this._detectedFrequencyLabel);
            this.Controls.Add(this._spectrumChart);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._differenceLabel);
            this.Name = "AudioSpectrumAnalyser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpectrumAnalyser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart _spectrumChart;
        private System.Windows.Forms.Label _detectedFrequencyLabel;
        private System.Windows.Forms.TextBox _detectedFrequencyBox;
        private System.Windows.Forms.Label _detectLevelLabel;
        private System.Windows.Forms.TrackBar _detectLevelBar;
        private System.Windows.Forms.TextBox _detectLevelBox;
        private System.Windows.Forms.Label _detectedNoteLabel;
        private System.Windows.Forms.TextBox _detectedNoteBox;
        private NAudio.Gui.PanSlider _differenceSlider;
        private System.Windows.Forms.TextBox _differenceBox;
        private System.Windows.Forms.Label _differenceLabel;
        private System.Windows.Forms.Button _cancelButton;
    }
}