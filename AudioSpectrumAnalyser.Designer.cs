﻿namespace SendVoiceCommands
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._closeButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._closeButton.Location = new System.Drawing.Point(1011, 622);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "_closeButton";
            this._closeButton.UseVisualStyleBackColor = true;
            // 
            // _spectrumChart
            // 
            this._spectrumChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this._spectrumChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this._spectrumChart.Legends.Add(legend2);
            this._spectrumChart.Location = new System.Drawing.Point(12, 139);
            this._spectrumChart.Name = "_spectrumChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "spectrumSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "detectLevelSeries";
            this._spectrumChart.Series.Add(series3);
            this._spectrumChart.Series.Add(series4);
            this._spectrumChart.Size = new System.Drawing.Size(1074, 466);
            this._spectrumChart.TabIndex = 7;
            this._spectrumChart.Text = "_spectrumChart";
            // 
            // _detectedFrequencyLabel
            // 
            this._detectedFrequencyLabel.AutoSize = true;
            this._detectedFrequencyLabel.Location = new System.Drawing.Point(12, 66);
            this._detectedFrequencyLabel.Name = "_detectedFrequencyLabel";
            this._detectedFrequencyLabel.Size = new System.Drawing.Size(131, 13);
            this._detectedFrequencyLabel.TabIndex = 8;
            this._detectedFrequencyLabel.Text = "_detectedFrequencyLabel";
            // 
            // _detectedFrequencyBox
            // 
            this._detectedFrequencyBox.Enabled = false;
            this._detectedFrequencyBox.Location = new System.Drawing.Point(117, 63);
            this._detectedFrequencyBox.Name = "_detectedFrequencyBox";
            this._detectedFrequencyBox.Size = new System.Drawing.Size(100, 20);
            this._detectedFrequencyBox.TabIndex = 9;
            this._detectedFrequencyBox.Text = "_detectedFrequencyBox";
            this._detectedFrequencyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _detectLevelLabel
            // 
            this._detectLevelLabel.AutoSize = true;
            this._detectLevelLabel.Location = new System.Drawing.Point(12, 15);
            this._detectLevelLabel.Name = "_detectLevelLabel";
            this._detectLevelLabel.Size = new System.Drawing.Size(95, 13);
            this._detectLevelLabel.TabIndex = 10;
            this._detectLevelLabel.Text = "_detectLevelLabel";
            // 
            // _detectLevelBar
            // 
            this._detectLevelBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._detectLevelBar.Location = new System.Drawing.Point(117, 12);
            this._detectLevelBar.Name = "_detectLevelBar";
            this._detectLevelBar.Size = new System.Drawing.Size(841, 45);
            this._detectLevelBar.TabIndex = 11;
            this._detectLevelBar.ValueChanged += new System.EventHandler(this._detectLevelBar_ValueChanged);
            // 
            // _detectLevelBox
            // 
            this._detectLevelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._detectLevelBox.Location = new System.Drawing.Point(964, 12);
            this._detectLevelBox.Name = "_detectLevelBox";
            this._detectLevelBox.Size = new System.Drawing.Size(122, 20);
            this._detectLevelBox.TabIndex = 12;
            this._detectLevelBox.Text = "_detectLevelBox";
            this._detectLevelBox.TextChanged += new System.EventHandler(this._detectLevelBox_TextChanged);
            this._detectLevelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._detectLevelBox_KeyPress);
            // 
            // _detectedNoteLabel
            // 
            this._detectedNoteLabel.AutoSize = true;
            this._detectedNoteLabel.Location = new System.Drawing.Point(12, 98);
            this._detectedNoteLabel.Name = "_detectedNoteLabel";
            this._detectedNoteLabel.Size = new System.Drawing.Size(104, 13);
            this._detectedNoteLabel.TabIndex = 13;
            this._detectedNoteLabel.Text = "_detectedNoteLabel";
            // 
            // _detectedNoteBox
            // 
            this._detectedNoteBox.Location = new System.Drawing.Point(117, 95);
            this._detectedNoteBox.Name = "_detectedNoteBox";
            this._detectedNoteBox.Size = new System.Drawing.Size(100, 20);
            this._detectedNoteBox.TabIndex = 14;
            this._detectedNoteBox.Text = "_detectedNoteBox";
            // 
            // _differenceSlider
            // 
            this._differenceSlider.Location = new System.Drawing.Point(309, 95);
            this._differenceSlider.Name = "_differenceSlider";
            this._differenceSlider.Pan = 0.5F;
            this._differenceSlider.Size = new System.Drawing.Size(255, 20);
            this._differenceSlider.TabIndex = 15;
            // 
            // _differenceBox
            // 
            this._differenceBox.Location = new System.Drawing.Point(570, 95);
            this._differenceBox.Name = "_differenceBox";
            this._differenceBox.Size = new System.Drawing.Size(100, 20);
            this._differenceBox.TabIndex = 16;
            this._differenceBox.Text = "_differenceBox";
            // 
            // _differenceLabel
            // 
            this._differenceLabel.AutoSize = true;
            this._differenceLabel.Location = new System.Drawing.Point(249, 98);
            this._differenceLabel.Name = "_differenceLabel";
            this._differenceLabel.Size = new System.Drawing.Size(86, 13);
            this._differenceLabel.TabIndex = 17;
            this._differenceLabel.Text = "_differenceLabel";
            // 
            // AudioSpectrumAnalyser
            // 
            this.AcceptButton = this._closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._closeButton;
            this.ClientSize = new System.Drawing.Size(1098, 657);
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
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._differenceLabel);
            this.Name = "AudioSpectrumAnalyser";
            this.Text = "SpectrumAnalyser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpectrumAnalyser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._spectrumChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._detectLevelBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
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
    }
}